
namespace TodoListApp
{
	partial class Dashboard
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
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.ToDolinkLabel = new System.Windows.Forms.LinkLabel();
			this.NotelinkLabel = new System.Windows.Forms.LinkLabel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Modern No. 20", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(209, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome to your Productivity App";
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(356, 458);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(168, 41);
			this.button1.TabIndex = 1;
			this.button1.Text = "LogOut";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ToDolinkLabel
			// 
			this.ToDolinkLabel.AutoSize = true;
			this.ToDolinkLabel.BackColor = System.Drawing.Color.Transparent;
			this.ToDolinkLabel.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ToDolinkLabel.Location = new System.Drawing.Point(32, 117);
			this.ToDolinkLabel.Name = "ToDolinkLabel";
			this.ToDolinkLabel.Size = new System.Drawing.Size(160, 22);
			this.ToDolinkLabel.TabIndex = 2;
			this.ToDolinkLabel.TabStop = true;
			this.ToDolinkLabel.Text = "Your To Do List";
			this.ToDolinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ToDolinkLabel_LinkClicked);
			// 
			// NotelinkLabel
			// 
			this.NotelinkLabel.AutoSize = true;
			this.NotelinkLabel.BackColor = System.Drawing.Color.Transparent;
			this.NotelinkLabel.Font = new System.Drawing.Font("Modern No. 20", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NotelinkLabel.Location = new System.Drawing.Point(587, 117);
			this.NotelinkLabel.Name = "NotelinkLabel";
			this.NotelinkLabel.Size = new System.Drawing.Size(111, 22);
			this.NotelinkLabel.TabIndex = 3;
			this.NotelinkLabel.TabStop = true;
			this.NotelinkLabel.Text = "Your Notes";
			this.NotelinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NotelinkLabel_LinkClicked);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = global::TodoListApp.Properties.Resources.Untitled_design__20_;
			this.pictureBox1.Location = new System.Drawing.Point(-6, 150);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(291, 269);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.Image = global::TodoListApp.Properties.Resources.Untitled_design__21_;
			this.pictureBox2.Location = new System.Drawing.Point(483, 150);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(291, 269);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__14_;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(844, 499);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.NotelinkLabel);
			this.Controls.Add(this.ToDolinkLabel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.LinkLabel ToDolinkLabel;
		private System.Windows.Forms.LinkLabel NotelinkLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}