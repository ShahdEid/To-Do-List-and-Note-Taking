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
	public partial class NoteTaker : Form
	{
		
		public NoteTaker()
		{
			InitializeComponent();
		}
		//	SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahd\OneDrive\Documents\Msc\AdvancedWebTech\Coursework\TodoListApp\TodoListApp\LocalDatabase.mdf;Integrated Security=True");
		// ConfigurationManager to get connection string from app.config
		SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);


		DataTable notes = new DataTable();
		bool edited = false; //keep track of what is edited
		private void NoteTaker_Load(object sender, EventArgs e)
		{
			//create columns 
			notes.Columns.Add("Title");
			notes.Columns.Add("Note");

			//point datagrid to datasource
			previousNotes.DataSource = notes;

			//load existing notes from database
			LoadNotes();
		}

		private void LoadNotes()
		{
			notes.Clear(); // Clear the existing items.
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				using (SqlDataAdapter sda = new SqlDataAdapter("SELECT NoteID, Title, Note FROM tblNotes", conn))
				{
					sda.Fill(notes); // Fill the DataTable with data from the database.
				}
			}

			//after binidng the data source
			previousNotes.DataSource = notes;


			previousNotes.Columns["NoteID"].Visible = false;
			
		}
		//private void btnDelete_Click(object sender, EventArgs e)
		//{
		//	// Confirm deletion
		//	if (MessageBox.Show("Are you sure you want to delete this Note?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
		//	{
		//		try
		//		{
		//			//deleting the chosen cell in the datagrid
		//			notes.Rows[previousNotes.CurrentCell.RowIndex].Delete();
		//			int selectedNoteID = GetSelectedNoteID();
		//			DeleteNote(selectedNoteID);
		//			LoadNotes(); // Refresh the data grid view.
		//		}
		//		catch (Exception ex)
		//		{
		//			Console.WriteLine("Please Enter a Valid Note");
		//		}
		//	}
		//}


		private void btnDelete_Click(object sender, EventArgs e)
		{
			// confirm deletion
			if (MessageBox.Show("Are you sure you want to delete this Note?", "Delete Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (previousNotes.CurrentRow != null)
				{
					int selectedNoteID = GetSelectedNoteID(); //get the selected note ID first
					if (selectedNoteID != -1)
					{
						try
						{
							notes.Rows[previousNotes.CurrentCell.RowIndex].Delete(); //delete from DataTable
							notes.AcceptChanges(); // Accept the changes in the DataTable
							DeleteNote(selectedNoteID); //delete from the database
							LoadNotes(); //refresh the data grid view
						}
						catch (Exception ex)
						{
							MessageBox.Show("Error deleting note: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("Please select a note to delete.", "No Note Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtNote.Text))
			{
				if (edited)
				{
					int selectedNoteID = GetSelectedNoteID(); //this method to retreive the note id
					// Update existing note
					UpdateNote(selectedNoteID, txtTitle.Text, txtNote.Text);
					//UpdateNote(selectedNoteID.CurrentRow.Cells["NoteID"].Value.ToString(), txtTitle.Text, txtNote.Text);
				}
				else
				{
					// Insert new note
					InsertNote(txtTitle.Text, txtNote.Text);
				}

				LoadNotes(); // Refresh notes from database

				// Clear input fields
				txtTitle.Text = "";
				txtNote.Text = "";
				edited = false;
			}
			else
			{
				MessageBox.Show("Title or note content cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnNewNote_Click(object sender, EventArgs e)
		{
			//clear text boxes for a new note 
			txtTitle.Text = "";
			txtNote.Text = "";
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			txtTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
			edited = true;

		}

		//insert a new record to the database
		private void InsertNote(string title, string note)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "INSERT INTO tblNotes (Title, Note) VALUES (@Title, @Note)";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@Title", title);
					cmd.Parameters.AddWithValue("@Note", note);
					
					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}


		//deleting the selected note
		private void DeleteNote(int id)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "DELETE FROM tblNotes WHERE NoteID = @NoteID";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@NoteID", id);

					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}



		//update existing note
		private void UpdateNote(int id, string title, string note)
		{
			string connectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;

			using (SqlConnection conn = new SqlConnection(connectionString))
			{
				string query = "UPDATE tblNotes SET Title = @Title, Note = @Note WHERE NoteID = @NoteID";

				using (SqlCommand cmd = new SqlCommand(query, conn))
				{
					cmd.Parameters.AddWithValue("@NoteID", id);
					cmd.Parameters.AddWithValue("@Title", title);
					cmd.Parameters.AddWithValue("@Note", note);
					

					conn.Open();
					cmd.ExecuteNonQuery();
				}
			}
		}

		//private void UpdateNote(string noteId, string title, string noteContent)
		//{
		//	string query = "UPDATE tblNotes SET Title = @Title, Note = @Note WHERE NoteID = @NoteID";
		//	ExecuteQuery(query, new SqlParameter("@NoteID", noteId), new SqlParameter("@Title", title), new SqlParameter("@Note", noteContent));
		//}
		private void previousNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
			edited = true;
		}
		private void previousNotes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txtTitle.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
			txtNote.Text = notes.Rows[previousNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
			edited = true;
		}

		private int GetSelectedNoteID()
		{
			//ensure a row is selected
			if (previousNotes.CurrentRow != null)
			{

				// Adjust the index if ID is in a different column
				return Convert.ToInt32(previousNotes.CurrentRow.Cells["NoteID"].Value);
			}
			else
			{
				//no note is selected, or to prevent user from editing/deleting when no note is selected
				return -1; // or throw an exception, or handle this case appropriately
			}
		}

		private void Logoutbtn_Click(object sender, EventArgs e)
		{
			//User found, open the ToDoList form
			LogIn loginForm = new LogIn();
			loginForm.Show();
			this.Hide();
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
