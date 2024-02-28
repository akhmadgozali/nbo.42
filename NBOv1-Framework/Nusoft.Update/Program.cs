using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using Nusoft.Update.Config;

namespace Nusoft.Update {
	class Program {
		private static string AppServer;
		private static string AppPort;
		private static string AppUser;
		private static string AppPass;
		private static UDMode AppMode;
		private static UDTransferMethod AppTransferMethod;
		private static string AppMainPath;
		private static string AppFileException;
		private static string AppFolderExceptionDownload;
		private static string AppFolderExceptionUpload;

		private static string AppName;
		private static string AppFullPathName;
		private static string AppLocationRoot;
		private static string AppLocationMain;
		private const string AppManifestFileName = "manifest.xml";
		private const string AppBatchFile = "ud.bat";
		private static string AppCaller;

		static void Main(string[] args) {
			bool exitConfirmation = true;

			AppConfig.ReadAllConfig();
			Enum.TryParse(AppConfig.GetValue(UDConfigName.Mode), false, out AppMode);
			Enum.TryParse(AppConfig.GetValue(UDConfigName.TransferMethod), false, out AppTransferMethod);
			AppServer = AppConfig.GetValue(UDConfigName.Server);
			AppPort = AppConfig.GetValue(UDConfigName.Port);
			AppUser = AppConfig.GetValue(UDConfigName.User);
			AppPass = AppConfig.GetValue(UDConfigName.Pass);
			AppMainPath = AppConfig.GetValue(UDConfigName.Path);
			AppFileException = AppConfig.GetValue(UDConfigName.FileException);
			AppFolderExceptionDownload = AppConfig.GetValue(UDConfigName.FolderExceptionDownload);
			AppFolderExceptionUpload = AppConfig.GetValue(UDConfigName.FolderExceptionUpload);

			AppName = Assembly.GetExecutingAssembly().GetName().ToString();
			AppFullPathName = Assembly.GetExecutingAssembly().Location;
			AppLocationRoot = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
			AppLocationMain = Path.Combine(AppLocationRoot, AppMainPath);

			if (!string.IsNullOrEmpty(AppUser)) AppUser = AES.Decrypt(AppName, AppUser);
			if (!string.IsNullOrEmpty(AppPass)) AppPass = AES.Decrypt(AppName, AppPass);
			string UDFiles = "FluentFTP.dll," + Path.GetFileName(AppFullPathName) + "," + Path.GetFileName(AppFullPathName) + ".config," + AppManifestFileName + "," + AppBatchFile + ",";
			AppFileException = UDFiles + AppFileException;
			AppCaller = string.Empty;

			if (args.GetUpperBound(0) >= 0) {
				exitConfirmation = false;
				AppServer = string.Empty;
				AppPort = string.Empty;
				AppUser = string.Empty;
				AppPass = string.Empty;
				AppFileException = string.Empty;
				AppFolderExceptionDownload = string.Empty;
				AppFolderExceptionUpload = string.Empty;

				foreach (var x in args) {
					var splite = x.Split('=');
					if (splite.GetUpperBound(0) > 0) {
						switch (splite[0]) {
							case "--server": AppServer = splite[1]; break;
							case "--port": AppPort = splite[1]; break;
							case "--user": AppUser = splite[1]; break;
							case "--password": AppPass = splite[1]; break;
							case "--transfer": Enum.TryParse(splite[1], false, out AppTransferMethod); break;
							case "--caller": AppCaller = splite[1]; break;
							case "--fileexception": AppFileException = splite[1]; break;
							case "--folderexception": AppFolderExceptionDownload = splite[1]; break;
						}
					}
				}
				if (string.IsNullOrEmpty(AppServer) || string.IsNullOrEmpty(AppPort) || string.IsNullOrEmpty(AppUser) || string.IsNullOrEmpty(AppPass) || string.IsNullOrEmpty(AppCaller)) return;
				AppMode = UDMode.Download;
			}

			// cek konfigurasi, jika kosong tampilkan prompt
			if (string.IsNullOrEmpty(AppServer)) {
				AppUser = CekEmpty("Server", false);
				AppConfig.SetValue(UDConfigName.Server, AppServer);
			}
			if (string.IsNullOrEmpty(AppPort)) {
				AppUser = CekEmpty("Port", false);
				AppConfig.SetValue(UDConfigName.Port, AppPort);
			}
			if (string.IsNullOrEmpty(AppUser)) {
				AppUser = CekEmpty("User", false);
				AppConfig.SetValue(UDConfigName.User, AES.Encrypt(AppName, AppUser));
			}
			if (string.IsNullOrEmpty(AppPass)) {
				AppPass = CekEmpty("Password", true);
				AppConfig.SetValue(UDConfigName.Pass, AES.Encrypt(AppName, AppPass));
			}
			Console.Clear();

			// cek mode
			if (AppMode == UDMode.Upload) UploadMode();
			else if (AppMode == UDMode.Download) DownloadMode();

			if (exitConfirmation) {
				Console.WriteLine("Finish ...");
				Console.ReadLine();
			}
			else if (!string.IsNullOrEmpty(AppCaller)) {
				using (StreamWriter srw = File.CreateText(AppBatchFile)) {
					srw.WriteLine(Path.GetPathRoot(AppCaller) + ":");
					srw.WriteLine("cd " + Path.GetDirectoryName(AppCaller));
					srw.WriteLine("start " + Path.GetFileName(AppCaller) + " noupdate");
					srw.WriteLine("del " + Path.Combine(AppLocationRoot, AppBatchFile));
					srw.Close();
				}
				Process.Start(AppBatchFile);
			}
		}

