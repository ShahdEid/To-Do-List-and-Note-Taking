using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //data connection for retreieving log in data
using System.Configuration;


namespace TodoListApp
{
	public partial class LogIn : Form
	{
        //var to store the size
        //private Rectangle buttonOriginalRectangle; //size of the button
        //private Rectangle originalFormSize;//size of the form
		public LogIn()
		{
			InitializeComponent();
		}
        //Connection string
        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Shahd\OneDrive\Documents\Msc\AdvancedWebTech\Coursework\TodoListApp\TodoListApp\LocalDatabase.mdf;Integrated Security=True");
        // ConfigurationManager to get connection string from app.config
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString);

        private void LoginBtn_Click(object sender, EventArgs e)
		{
            try
            {
                conn.Open();
                string query = "SELECT * FROM Login_new WHERE UserName = @UserName AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@UserName", txtUserName.Text);
                cmd.Parameters.AddWithValue("@Password", txtPassword.Text);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    //User found, open the ToDoList form
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();
                }
                else
                {
                    //User not found, show error message
                    MessageBox.Show("Invalid Login!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                //Show any exception messages
                MessageBox.Show("Error during login: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Ensure connection is always closed
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            //originalFormSize = new Rectangle(this.Location.X, this.Location.Y, this.Width, this.Height);
            //buttonOriginalRectangle = new Rectangle(LoginBtn.Location.X, LoginBtn.Location.Y, LoginBtn.Width, LoginBtn.Height);
        }


        private void ClearBtn_Click(object sender, EventArgs e)
		{
			txtUserName.Clear();
			txtPassword.Clear();


			txtUserName.Focus();

		}

		private void LoginBtn_Resize(object sender, EventArgs e)
		{

		}

        private void resizeControl(Rectangle r, Control c)
		{
            //float xRatio = (float)(this.Width) / (float)(originalFormSize.Width);
            //float yRatio = (float)(this.Height) / (float)(originalFormSize.Width);

            ////calculate new x and y coordinates
            //int newX = (int)(r.Width * xRatio);
            //int newY = (int)(r.Height * yRatio);

            ////calculate new height and width
            //int newWidth = (int)(r.Width * xRatio);
            //int newHeight = (int)(r.Height * yRatio);

            ////change controls
            //c.Location = new Point(newX, newY);
            //c.Size = new Size(newWidth, newHeight);

        }
        private void LogIn_Resize(object sender, EventArgs e)
		{
            //resizeControl(buttonOriginalRectangle, LoginBtn);
		}

		private void label2_Click(object sender, EventArgs e)
		{

		}
	}
}
