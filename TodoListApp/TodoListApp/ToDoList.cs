using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //data connection 
using System.Configuration;

namespace TodoListApp
{
	public partial class ToDoList : Form
	{
		public ToDoList()
		{
			InitializeComponent();
		//	this.Size = new Size(1060, 727); // Use the size of the NoteTaker form
		}
		//	SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahd\OneDrive\Documents\Msc\AdvancedWebTech\Coursework\TodoListApp\TodoListApp\LocalDatabase.mdf;Integrated Security=True");
		// ConfigurationManager to get connection string from app.config
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

		//new datatable to store data from the list and is for the datagrid view
		DataTable todoList = new DataTable();
		//bool to track when tasks are being edited
		bool isEdited = false;

		private void Form1_Load(object sender, EventArgs e)
		{
			//create columns
			todoList.Columns.Add("Title");
			todoList.Columns.Add("Description");
			todoList.Columns.Add("Completed");

			//point datagridview to datasource
			toDoListView.DataSource = todoList;

			//load existing to-do items from the database
			LoadToDoItems();

		}

		private void LoadToDoItems()
		{
			todoList.Clear(); // Clear the existing items.
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlDataAdapter sda = new SqlDataAdapter("SELECT TodoID, Title, Description, IsCompleted FROM tblToDos", conn))
				{
					sda.Fill(todoList); // Fill the DataTable with data from the database.
				}
			}

