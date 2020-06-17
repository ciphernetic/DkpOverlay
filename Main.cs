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
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Web w = new Web();

			var id = w.GetSessionId(txtUserName.Text, txtPassword.Text);


			var frm = new frmOverlay(id);

			frm.Show();
		}
	}
}
