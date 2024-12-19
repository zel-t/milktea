using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalmilktea
{

    public partial class Form1 : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";
        private int loginAttempts;

        public Form1()
        {
            InitializeComponent();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked == true)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '*';

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Establish the connection string to connect to the Access database
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb");

            // SQL query to check if the username and password match and retrieve the user type
            string query = "SELECT [Type] FROM useracc WHERE Username = @username AND [Password] = @password";

            // Create and configure the command
            cmd = new OleDbCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);

            try
            {
                // Open the connection
                conn.Open();

                // Execute the query and get the result
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    // The user exists, and we have retrieved the Type
                    string userType = result.ToString();

                    // Check the user type and open the corresponding form
                    this.Hide();

                    if (userType == "cashier")
                    {
                        Forrm1 orders = new Forrm1();
                        orders.Show();
                    }
                    else if (userType == "admin")
                    {
                        signature signature = new signature();
                        signature.Show();
                    }
                    else
                    {
                        MessageBox.Show("Unrecognized user type.");
                        this.Show(); // Show the login form again if type is unrecognized
                    }
                }
                else
                {
                    // Increment the login attempts and show an error message
                    loginAttempts++;
                    MessageBox.Show("Invalid username or password.");

                    if (loginAttempts >= 3)
                    {
                        // Close the application if 3 failed login attempts
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the connection
                conn.Close();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