			//after binidng the data source
			toDoListView.DataSource = todoList;

			
			toDoListView.Columns["ToDoID"].Visible = false;
			toDoListView.Columns["Completed"].Visible = false;
		}


		private void NewBtn_Click(object sender, EventArgs e)
		{
			//Check if the Title text box is not empty
			if (!string.IsNullOrWhiteSpace(txtTitle.Text))
			{
				if (isEdited)
				{

					//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
					//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = txtDescription.Text;
					//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Completed"] = CheckBoxCompleted.Checked; // Update the completed status

					int selectedToDoID = GetSelectedToDoID(); //this method to retreive the id
															  //Update the todo item in the database
					UpdateToDoItem(selectedToDoID, txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked);

				}
				else
				{
					//add a new row
					//todoList.Rows.Add(txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked); //adding two parameters
					//insert a new todo item into the database
					InsertToDoItem(txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked);
				}
				LoadToDoItems(); // Refresh the data grid view.

				//clear fields after clicking save btn
				txtTitle.Text = "";
				txtDescription.Text = "";
				CheckBoxCompleted.Checked = false;
				isEdited = false;
			}
			else
			{
				MessageBox.Show("Please enter a title for the task", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void EditBtn_Click(object sender, EventArgs e)
		{
			isEdited = true;
			//fill text boxes with existing data from table
			txtTitle.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtDescription.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString(); //access the other column that stores the description
			//CheckBoxCompleted.Checked = Convert.ToBoolean(todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[2].ToString());
			CheckBoxCompleted.Checked = Convert.ToBoolean(todoList.Rows[toDoListView.CurrentCell.RowIndex]["IsCompleted"]);

		}


		//private void DeleteBtn_Click(object sender, EventArgs e)
		//{
		//	// Confirm deletion
		//	if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		try
		//		{
		//			//deleting the chosen item in the datagrid
		//			todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete();
		//			int selectedToDoID = GetSelectedToDoID();
		//			DeleteToDoItem(selectedToDoID);
		//			LoadToDoItems(); // Refresh the data grid view.
		//		}
		//		catch (Exception ex)
		//		{
		//			Console.WriteLine("Error: " + ex);
		//			// MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//		}
		//	}
		//}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			// Confirm deletion
			if (MessageBox.Show("Are you sure you want to delete this item?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (toDoListView.CurrentRow != null)
				{
					int selectedToDoID = GetSelectedToDoID(); // Get the selected note ID first
					if (selectedToDoID != -1)
					{
						try
						{
							todoList.Rows[toDoListView.CurrentCell.RowIndex].Delete(); // Then delete from DataTable
							todoList.AcceptChanges(); // Accept the changes in the DataTable
							DeleteToDoItem(selectedToDoID); // And finally delete from the database
							LoadToDoItems(); // Refresh the data grid view
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error deleting item: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}

						//clear fields after clicking save btn
						txtTitle.Text = "";
						txtDescription.Text = "";
						CheckBoxCompleted.Checked = false;
						isEdited = false;
					}
					else
					{
						MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			////Check if the Title text box is not empty
			//if (!string.IsNullOrWhiteSpace(txtTitle.Text))
			//{ 
			//	if (isEdited)
			//	{
					
			//		//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Title"] = txtTitle.Text;
			//		//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Description"] = txtDescription.Text;
			//		//todoList.Rows[toDoListView.CurrentCell.RowIndex]["Completed"] = CheckBoxCompleted.Checked; // Update the completed status

			//		int selectedToDoID = GetSelectedToDoID(); //this method to retreive the id
			//		//Update the todo item in the database
			//		UpdateToDoItem(selectedToDoID, txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked);

			//	}
			//	else
			//	{
			//		//add a new row
			//		//todoList.Rows.Add(txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked); //adding two parameters
			//		//insert a new todo item into the database
			//		InsertToDoItem(txtTitle.Text, txtDescription.Text, CheckBoxCompleted.Checked);
			//	}
			//	LoadToDoItems(); // Refresh the data grid view.
				
			//	//clear fields after clicking save btn
			//	txtTitle.Text = "";
			//	txtDescription.Text = "";
			//	CheckBoxCompleted.Checked = false;
			//	isEdited = false;
			//}
			//else
			//{
			//	MessageBox.Show("Please enter a title for the task", "Missing Title", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//}
		}

		private void button1_Click(object sender, EventArgs e)
		{
		LogIn LogInForm = new LogIn();

			LogInForm.Show();
			this.Hide();
		}

		//insert a new record to the database
		private void InsertToDoItem(string title, string description, bool isCompleted)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO tblToDos (Title, Description, IsCompleted) VALUES (@Title, @Description, @IsCompleted)";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@Title", title);
					cmd.Parameters.AddWithValue("@Description", description);
					cmd.Parameters.AddWithValue("@IsCompleted", isCompleted);

					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		//update the record if edited
		private void UpdateToDoItem(int id, string title, string description, bool isCompleted)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "UPDATE tblToDos SET Title = @Title, Description = @Description, IsCompleted = @IsCompleted WHERE ToDoID = @ToDoID";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@ToDoID", id);
					cmd.Parameters.AddWithValue("@Title", title);
					cmd.Parameters.AddWithValue("@Description", description);
					cmd.Parameters.AddWithValue("@IsCompleted", isCompleted);

					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		//deleting the selected to do Item
		private void DeleteToDoItem(int id)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM tblToDos WHERE ToDoID = @ToDoID";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@ToDoID", id);

					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		private int GetSelectedToDoID()
		{
			//ensure a row is selected
			if (toDoListView.CurrentRow != null)
			{
				
				// Adjust the index if  ID is in a different column
				return Convert.ToInt32(toDoListView.CurrentRow.Cells["ToDoID"].Value);
			}
			else
			{
				//no item is selected, or to prevent user from editing/deleting when no item is selected
				return -1; // or throw an exception, or handle this case appropriately
			}
		}

		private void toDoListViews_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTitle.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtDescription.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
			CheckBoxCompleted.Checked = Convert.ToBoolean(todoList.Rows[toDoListView.CurrentCell.RowIndex]["IsCompleted"]);
			isEdited = true;
		}

		private void toDoListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTitle.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtDescription.Text = todoList.Rows[toDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
			CheckBoxCompleted.Checked = Convert.ToBoolean(todoList.Rows[toDoListView.CurrentCell.RowIndex]["IsCompleted"]);
			isEdited = true;
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			LogIn login = new LogIn();
			this.Hide();
			login.Show();
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Dashboard dashboard = new Dashboard();
			this.Hide();
			dashboard.Show();
		}
	}
}
