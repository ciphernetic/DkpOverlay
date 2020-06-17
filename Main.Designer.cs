namespace DkpOverlay
{
	partial class Main
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
			this.btnStart = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.lblRA = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(151, 58);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(83, 33);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.button1_Click);
			// 
			// Label1
			// 
			this.Label1.AutoSize = true;
			this.Label1.Location = new System.Drawing.Point(12, 9);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(61, 13);
			this.Label1.TabIndex = 1;
			this.Label1.Text = "User name:";
			// 
			// lblRA
			// 
			this.lblRA.AutoSize = true;
			this.lblRA.Location = new System.Drawing.Point(17, 35);
			this.lblRA.Name = "lblRA";
			this.lblRA.Size = new System.Drawing.Size(56, 13);
			this.lblRA.TabIndex = 2;
			this.lblRA.Text = "Password:";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(69, 6);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(165, 20);
			this.txtUserName.TabIndex = 3;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(69, 32);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(165, 20);
			this.txtPassword.TabIndex = 4;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(275, 101);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.lblRA);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.btnStart);
			this.Name = "Main";
			this.Text = "DKP Overlay";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Label lblRA;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
	}
}

