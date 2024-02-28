using System.Collections.Generic;
using System.Configuration;

namespace Nusoft.Update.Config {
	internal enum UDMode {
		Download,
		Upload
	}
	internal enum UDTransferMethod {
		FTP
	}
	internal enum UDConfigName {
		Mode,
		TransferMethod,
		Server,
		Port,
		User,
		Pass,
		Path,
		FileException,
		FolderExceptionDownload,
		FolderExceptionUpload
	}

	internal static class AppConfig {
		const string sectionName = "UDSettings";
		const UDMode defaultMode = UDMode.Download;
		const UDTransferMethod defaultTransferMethod = UDTransferMethod.FTP;
		const string defaultServer = "localhost";
		const string defaultPort = "21";
		const string defaultUser = "";
		const string defaultPass = "";
		const string defaultPath = "";
		const string defaultFileException = "";
		const string defaultFolderExceptionDownload = "";
		const string defaultFolderExceptionUpload = "";

		internal static void ReadAllConfig() {
			GetValue(UDConfigName.Mode);
			GetValue(UDConfigName.TransferMethod);
			GetValue(UDConfigName.Server);
			GetValue(UDConfigName.Port);
			GetValue(UDConfigName.User);
			GetValue(UDConfigName.Pass);
			GetValue(UDConfigName.Path);
			GetValue(UDConfigName.FileException);
			GetValue(UDConfigName.FolderExceptionDownload);
			GetValue(UDConfigName.FolderExceptionUpload);
		}

		internal static string GetValue(UDConfigName name) {
			var value = ConfigurationManager.AppSettings[name.ToString()];
			if (value != null && value != "") { return value; }
			else {
				switch (name) {
					case UDConfigName.Mode: SetValue(name, defaultMode.ToString()); return defaultMode.ToString();
					case UDConfigName.TransferMethod: SetValue(name, defaultTransferMethod.ToString()); return defaultTransferMethod.ToString();
					case UDConfigName.Server: SetValue(name, defaultServer); return defaultServer;
					case UDConfigName.Port: SetValue(name, defaultPort); return defaultPort;
					case UDConfigName.User: SetValue(name, defaultUser); return defaultUser;
					case UDConfigName.Pass: SetValue(name, defaultPass); return defaultPass;
					case UDConfigName.Path: SetValue(name, defaultPath); return defaultPath;
					case UDConfigName.FileException: SetValue(name, defaultFileException); return defaultFileException;
					case UDConfigName.FolderExceptionDownload: SetValue(name, defaultFolderExceptionDownload); return defaultFolderExceptionDownload;
					case UDConfigName.FolderExceptionUpload: SetValue(name, defaultFolderExceptionUpload); return defaultFolderExceptionUpload;
					default: return "";
				}
			}
		}

		private static Configuration GetExeConfig() {
			return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
		}

		private static void SaveSingle(Configuration config, UDConfigName key, string value) {
			try { config.AppSettings.Settings[key.ToString()].Value = value; }
			catch { config.AppSettings.Settings.Add(key.ToString(), value); }
		}
		private static void SaveFile(Configuration config) {
			config.Save(ConfigurationSaveMode.Minimal);
			ConfigurationManager.RefreshSection(sectionName);
		}

		internal static void SetValue(UDConfigName name, string value) {
			var list = new List<KeyValuePair<UDConfigName, string>>();
			list.Add(new KeyValuePair<UDConfigName, string>(name, value));
			SaveConfig(list);
		}
		internal static void SaveConfig(List<KeyValuePair<UDConfigName, string>> data) {
			var config = GetExeConfig();
			foreach (var x in data) {
				SaveSingle(config, x.Key, x.Value);
			}
			SaveFile(config);
		}
	}
}
