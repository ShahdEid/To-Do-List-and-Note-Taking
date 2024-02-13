using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoListApp
{
	public partial class Dashboard : Form
	{
		public Dashboard()
		{
			InitializeComponent();
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			//an instance of the form
			ToDoList toDoList = new ToDoList();
			//show todolist
			toDoList.Show();
			this.Hide(); 
			// this.Close(); 
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			//an instance of the form
			NoteTaker note = new NoteTaker();
			//show todolist
			note.Show();
			this.Hide();
			// this.Close(); 
		}

		private void ToDolinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			ToDoList toDoList = new ToDoList();
			this.Hide();
			toDoList.Show();
		}

		private void NotelinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			NoteTaker note = new NoteTaker();
			this.Hide();
			note.Show();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LogIn login = new LogIn();
			this.Hide();
			login.Show();
		}
	}
}
