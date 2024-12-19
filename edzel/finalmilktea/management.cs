using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalmilktea
{
    public partial class management : Form
    {
        OleDbConnection conn;
        OleDbCommand cmd;
        OleDbDataAdapter adapter;
        DataTable accountTable;
        private int loginAttempts = 0;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";


        public management()
        {
            InitializeComponent();
            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb");
            LoadAccountData(); // Load data when the form is loaded
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";
            conn = new OleDbConnection(connectionString);

            try
            {
                conn.Open();
                string query = "SELECT UserID, Username, Password, [Type] FROM useracc";
                adapter = new OleDbDataAdapter(query, conn);
                accountTable = new DataTable();
                adapter.Fill(accountTable);

                // Bind the DataTable to the DataGridView
                DataGridView.DataSource = accountTable;

                // Make the columns fill the available width of the DataGridView
                DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading accounts: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadAccountData()
    {
        string query = "SELECT UserID, Username, [Password], [Type] FROM useracc";
        OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn);
        DataTable accountTable = new DataTable();

        try
        {
            conn.Open();
            adapter.Fill(accountTable);
            DataGridView.DataSource = accountTable;
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
        private void OpenAccountForm(int userId)
        {
            AccountForm accountForm = new AccountForm(userId);

            // Subscribe to the event
            accountForm.AccountUpdated += LoadAccountData;

            accountForm.Show();
        }

        // Add Account Button


        // Edit Account Button

        private void button2_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                // Get selected account UserID
                int selectedId = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["UserID"].Value);

                // Confirm deletion
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this account?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM useracc WHERE UserID = @userId";
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userId", selectedId);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Account deleted successfully.");
                        LoadAccounts(); // Reload data
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting account: {ex.Message}");
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an account to delete.");
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                // Get the UserID of the selected row
                int selectedUserId = Convert.ToInt32(DataGridView.SelectedRows[0].Cells["UserID"].Value);

                // Pass both the selectedUserId and DataGridView to the AccountForm
                AccountForm editForm = new AccountForm(selectedUserId, DataGridView);
                editForm.Show();

               

                this.Dispose();
            }
            else
            {
                MessageBox.Show("Please select an account to edit.");
            }

        }
       
        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            Add addForm = new Add(this);
            addForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            signature Signature = new signature(); // Create a new instance of Form1 
            Signature.Show();               // Show Form1 
            this.Hide();
        }
    }
}
