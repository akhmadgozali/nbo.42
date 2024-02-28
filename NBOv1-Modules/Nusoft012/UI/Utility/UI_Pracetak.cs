using DevExpress.Xpo;
using DevExpress.XtraEditors.Controls;
using NuSoft.Core.Win.Forms;
using NuSoft.NPO.Modules.ModSys;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Persistent;
using NuSoft.NUI.Win.Forms.Modules.NuSoft012.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft012.UI.Utility {
	public partial class UI_Pracetak : DialogForm {
		public UI_Pracetak() {
			InitializeComponent();
			btn1.Text = "Proses";
			txtNamaFile.ButtonClick += new ButtonPressedEventHandler(NamaFileButtonClick);
			txtTanggalTerbit.DateTimeChanged += new EventHandler(TglChanged);
			AutoCloseOnSave = true;
		}

		private string DefaultPath;
		public override void InitializeUsedComponent() {
			GetSession();
			txtRegional.Properties.DataSource = new XPQuery<Regional>(session);
		}
		public override void InitializeData() {
			txtRegional.CheckAll();
			txtModel.EditValue = true;
			DefaultPath = Properties.Settings.Default.JTPath;
			if (string.IsNullOrEmpty(DefaultPath)) DefaultPath = System.IO.Path.GetPathRoot(System.IO.Directory.GetCurrentDirectory());
			txtTanggalTerbit.DateTime = DateTime.Now.AddDays(1);
			SetFileName();
		}
		public override void Btn1Click() {
			var setting = new IklanSetting(session);

			List<Regional> regionals = new List<Regional>();
			foreach (var x in txtRegional.Properties.GetItems().GetCheckedValues())
				regionals.Add((Regional)x);

			var jt = new XPQuery<InvoiceTerbit>(session).Where(w => w.Aktif && w.TanggalTerbit == txtTanggalTerbit.DateTime.Date
			 && w.Invoice.TipeInvoice.TipeIklan == ETipeIklan.Deret
			 && regionals.Contains(w.Invoice.Wilayah.Regional)).ToList();

			List<JTGabungan> datax = new List<JTGabungan>();
			foreach (var y in jt) {
				datax.Add(new JTGabungan() {
					Sales = y.Invoice.Sales,
					Id = y.Id,
					MateriBaris = y.Invoice.MateriDeretBaris,
					MateriLinear = y.Invoice.MateriDeretLinear,	
					Merk = y.Invoice.Merk,
					NoInvoice = y.Invoice.NoInvoice,
					PrefixBaru = IsPublishNew(y) ? "B" : "L",
					//PrefixFoto = y.InvoiceDetail.PakaiFoto ? "F" : "T",
					Tanggal = y.TanggalTerbit,
					TanggalAkhir = GetLastPublish(y),
					Zona = y.Invoice.Wilayah,
					Warna = !y.Invoice.WarnaBW
				});
			}

			datax = datax.OrderBy(o => o.Merk.Nama)
							.OrderBy(o => o.Merk.Produk.Nama)
							.OrderBy(o => o.Zona.Nama)
							.OrderBy(o => o.PrefixBaru).ToList();

			if (!txtFileFCBWTerpisah.Checked) {
				System.IO.File.WriteAllLines(txtNamaFile.Text, ProsesJT(setting, datax).AsEnumerable());
				if (txtBukaFile.Checked) Utils.Win.File.OpenFile(txtNamaFile.Text, "", false);
			}
			else {
				var baseFile = txtNamaFile.Text.Substring(0, txtNamaFile.Text.Length - 4); //txtNamaFile.Text.Replace(".txt", "");
				var fileFC = baseFile + "-FC.txt";
				var fileBW = baseFile + "-BW.txt";

				System.IO.File.WriteAllLines(fileFC, ProsesJT(setting, datax.Where(w => w.Warna).ToList()).AsEnumerable());
				System.IO.File.WriteAllLines(fileBW, ProsesJT(setting, datax.Where(w => !w.Warna).ToList()).AsEnumerable());
				if (txtBukaFile.Checked) {
					Utils.Win.File.OpenFile(fileFC, "", false);
					Utils.Win.File.OpenFile(fileBW, "", false);
				}
			}

			Properties.Settings.Default.JTPath = DefaultPath;
			Properties.Settings.Default.Save();
		}
		public override void ErrorBtn1Click(Utils.Exception ex) {
			ex.ShowWinMessageBox();
		}

		private List<string> ProsesJT(IklanSetting setting, List<JTGabungan> data) {
			List<string> result = new List<string>();
			string lastZone = ""; string lastProduk = ""; string lastMerk = "";

			foreach (var item in data) {
				if (lastZone != item.Zona.Nama) {
					lastZone = item.Zona.Nama;
					result.Add(Utils.Common.Character.CenterText(setting.MaxKarakterDeret, lastZone));
				}
				if (lastProduk != item.Merk.Produk.Nama) {
					lastProduk = item.Merk.Produk.Nama;
					result.Add(Utils.Common.Character.CenterText(setting.MaxKarakterDeret, lastProduk));
				}
				if (lastMerk != item.Merk.Nama) {
					lastMerk = item.Merk.Nama;
					result.Add(Utils.Common.Character.CenterText(setting.MaxKarakterDeret, lastMerk));
				}
				if ((bool)txtModel.EditValue) result.Add(item.MateriLinear);
				else result.Add(item.MateriBaris);
				if (txtTampilkanNoInvoice.Checked) result.Add(item.NoJT);
				result.Add("");
			}

			return result;
		}

		private void NamaFileButtonClick(object sender, ButtonPressedEventArgs e) {
			var dialog = new FolderBrowserDialog();
			//dialog.DialogStyle = DevExpress.Utils.CommonDialogs.FolderBrowserDialogStyle.Wide;
			//dialog.SelectedPath = System.IO.Path.GetDirectoryName(txtNamaFile.Text);
			//dialog.Filter = "TXT Files|*.txt";
			//dialog.Title = "Set lokasi file PraCetak";
			//dialog.InitialDirectory = txtNamaFile.Text;
			dialog.SelectedPath = System.IO.Path.GetDirectoryName(txtNamaFile.Text);
			if (dialog.ShowDialog() == DialogResult.OK) {
				DefaultPath = dialog.SelectedPath;
				SetFileName();
			}
		}
		private void TglChanged(object sender, EventArgs e) { SetFileName(); }
		private string GetDefaultFileName() {
			return "JT" + txtTanggalTerbit.DateTime.ToString("ddMMyy") + ".txt";
		}
		private void SetFileName() {
			txtNamaFile.EditValue = System.IO.Path.Combine(DefaultPath, GetDefaultFileName());
		}

		private bool IsPublishNew(InvoiceTerbit terbit) {
			var collection = new XPQuery<InvoiceTerbit>(session).Where(w => w.Invoice == terbit.Invoice && w.TanggalTerbit.Date == terbit.TanggalTerbit.Date.AddDays(-1) && w.Aktif).ToList();
			return (collection.Count <= 0);
		}
		private DateTime GetLastPublish(InvoiceTerbit terbit) {
			var collection = new XPQuery<InvoiceTerbit>(session).Where(w => w.Invoice == terbit.Invoice && w.TanggalTerbit.Date >= terbit.TanggalTerbit.Date && w.Aktif).OrderBy(o => o.TanggalTerbit).ToList();
			DateTime result = new DateTime();
			int i = 1;
			foreach (var item in collection) {
				if (i != 1) {
					if (result.AddDays(1) == item.TanggalTerbit.Date) { result = item.TanggalTerbit; }
					else { return result; }
				}
				else {
					result = item.TanggalTerbit;
					i += 1;
				}
			}

			return result;
		}
	}

	internal struct JTGabungan {
		internal Sales Sales;
		internal long Id;
		internal string MateriBaris;
		internal string MateriLinear;
		internal Merk Merk;
		internal string NoInvoice;
		internal string PrefixBaru;
		//internal string PrefixFoto;
		internal DateTime Tanggal;
		internal DateTime TanggalAkhir;
		internal Wilayah Zona;
		internal bool Warna;

		internal string NoJT {
			//get => string.Format("{0}*{1}*{2}-{3}-{4}", PrefixFoto, PrefixBaru, NoInvoice, TanggalAkhir.ToString("dd/MM"), Sales.Kode);
			get => string.Format("{0}*{1}-{2}-{3}", PrefixBaru, NoInvoice, TanggalAkhir.ToString("dd/MM"), Sales.Kode);
		}
	}
}