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
    public partial class milktea : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";  // Connection string to database
        public milktea()
        {
            InitializeComponent();
            LoadProductsToDashboard();
        }
        public void LoadProductsToDashboard()
        {
            try
            {
                dashboardPanel.Controls.Clear(); // Clear existing product panels

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT product_id, product_name, product_image FROM products WHERE category = 'MilkTea'";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int productId = reader.GetInt32(0);
                        string productName = reader["product_name"]?.ToString() ?? "Unnamed Product";
                        byte[] productImageBytes = reader["product_image"] as byte[];

                        // Create a panel for each product
                        Panel productPanel = new Panel
                        {
                            Width = 150,
                            Height = 200,
                            Margin = new Padding(15),
                            Tag = productId // Store product ID in the Tag property
                        };

                        // Add PictureBox for the product image
                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 145,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Top
                        };
                        pictureBox.Image = productImageBytes != null
                            ? Image.FromStream(new MemoryStream(productImageBytes))
                            : Properties.Resources.back; // Fallback image if no product image is available

                        // Add Label for the product name
                        Label nameLabel = new Label
                        {
                            Text = productName,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Height = 55,
                            Font = new Font("Tahoma", 10, FontStyle.Regular)
                        };

                        // Add Delete Button to the product panel
                        Button deleteButton = new Button
                        {
                            Text = "Delete",
                            Dock = DockStyle.Bottom,
                            Height = 20,
                            Tag = productId // Store product ID in the Tag property of the delete button
                        };

                        // Attach event handler for the delete functionality
                        deleteButton.Click += (sender, e) =>
                        {
                            DialogResult confirmResult = MessageBox.Show(
                                "Are you sure you want to delete this product?",
                                "Confirm Deletion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning);

                            if (confirmResult == DialogResult.Yes)
                            {
                                int idToDelete = (int)((Button)sender).Tag;
                                DeleteProduct(idToDelete); // Call the DeleteProduct method
                            }
                        };

                        // Add controls to the product panel in the desired order
                        productPanel.Controls.Add(pictureBox);   // PictureBox at the top
                        productPanel.Controls.Add(nameLabel);    // Name label in the middle
                        productPanel.Controls.Add(deleteButton); // Delete button at the bottom

                        // Add the product panel to the FlowLayoutPanel
                        dashboardPanel.Controls.Add(productPanel);
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to delete a product from the database
        private void DeleteProduct(int productId)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM products WHERE product_id = @productId";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    command.Parameters.AddWithValue("@productId", productId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductsToDashboard(); // Refresh the product list after deletion
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete the product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm(this, "MilkTea");
            addProductForm.ProductAdded += LoadProductsToDashboard;  // Subscribe to the event to refresh data
            addProductForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            // Create the signature form and pass the userId to the constructor
            signature signatureForm = new signature();
signatureForm.Show(); // Show the signature form
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            fruit fruit = new fruit();
            fruit.Show();  // Show the MilkTea form
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            nontea nonTeaForm = new nontea();  // Create an instance of the NonTea form
            nonTeaForm.Show();  // Show the NonTea form
            this.Hide();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory inventory = new inventory();  // Create an instance of the NonTea form
            inventory.Show();  // Show the NonTea form
            this.Hide();
        }

        private void btnManagement_Click(object sender, EventArgs e)
        {
            management management = new management();
            management.Show();
            this.Hide();
        }
    }
}
