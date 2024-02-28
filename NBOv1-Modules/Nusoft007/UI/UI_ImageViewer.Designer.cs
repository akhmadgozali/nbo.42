namespace NuSoft.NUI.Win.Forms.Modules.NuSoft007.UI
{
	partial class UI_ImageViewer
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI_ImageViewer));
			this.box1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.box1)).BeginInit();
			this.SuspendLayout();
			// 
			// box1
			// 
			this.box1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.box1.Location = new System.Drawing.Point(0, 0);
			this.box1.Name = "box1";
			this.box1.Size = new System.Drawing.Size(832, 475);
			this.box1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.box1.TabIndex = 0;
			this.box1.TabStop = false;
			// 
			// UI_ImageViewer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(832, 475);
			this.Controls.Add(this.box1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UI_ImageViewer";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "UI_ImageViewer";
			((System.ComponentModel.ISupportInitialize)(this.box1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox box1;
	}
}