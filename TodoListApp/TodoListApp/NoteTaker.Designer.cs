
namespace TodoListApp
{
	partial class NoteTaker
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteTaker));
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.previousNotes = new System.Windows.Forms.DataGridView();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnNewNote = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.previousNotes)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTitle
			// 
			this.txtTitle.BackColor = System.Drawing.Color.GhostWhite;
			this.txtTitle.Location = new System.Drawing.Point(392, 90);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(584, 26);
			this.txtTitle.TabIndex = 0;
			// 
			// txtNote
			// 
			this.txtNote.BackColor = System.Drawing.Color.GhostWhite;
			this.txtNote.Location = new System.Drawing.Point(392, 180);
			this.txtNote.Multiline = true;
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(594, 467);
			this.txtNote.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(393, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(388, 153);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 26);
			this.label2.TabIndex = 3;
			this.label2.Text = "Note";
			// 
			// previousNotes
			// 
			this.previousNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.previousNotes.BackgroundColor = System.Drawing.Color.GhostWhite;
			this.previousNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.previousNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.previousNotes.Location = new System.Drawing.Point(12, 127);
			this.previousNotes.Name = "previousNotes";
			this.previousNotes.RowHeadersWidth = 62;
			this.previousNotes.RowTemplate.Height = 28;
			this.previousNotes.Size = new System.Drawing.Size(358, 411);
			this.previousNotes.TabIndex = 4;
			this.previousNotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.previousNotes_CellContentClick);
			// 
			// btnLoad
			// 
			this.btnLoad.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLoad.Location = new System.Drawing.Point(19, 555);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(82, 78);
			this.btnLoad.TabIndex = 5;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnNewNote
			// 
			this.btnNewNote.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNewNote.ForeColor = System.Drawing.Color.MidnightBlue;
			this.btnNewNote.Location = new System.Drawing.Point(19, 639);
			this.btnNewNote.Name = "btnNewNote";
			this.btnNewNote.Size = new System.Drawing.Size(150, 41);
			this.btnNewNote.TabIndex = 8;
			this.btnNewNote.Text = "+ New Note";
			this.btnNewNote.UseVisualStyleBackColor = true;
			this.btnNewNote.Click += new System.EventHandler(this.btnNewNote_Click);
			// 
			// btnSave
			// 
			this.btnSave.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__4_;
			this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSave.Location = new System.Drawing.Point(211, 628);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(82, 57);
			this.btnSave.TabIndex = 7;
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__3_;
			this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnDelete.Location = new System.Drawing.Point(211, 544);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(82, 57);
			this.btnDelete.TabIndex = 6;
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold);
			this.linkLabel1.Location = new System.Drawing.Point(902, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(84, 26);
			this.linkLabel1.TabIndex = 13;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log Out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(7, 9);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(50, 23);
			this.linkLabel2.TabIndex = 14;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Back";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// NoteTaker
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Snow;
			this.ClientSize = new System.Drawing.Size(1007, 697);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.btnNewNote);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.previousNotes);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNote);
			this.Controls.Add(this.txtTitle);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "NoteTaker";
			this.Text = "NoteTaker";
			this.Load += new System.EventHandler(this.NoteTaker_Load);
			((System.ComponentModel.ISupportInitialize)(this.previousNotes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView previousNotes;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnNewNote;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}