using FluentFTP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Nusoft.Update
{
	public class FTPMode
	{
		public FTPMode() { }
		public FTPMode(string server, string port, string user, string password)
		{
			Server = server;
			Port = port;
			User = user;
			Password = password;
		}

		public string Server { get; set; }
		public string Port { get; set; }
		public string User { get; set; }
		public string Password { get; set; }

		public string TestConnection()
		{
			try
			{
				using (var client = FTPConnect())
				{
					return "Welcome " + client.ServerType.ToString();
				}
			}
			catch (NullReferenceException ex)
			{
				throw new Exception(ex.Message);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
		public void Delete(string FileName) => Delete(new List<string>() { FileName });
		public void Delete(List<string> FileNames)
		{
			using (var client = FTPConnect())
			{
				foreach (var file in FileNames)
				{
					if (client.FileExists(file))
					{
						Console.Write("Delete " + file + " ==> ");
						client.DeleteFile(file);
						Console.WriteLine("OK");
					}
				}
			}
		}

		public void Download(string AppMainPath, string FileName) => Download(AppMainPath, new List<string>() { FileName });
		public void Download(string AppMainPath, List<string> FileNames)
		{
			using (var client = FTPConnect())
			{
				foreach (var file in FileNames)
				{
					var LocalFileName = Path.Combine(AppMainPath, file);
					if (client.FileExists(file))
					{
						Console.Write("Download " + LocalFileName + " ==> ");

						using (var prog = new ProgressBarCmd())
						{
							Action<FtpProgress> progress = delegate (FtpProgress p) {
								prog.Report(p.Progress / 100);
							};
							client.DownloadFile(LocalFileName, file, FtpLocalExists.Overwrite, FtpVerify.None, progress);
						}
						Console.WriteLine("100%");
					}
				}
			}
		}

		public void Upload(string AppMainPath, string FileName) => Upload(AppMainPath, new List<string>() { FileName });
		public void Upload(string AppMainPath, List<string> FileNames)
		{
			using (var client = FTPConnect())
			{
				foreach (var file in FileNames)
				{
					var LocalFileName = Path.Combine(AppMainPath, file);
					if (File.Exists(LocalFileName))
					{
						Console.Write("Upload " + LocalFileName + " ==> ");

						using (var prog = new ProgressBarCmd())
						{
							Action<FtpProgress> progress = delegate (FtpProgress p) {
								prog.Report(p.Progress / 100);
							};
							client.UploadFile(LocalFileName, file, FtpRemoteExists.Overwrite, true, FtpVerify.None, progress);
						}
						Console.WriteLine("100%");
					}
				}
			}
		}

		private FtpClient FTPConnect()
		{
			CheckParameters();
			var client = new FtpClient(Server, int.Parse(Port), User, Password);
			//throw new Exception(Server + "/" + Port + "/" + User + "/" + Password);
			client.Connect();
			return client;
		}
		private void CheckParameters()
		{
			if (string.IsNullOrEmpty(Server)) throw new NullReferenceException("Masukkan alamat server FTP");
			if (string.IsNullOrEmpty(Port)) throw new NullReferenceException("Masukkan port FTP");
			if (!Port.All(char.IsDigit)) throw new NullReferenceException("Port FTP harus dalam bentuk numeric");
			if (string.IsNullOrEmpty(User)) throw new NullReferenceException("Masukkan user FTP");
			if (string.IsNullOrEmpty(Password)) throw new NullReferenceException("Masukkan password FTP");
		}
	}
}