using System.IO;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI {
	public partial class UI_PDFViewer : Form {
		public UI_PDFViewer() {
			InitializeComponent();
		}

		public void LoadFromStream(byte[] byteArray) {
			MemoryStream stream = new MemoryStream(byteArray);
			pdfViewer1.LoadDocument(stream);
		}
	}
}
