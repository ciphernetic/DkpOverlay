using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DkpOverlay
{
	public partial class frmOverlay : Form
	{
		const int TOP_MARGIN = 25;
		Web web;

		public frmOverlay(string sessionID)
		{
			InitializeComponent();
			
			this.TransparencyKey = this.BackColor;
			this.TopMost = true;
			IntPtr initialStyle = NativeMethods.GetWindowLongPtr(this.Handle, (int)GWL.GWL_EXSTYLE);
			NativeMethods.GetWindowLongPtr(this.Handle, initialStyle.ToInt32() | 0x80000 | 0x20);

			IntPtr eqHandle = NativeMethods.FindWindow(null, "EverQuest");
			RECT rect;
			NativeMethods.GetWindowRect(eqHandle, out rect);
			this.Size = new Size(rect.Left - rect.Right, rect.Bottom - rect.Top - TOP_MARGIN);
			this.Top = rect.Top + TOP_MARGIN;
			this.Left = rect.Left;
			this.FormBorderStyle = FormBorderStyle.None;

			web = new Web();
			web.SessionID = sessionID;
			UpdateLabels();
		}

		private void tmrUpdate_Tick(object sender, EventArgs e)
		{
			UpdateLabels();
		}

		private void UpdateLabels()
		{
			var doc = web.GetHtmlDoc();

			lblDKP.Text = web.GetDkp(doc);
			lblRA.Text = web.GetRA(doc);
		}
	}
}
