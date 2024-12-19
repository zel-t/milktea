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
    public partial class inventory : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";

        public inventory()
        {
            InitializeComponent();
            LoadIngredients();
        }
        private void SetupDataGridViewColumns()
        {
            // Clear any existing columns
            dgvIngredients.Columns.Clear();

            // Add new columns to DataGridView
            dgvIngredients.Columns.Add("item_id", "Item ID");
            dgvIngredients.Columns.Add("item_name", "Ingredient Name");
            dgvIngredients.Columns.Add("quantity", "Quantity");
            dgvIngredients.Columns.Add("unit", "Unit");

            // Optionally, set some column properties (like read-only)
            dgvIngredients.Columns["item_id"].ReadOnly = true;  // Item ID is read-only
            dgvIngredients.Columns["item_name"].ReadOnly = true; // Ingredient Name is read-only

            // Set the DataGridView to fill the form area
            dgvIngredients.Dock = DockStyle.Fill;  // This will make the DataGridView fill the entire available space.

            // Auto-size the columns to fill the available width
            dgvIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Automatically fill the width of the columns

            // Optionally, set AutoSizeRowsMode if you want the rows to adjust based on content
            dgvIngredients.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells; // Ingredient Name is read-only
        }
        private void LoadIngredients()
        {
            try
            {
                // Clear any existing rows before loading new data
                dgvIngredients.Rows.Clear();

                // SQL query to retrieve ingredients from the database
                string query = "SELECT item_id, item_name, quantity, unit FROM ingredients";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    // Loop through the results and add rows to DataGridView
                    while (reader.Read())
                    {
                        int itemId = reader.GetInt32(0); // Get item_id
                        string itemName = reader["item_name"].ToString(); // Get item_name
                        int quantity = Convert.ToInt32(reader["quantity"]); // Get quantity
                        string unit = reader["unit"].ToString(); // Get unit (e.g., "scoops")

                        // Add the data to the DataGridView
                        dgvIngredients.Rows.Add(itemId, itemName, quantity, unit);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if txtQuantity is initialized and contains a valid number
                if (txtQuantity == null || string.IsNullOrWhiteSpace(txtQuantity.Text))
                {
                    MessageBox.Show("Please enter a quantity change value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if no quantity is entered
                }

                // Try to parse the quantity change from txtQuantity
                int quantityChange;
                if (!int.TryParse(txtQuantity.Text, out quantityChange))
                {
                    MessageBox.Show("Please enter a valid integer for the quantity change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if the input is not a valid number
                }

                // Ensure dgvIngredients is not null and has rows selected
                if (dgvIngredients == null || dgvIngredients.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an ingredient to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if no row is selected
                }

                // Get the selected row's data
                DataGridViewRow selectedRow = dgvIngredients.SelectedRows[0];
                int itemId = Convert.ToInt32(selectedRow.Cells["item_id"].Value); // Get item_id from selected row
                string ingredientName = selectedRow.Cells["item_name"].Value.ToString(); // Get ingredient name
                int currentQuantity = Convert.ToInt32(selectedRow.Cells["quantity"].Value); // Get current quantity

                // Calculate the new quantity
                int newQuantity = currentQuantity + quantityChange;

                // Ensure the new quantity is not negative
                if (newQuantity < 0)
                {
                    MessageBox.Show("Stock cannot be negative.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if the new quantity would be negative
                }

                // SQL query to update the stock in the database
                string updateQuery = "UPDATE ingredients SET quantity = @newQuantity WHERE item_id = @itemId";

                // Execute the SQL query to update the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand(updateQuery, connection);
                    command.Parameters.AddWithValue("@newQuantity", newQuantity); // Set new quantity
                    command.Parameters.AddWithValue("@itemId", itemId); // Set item ID

                    command.ExecuteNonQuery(); // Execute the update query
                }

                // Update the DataGridView with the new quantity
                selectedRow.Cells["quantity"].Value = newQuantity;

                MessageBox.Show($"Stock updated for {ingredientName}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"Error updating stock: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            signature signature = new signature();
            signature.Show();
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            management management = new management();
            management.Show();
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {

        }
    }
}
