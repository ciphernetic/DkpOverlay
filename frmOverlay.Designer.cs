namespace DkpOverlay
{
	partial class frmOverlay
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
			if(disposing && (components != null))
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.lblDKP = new System.Windows.Forms.Label();
			this.lblRA = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current DKP:";
			// 
			// lblDKP
			// 
			this.lblDKP.AutoSize = true;
			this.lblDKP.BackColor = System.Drawing.Color.White;
			this.lblDKP.Location = new System.Drawing.Point(99, 9);
			this.lblDKP.Name = "lblDKP";
			this.lblDKP.Size = new System.Drawing.Size(35, 13);
			this.lblDKP.TabIndex = 1;
			this.lblDKP.Text = "label2";
			// 
			// lblRA
			// 
			this.lblRA.AutoSize = true;
			this.lblRA.BackColor = System.Drawing.Color.White;
			this.lblRA.Location = new System.Drawing.Point(99, 34);
			this.lblRA.Name = "lblRA";
			this.lblRA.Size = new System.Drawing.Size(35, 13);
			this.lblRA.TabIndex = 3;
			this.lblRA.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.White;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(73, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Current RA:";
			// 
			// tmrUpdate
			// 
			this.tmrUpdate.Enabled = true;
			this.tmrUpdate.Interval = 60000;
			this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
			// 
			// frmOverlay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lblRA);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblDKP);
			this.Controls.Add(this.label1);
			this.Name = "frmOverlay";
			this.Text = "frmOverlay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblDKP;
		private System.Windows.Forms.Label lblRA;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Timer tmrUpdate;
	}
}