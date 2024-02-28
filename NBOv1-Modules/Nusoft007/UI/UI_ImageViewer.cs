using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI {
	public partial class UI_ImageViewer : Form {
		public UI_ImageViewer() {
			InitializeComponent();
		}

		public void LoadFromStream(byte[] byteArray) {
			MemoryStream stream = new MemoryStream(byteArray);
			box1.Image = Image.FromStream(stream);
		}
	}
}
