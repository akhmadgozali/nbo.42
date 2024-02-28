using NuSoft.Core.Win.Forms;
using NuSoft.NUI.Win.Forms.Modules.NuSoft011.Persistent;
using System;
using System.Collections.Generic;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft011.UI.Transaksi {
	public partial class UI_PelangganHistoryDialog : DialogForm {
		public UI_PelangganHistoryDialog() {
			InitializeComponent();
			btn1.Visible = false;
		}

		internal void SetData(Pelanggan obj) {
			txtNomor.Text = obj.Kode;
			txtStatus.Text = obj.Aktif ? "Aktif" : "Non Aktif";
			txtNama.Text = obj.Nama;
			txtAlamat.Text = obj.Alamat + " " + obj.Kelurahan?.Kode + " " + obj.Kecamatan?.Kode + " " + obj.Kabupaten?.Kode + " " + obj.Propinsi?.Kode;

			var ds = new List<HistorySource>();
			foreach (var hs in obj.History) ds.Add(new HistorySource() { JumlahExp = hs.JumlahExp, Aktif = hs.Aktif, Keterangan = hs.Keterangan, Tanggal = hs.Tanggal });

			xGrid.DataSource = ds;
		}

		public class HistorySource {
			public DateTime Tanggal { get; set; }
			public bool Aktif { get; set; }
			public int JumlahExp { get; set; }
			public string Keterangan { get; set; }
		}
	}
}
