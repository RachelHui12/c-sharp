using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace WinExplorer
{
	/// <summary>
	/// Summary description for AboutDlg.
	/// </summary>
	public class AboutDlg : System.Windows.Forms.Form
	{
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button m_bnClose;
		private System.Windows.Forms.PictureBox m_pbLogo;
		private System.Windows.Forms.LinkLabel m_linkLabelName;
		private System.Windows.Forms.LinkLabel m_linkLabelCompany;
		private System.Windows.Forms.ToolTip m_toolTip;
		private System.ComponentModel.IContainer components;

		public AboutDlg()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutDlg));
			this.m_linkLabelName = new System.Windows.Forms.LinkLabel();
			this.m_linkLabelCompany = new System.Windows.Forms.LinkLabel();
			this.m_pbLogo = new System.Windows.Forms.PictureBox();
			this.m_bnClose = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.m_toolTip = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// m_linkLabelName
			// 
			this.m_linkLabelName.Location = new System.Drawing.Point(64, 192);
			this.m_linkLabelName.Name = "m_linkLabelName";
			this.m_linkLabelName.Size = new System.Drawing.Size(104, 18);
			this.m_linkLabelName.TabIndex = 2;
			this.m_linkLabelName.TabStop = true;
			this.m_linkLabelName.Text = "K.Niranjan Kumar.";
			this.m_toolTip.SetToolTip(this.m_linkLabelName, "KNiranja@chn.cognizant.com");
			this.m_linkLabelName.Click += new System.EventHandler(this.OnClickLinkLabelName);
			// 
			// m_linkLabelCompany
			// 
			this.m_linkLabelCompany.Location = new System.Drawing.Point(176, 192);
			this.m_linkLabelCompany.Name = "m_linkLabelCompany";
			this.m_linkLabelCompany.Size = new System.Drawing.Size(168, 16);
			this.m_linkLabelCompany.TabIndex = 3;
			this.m_linkLabelCompany.TabStop = true;
			this.m_linkLabelCompany.Text = "Cognizant Technology Solutions";
			this.m_toolTip.SetToolTip(this.m_linkLabelCompany, "www.cognizant.com");
			this.m_linkLabelCompany.Click += new System.EventHandler(this.OnClickLinkLabelCompany);
			// 
			// m_pbLogo
			// 
			this.m_pbLogo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.m_pbLogo.Image = ((System.Drawing.Bitmap)(resources.GetObject("m_pbLogo.Image")));
			this.m_pbLogo.Location = new System.Drawing.Point(1, 1);
			this.m_pbLogo.Name = "m_pbLogo";
			this.m_pbLogo.Size = new System.Drawing.Size(459, 126);
			this.m_pbLogo.TabIndex = 0;
			this.m_pbLogo.TabStop = false;
			this.m_toolTip.SetToolTip(this.m_pbLogo, "Go to MSDN .NET\'s home page");
			this.m_pbLogo.Click += new System.EventHandler(this.OnClickLogo);
			// 
			// m_bnClose
			// 
			this.m_bnClose.Location = new System.Drawing.Point(362, 170);
			this.m_bnClose.Name = "m_bnClose";
			this.m_bnClose.TabIndex = 4;
			this.m_bnClose.Text = "C&lose";
			this.m_bnClose.Click += new System.EventHandler(this.OnClickClose);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(72, 137);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(272, 37);
			this.label1.TabIndex = 1;
			this.label1.Text = "Windows Explorer in C# is designed and developed by K. Niranjan Kumar    . Cogniz" +
				"ant Technology Solutions";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutDlg
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(443, 248);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.m_bnClose,
																		  this.m_linkLabelCompany,
																		  this.m_linkLabelName,
																		  this.label1,
																		  this.m_pbLogo});
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDlg";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About Windows Explorer in C#";
			this.ResumeLayout(false);

		}
		#endregion

		private void OnClickClose(object sender, System.EventArgs e) {
			this.Close();
		}

		private void OnClickLogo(object sender, System.EventArgs e) {
			System.Diagnostics.Process.Start("http://msdn.microsoft.com/net");
		}

		private void OnClickLinkLabelName(object sender, System.EventArgs e) {
			m_linkLabelName.LinkVisited = true;
			System.Diagnostics.Process.Start("mailto:KNiranja@chn.cognizant.com?subject=Feedback of WindowsExplorer in C#");
		}

		private void OnClickLinkLabelCompany(object sender, System.EventArgs e) {
			m_linkLabelCompany.LinkVisited = true;
			System.Diagnostics.Process.Start("http://www.cognizant.com");
		}
	}
}
