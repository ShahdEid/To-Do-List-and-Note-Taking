
namespace TodoListApp
{
	partial class LogIn
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.ClearBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label1.Location = new System.Drawing.Point(165, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(156, 36);
			this.label1.TabIndex = 0;
			this.label1.Text = "User Name";
			this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label2.Location = new System.Drawing.Point(165, 229);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 36);
			this.label2.TabIndex = 1;
			this.label2.Text = "Password";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// txtUserName
			// 
			this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtUserName.Location = new System.Drawing.Point(83, 104);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(335, 26);
			this.txtUserName.TabIndex = 2;
			// 
			// txtPassword
			// 
			this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPassword.Location = new System.Drawing.Point(83, 272);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '•';
			this.txtPassword.Size = new System.Drawing.Size(335, 26);
			this.txtPassword.TabIndex = 3;
			// 
			// LoginBtn
			// 
			this.LoginBtn.AutoSize = true;
			this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.LoginBtn.Location = new System.Drawing.Point(265, 370);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(117, 45);
			this.LoginBtn.TabIndex = 4;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = true;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			this.LoginBtn.Resize += new System.EventHandler(this.LoginBtn_Resize);
			// 
			// ClearBtn
			// 
			this.ClearBtn.AutoSize = true;
			this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ClearBtn.Location = new System.Drawing.Point(65, 376);
			this.ClearBtn.Name = "ClearBtn";
			this.ClearBtn.Size = new System.Drawing.Size(116, 39);
			this.ClearBtn.TabIndex = 5;
			this.ClearBtn.Text = "Clear";
			this.ClearBtn.UseVisualStyleBackColor = true;
			this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
			// 
			// LogIn
			// 
			this.AcceptButton = this.LoginBtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__11_;
			this.ClientSize = new System.Drawing.Size(490, 567);
			this.Controls.Add(this.ClearBtn);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LogIn";
			this.Text = "LogIn";
			this.Load += new System.EventHandler(this.LogIn_Load);
			this.Resize += new System.EventHandler(this.LogIn_Resize);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Button LoginBtn;
		private System.Windows.Forms.Button ClearBtn;
	}
}