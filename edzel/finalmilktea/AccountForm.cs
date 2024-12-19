using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalmilktea
{
    public partial class AccountForm : Form
    {
        private int userId;
        private OleDbConnection conn;
        private DataGridView dgvAccounts;

        public Action AccountUpdated { get; internal set; }

        public AccountForm(int userId, DataGridView dataGridView)
        {
            InitializeComponent();
            this.userId = userId;
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb");
            dgvAccounts = new DataGridView();// Optional: Dock the DataGridView to fill the form
            LoadAccountData(); // Load data when the form is loaded
        }

        public AccountForm()
        {
        }

        public AccountForm(int userId)
        {
            this.userId = userId;
        }

        private void LoadAccountData()
        {
            string query = "SELECT UserID, Username, [Password], [Type] FROM useracc";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable accountTable = new DataTable();

            try
            {
                conn.Open();
                adapter.Fill(accountTable); // Fill the DataTable with data
                dgvAccounts.DataSource = accountTable; // Bind the DataTable to DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading account data: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e, DataGridView dataGridView)
        {
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            string newUsername = txtUsername.Text;
            string newPassword = txtPassword.Text;
            string userType = "cashier"; // Default to "cashier"

            if (string.IsNullOrEmpty(newUsername) || string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Please fill in both the username and password.");
                return;
            }

            string updateQuery = "UPDATE [useracc] SET [Username] = @username, [Password] = @password, [Type] = @type WHERE [UserID] = @userId";
            OleDbCommand cmd = new OleDbCommand(updateQuery, conn);
            cmd.Parameters.AddWithValue("@username", newUsername);
            cmd.Parameters.AddWithValue("@password", newPassword);
            cmd.Parameters.AddWithValue("@type", userType); // Default type as "cashier"
            cmd.Parameters.AddWithValue("@userId", userId); // Update by UserID

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account updated successfully.");

                ReloadDataGridView(); // Reload the DataGridView in the ManagementForm
                this.Close(); // Optionally close the form after update
                ReloadManagementForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating account: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void ReloadManagementForm()
        {
            // Hide the current form
            this.Hide();

            // Create and show the new instance
            management newManagementForm = new management();
            newManagementForm.ShowDialog();

            // Dispose of the old form after the new one is closed
            this.Dispose();
        }

        // Method to reload the DataGridView with updated account data
        private void ReloadDataGridView()
        {
            // You can either directly update the DataGridView or call a method from ManagementForm
            string query = "SELECT * FROM useracc";
            OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
            DataTable accountTable = new DataTable();
            adapter.Fill(accountTable);

            dgvAccounts.DataSource = accountTable; // This reloads the DataGridView in ManagementForm
        }
    }
}

