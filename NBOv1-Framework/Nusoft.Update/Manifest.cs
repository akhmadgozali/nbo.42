using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Web.Configuration;
using System.Xml.Serialization;
using Nusoft.Update.Config;

namespace Nusoft.Update {
	internal class AppManifest {
		private readonly string _fileName;
		private readonly UDMode _mode;
		private readonly string _mainPath;
		private readonly string _fileException;
		private readonly string _folderExceptionDownload;
		private readonly string _folderExceptionUpload;

		internal List<FileSync> DeletedFile { get; private set; }
		internal List<FileSync> ProcessedFile { get; private set; }

		internal AppManifest(string FileName, UDMode Mode, string MainPath, string FileException, string FolderExceptionDownload, string FolderExceptionUpload) {
			_fileName = FileName;
			_mode = Mode;
			_mainPath = MainPath;
			_fileException = FileException;
			_folderExceptionDownload = FolderExceptionDownload;
			_folderExceptionUpload = FolderExceptionUpload;
		}

		internal void ManageManifest() {
			// load xml
			List<FileSync> loadedManifest = null;
			if (File.Exists(_fileName)) {
				XmlSerializer serializer = new XmlSerializer(typeof(List<FileSync>));
				using (FileStream stream = File.OpenRead(_fileName)) {
					loadedManifest = (List<FileSync>)serializer.Deserialize(stream);
				}
			}
			if (loadedManifest == null) loadedManifest = new List<FileSync>();
			var _exceptionFile = _fileException.ToLower().Split(',').ToList();
			var _exceptionFolderUpload = _folderExceptionUpload.ToLower().Split(',').ToList();
			var _exceptionFolderDownload = _folderExceptionDownload.ToLower().Split(',').ToList();

			if (_mode == UDMode.Upload) {
				// check unused file -- remove from manifest
				DeletedFile = new List<FileSync>();
				for (int i = loadedManifest.Count - 1; i >= 0; i--) {
					var item = loadedManifest[i];
					var file = Path.Combine(_mainPath, item.FileName);
					if (!File.Exists(file)) {
						DeletedFile.Add(item);
						loadedManifest.Remove(item);
					}
				}

				// compare crc file in local to manifest -- add to manifest
				ProcessedFile = new List<FileSync>();
				CompareLocalToManifest(_mainPath, loadedManifest, _exceptionFile, _exceptionFolderUpload);

				// write to manifest
				if (File.Exists(_fileName)) File.Delete(_fileName);
				XmlSerializer serializer = new XmlSerializer(typeof(List<FileSync>));
				using (FileStream stream = File.OpenWrite(_fileName)) {
					serializer.Serialize(stream, loadedManifest);
				}
			}
			else if (_mode == UDMode.Download) {
				// compare crc file in manifest to local -- add to local folder
				ProcessedFile = new List<FileSync>();
				CompareManifestToLocal(_mainPath, loadedManifest, _exceptionFile, _exceptionFolderDownload);
			}
		}

		private void CompareLocalToManifest(string folder, List<FileSync> manifest, List<string> exceptionFile, List<string> exceptionFolder) { // upload
			var fileList = Directory.EnumerateFiles(folder);
			foreach (var item in fileList) {
				var fileName = item.Replace(_mainPath + @"\", "");
				if (!exceptionFile.Contains(fileName.ToLower())) {
					var crc = Crc32.GetCrc32String(item);
					var manifestItem = manifest.Find(f => f.FileName == fileName);
					if (manifestItem == null) {
						manifestItem = new FileSync() { FileName = fileName, CRC = crc, Updated = DateTime.Now };
						manifest.Add(manifestItem);
						ProcessedFile.Add(manifestItem);
					}
					else {
						if (manifestItem.CRC != crc) {
							manifestItem.CRC = crc;
							manifestItem.Updated = DateTime.Now;
							ProcessedFile.Add(manifestItem);
						}
					}
				}
			}

			var folderList = Directory.EnumerateDirectories(folder);
			foreach (var item in folderList) {
				var pathFolder = Path.Combine(folder, item).Replace(_mainPath + @"\", "");
				if (!exceptionFolder.Contains(pathFolder.ToLower())) {
					CompareLocalToManifest(item, manifest, exceptionFile, exceptionFolder);
				}
			}
		}
		private void CompareManifestToLocal(string folder, List<FileSync> manifest, List<string> exceptionFile, List<string> exceptionFolder) {
			foreach (var man in manifest) {
				var manfolder = Path.GetDirectoryName(man.FileName);
				if (!string.IsNullOrEmpty(manfolder)) {
					if (exceptionFolder.Contains(GetRootFolder(manfolder.ToLower()))) {
						continue;
					}
					if (exceptionFolder.Contains(manfolder.ToLower())) {
						continue;
					}
				}
				if (!exceptionFile.Contains(man.FileName.ToLower())) {
					var localFileName = Path.Combine(folder, man.FileName);
					if (File.Exists(localFileName)) {
						var crc = Crc32.GetCrc32String(localFileName);
						if (man.CRC != crc) ProcessedFile.Add(man);
					}
					else ProcessedFile.Add(man);
				}
			}
		}

		private string GetRootFolder(string path) {
			while (true) {
				string temp = Path.GetDirectoryName(path);
				if (string.IsNullOrEmpty(temp))
					break;
				path = temp;
			}
			return path;
		}
	}

	public class FileSync {
		public string FileName { get; set; }
		public string CRC { get; set; }
		public DateTime Updated { get; set; }
	}
}