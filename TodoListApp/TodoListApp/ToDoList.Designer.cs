
namespace TodoListApp
{
	partial class ToDoList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToDoList));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.txtDescription = new System.Windows.Forms.TextBox();
			this.NewBtn = new System.Windows.Forms.Button();
			this.toDoListView = new System.Windows.Forms.DataGridView();
			this.CheckBoxCompleted = new System.Windows.Forms.CheckBox();
			this.DeleteBtn = new System.Windows.Forms.Button();
			this.EditBtn = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.toDoListView)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(364, 55);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(320, 147);
			this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(126, 26);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description ";
			// 
			// txtTitle
			// 
			this.txtTitle.Location = new System.Drawing.Point(103, 84);
			this.txtTitle.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(513, 31);
			this.txtTitle.TabIndex = 2;
			// 
			// txtDescription
			// 
			this.txtDescription.Location = new System.Drawing.Point(103, 177);
			this.txtDescription.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.txtDescription.Name = "txtDescription";
			this.txtDescription.Size = new System.Drawing.Size(513, 31);
			this.txtDescription.TabIndex = 3;
			// 
			// NewBtn
			// 
			this.NewBtn.BackColor = System.Drawing.SystemColors.HighlightText;
			this.NewBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
			this.NewBtn.FlatAppearance.BorderSize = 3;
			this.NewBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.NewBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NewBtn.ForeColor = System.Drawing.Color.MidnightBlue;
			this.NewBtn.Location = new System.Drawing.Point(440, 316);
			this.NewBtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.NewBtn.Name = "NewBtn";
			this.NewBtn.Size = new System.Drawing.Size(212, 36);
			this.NewBtn.TabIndex = 4;
			this.NewBtn.Text = "+ Add Task";
			this.NewBtn.UseVisualStyleBackColor = false;
			this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
			// 
			// toDoListView
			// 
			this.toDoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.toDoListView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
			this.toDoListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.toDoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.toDoListView.GridColor = System.Drawing.SystemColors.Control;
			this.toDoListView.Location = new System.Drawing.Point(17, 358);
			this.toDoListView.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.toDoListView.Name = "toDoListView";
			this.toDoListView.RowHeadersWidth = 62;
			this.toDoListView.RowTemplate.Height = 28;
			this.toDoListView.Size = new System.Drawing.Size(764, 251);
			this.toDoListView.TabIndex = 8;
			this.toDoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.toDoListView_CellContentClick);
			// 
			// CheckBoxCompleted
			// 
			this.CheckBoxCompleted.AutoSize = true;
			this.CheckBoxCompleted.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CheckBoxCompleted.Location = new System.Drawing.Point(626, 179);
			this.CheckBoxCompleted.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.CheckBoxCompleted.Name = "CheckBoxCompleted";
			this.CheckBoxCompleted.Size = new System.Drawing.Size(140, 30);
			this.CheckBoxCompleted.TabIndex = 10;
			this.CheckBoxCompleted.Text = "Completed";
			this.CheckBoxCompleted.UseVisualStyleBackColor = true;
			// 
			// DeleteBtn
			// 
			this.DeleteBtn.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__3_;
			this.DeleteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.DeleteBtn.Location = new System.Drawing.Point(369, 305);
			this.DeleteBtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.DeleteBtn.Name = "DeleteBtn";
			this.DeleteBtn.Size = new System.Drawing.Size(56, 47);
			this.DeleteBtn.TabIndex = 6;
			this.DeleteBtn.UseVisualStyleBackColor = true;
			this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
			// 
			// EditBtn
			// 
			this.EditBtn.BackgroundImage = global::TodoListApp.Properties.Resources.Untitled_design__7_;
			this.EditBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.EditBtn.Location = new System.Drawing.Point(292, 305);
			this.EditBtn.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.EditBtn.Name = "EditBtn";
			this.EditBtn.Size = new System.Drawing.Size(56, 47);
			this.EditBtn.TabIndex = 5;
			this.EditBtn.UseVisualStyleBackColor = true;
			this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(717, 9);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(84, 26);
			this.linkLabel1.TabIndex = 12;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Log Out";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// linkLabel2
			// 
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linkLabel2.Location = new System.Drawing.Point(9, 9);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(50, 23);
			this.linkLabel2.TabIndex = 15;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Back";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			// 
			// ToDoList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.GhostWhite;
			this.ClientSize = new System.Drawing.Size(813, 615);
			this.Controls.Add(this.linkLabel2);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.CheckBoxCompleted);
			this.Controls.Add(this.toDoListView);
			this.Controls.Add(this.DeleteBtn);
			this.Controls.Add(this.EditBtn);
			this.Controls.Add(this.NewBtn);
			this.Controls.Add(this.txtDescription);
			this.Controls.Add(this.txtTitle);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ToDoList";
			this.Text = "ToDo ";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.toDoListView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.TextBox txtDescription;
		private System.Windows.Forms.Button NewBtn;
		private System.Windows.Forms.Button EditBtn;
		private System.Windows.Forms.Button DeleteBtn;
		private System.Windows.Forms.DataGridView toDoListView;
		private System.Windows.Forms.CheckBox CheckBoxCompleted;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
	}
}