		private static string CekEmpty(string title, bool password) {
			Console.Clear();
			Console.Write(title + " : ");
			string result;
			if (password) result = GetPassword().ToString();
			else result = Console.ReadLine();
			if (string.IsNullOrEmpty(result)) return CekEmpty(title, password);
			else return result;
		}
		private static string GetPassword() {
			string pass = "";
			do {
				ConsoleKeyInfo key = Console.ReadKey(true);
				// Backspace Should Not Work
				if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter) {
					pass += key.KeyChar;
					Console.Write("*");
				}
				else {
					if (key.Key == ConsoleKey.Backspace && pass.Length > 0) {
						pass = pass.Substring(0, (pass.Length - 1));
						Console.Write("\b \b");
					}
					else if (key.Key == ConsoleKey.Enter) {
						break;
					}
				}
			} while (true);

			return pass;
			//string pwd = "";
			//while (true) {
			//	ConsoleKeyInfo i = Console.ReadKey(true);
			//	if (i.Key == ConsoleKey.Enter) {
			//		break;
			//	}
			//	else if (i.Key == ConsoleKey.Backspace) {
			//		if (pwd.Length > 0) {
			//			pwd.RemoveAt(pwd.Length - 1);
			//			Console.Write("\b \b");
			//		}
			//	}
			//	else if (i.KeyChar != '\u0000') // KeyChar == '\u0000' if the key pressed does not correspond to a printable character, e.g. F1, Pause-Break, etc
			//	{
			//		pwd.AppendChar(i.KeyChar);
			//		Console.Write("*");
			//	}
			//}
			//return pwd;
		}

		private static AppManifest ManageManifest(UDMode Mode) {
			var man = new AppManifest(Path.Combine(AppLocationRoot, AppManifestFileName), Mode, AppLocationMain, AppFileException, AppFolderExceptionDownload, AppFolderExceptionUpload);
			man.ManageManifest();
			return man;
		}

		private static void UploadMode() {
			if (AppTransferMethod == UDTransferMethod.FTP) {
				// cek koneksi ke server
				Console.WriteLine("Cek koneksi ...");
				var FTPMode = new FTPMode(AppServer, AppPort, AppUser, AppPass);
				try { Console.WriteLine(FTPMode.TestConnection()); }
				catch (Exception ex) { Console.WriteLine("ERROR => " + ex.Message); return; }

				Console.WriteLine("Download manifest from server ...");
				FTPMode.Download(AppLocationRoot, AppManifestFileName);
				Console.WriteLine("");

				Console.Write("Preparing file to upload ...");
				var xman = ManageManifest(UDMode.Upload);
				Console.WriteLine("");

				if (xman.DeletedFile != null && xman.DeletedFile.Count > 0) {
					FTPMode.Delete(xman.DeletedFile.Select(s => s.FileName).ToList());
					Console.WriteLine("");
				}

				if (xman.ProcessedFile != null && xman.ProcessedFile.Count > 0) {
					FTPMode.Upload(AppLocationMain, xman.ProcessedFile.Select(s => s.FileName).ToList());
					Console.WriteLine("");
				}

				Console.WriteLine("Upload manifest ...");
				FTPMode.Upload(AppLocationRoot, AppManifestFileName);
				File.Delete(AppManifestFileName);
			}
		}
		private static void DownloadMode() {
			if (AppTransferMethod == UDTransferMethod.FTP) {
				Console.WriteLine("Cek koneksi ...");
				// cek koneksi ke server
				var FTPMode = new FTPMode(AppServer, AppPort, AppUser, AppPass);
				try { Console.WriteLine(FTPMode.TestConnection()); }
				catch (Exception ex) { Console.WriteLine("ERROR => " + ex.Message); return; }

				// download manifest
				Console.WriteLine("Download manifest from server ...");
				FTPMode.Download(AppLocationRoot, AppManifestFileName);
				Console.WriteLine("");

				if (File.Exists(Path.Combine(AppLocationRoot, AppManifestFileName))) {
					// compare manifest
					Console.Write("Preparing file to download ...");
					var xman = ManageManifest(UDMode.Download);
					Console.WriteLine("");

					// download
					if (xman.ProcessedFile != null && xman.ProcessedFile.Count > 0) {
						FTPMode.Download(AppLocationMain, xman.ProcessedFile.Select(s => s.FileName).ToList());
						Console.WriteLine("");
					}

					// delete manifest
					File.Delete(AppManifestFileName);
				}
			}
		}
	}
}
