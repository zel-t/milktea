using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.OleDb;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalmilktea
{
    public partial class Add : Form
    {
        private OleDbConnection conn;
        private management managementForm;
        public Add(management management)
        {
            InitializeComponent();
            this.managementForm = managementForm;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb");
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userType = "cashier"; // Default type for new accounts

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in both Username and Password.");
                return;
            }

            try
            {
                conn.Open();
                string insertQuery = "INSERT INTO useracc (Username, Password, [Type]) VALUES (@username, @password, @type)";
                OleDbCommand cmd = new OleDbCommand(insertQuery, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@type", userType);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Account added successfully.");

                ReloadManagementForm(); // Refresh the management form
                this.Close(); // Close the Add form
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding account: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }

        private void ReloadManagementForm()
        {
            if (managementForm != null)
            {
                managementForm.Close(); // Close the old management form
                management newManagementForm = new management();
                newManagementForm.Show(); // Open a new instance
            }
        }
    }
}
