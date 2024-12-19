using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useracc
{
    public partial class Form1 : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";

        public Form1()
        {
            InitializeComponent();
            LoadProductsToDashboard();
        }
        public void LoadProductsToDashboard()
        {
            try
            {
                // Clear any existing controls in the dashboardPanel to ensure we load the latest products
                dashboardPanel.Controls.Clear();

                // Create a connection to the database
                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();
                    // SQL query to get products with category "Signature"
                    string query = "SELECT product_id, product_name, price,  product_image FROM products";
                    OleDbCommand command = new OleDbCommand(query, connection);
                    OleDbDataReader reader = command.ExecuteReader();

                    // Loop through the result set to display products
                    while (reader.Read())
                    {
                        // Retrieve data for each product
                        int productId = reader.GetInt32(0);  // Get the product ID
                        string productName = reader["product_name"]?.ToString() ?? "Unnamed Product";  // Get the product name
                        byte[] productImageBytes = reader["product_image"] as byte[];  // Get the product image as byte array
                        decimal productPrice = Convert.ToDecimal(reader["price"]);

                        // Create a new panel for each product
                        Panel productPanel = new Panel
                        {
                            Width = 150,
                            Height = 200,
                            Margin = new Padding(15),
                            Tag = productId  // Store the product ID in the Tag property
                        };

                        // Create and configure a PictureBox for the product image
                        PictureBox pictureBox = new PictureBox
                        {
                            Width = productPanel.Width,
                            Height = 145,
                            SizeMode = PictureBoxSizeMode.Zoom,
                            Dock = DockStyle.Top
                        }; 

                        pictureBox.Click += (s, e) =>
                        {
                            var productOrderForm = new edit(productId)
                            {
                                ProductImage = pictureBox.Image,
                                ProductName = productName,
                                ProductPrice = productPrice,

                            };
                            productOrderForm.Show();
                        };
                        // If there is an image for the product, load it; otherwise, use a default image
                        pictureBox.Image = productImageBytes != null
                            ? Image.FromStream(new MemoryStream(productImageBytes))
                            : Properties.Resources.back;  // Use a default image if no product image exists

                        // Create and configure a Label for the product name
                        Label nameLabel = new Label
                        {
                            Text = productName,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Height = 30,
                            Font = new Font("Tahoma", 10, FontStyle.Regular)
                        };

                        Label priceLabel = new Label
                        {
                            Text = $"₱{productPrice:F2}",
                            AutoSize = false,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Dock = DockStyle.Bottom,
                            Font = new Font("Tahoma", 10, FontStyle.Bold)
                        };

                        // Event handler to open the EditProductForm

                        // Add the PictureBox and Label to the productPanel
                        productPanel.Controls.Add(pictureBox);  // Add image at the top
                        productPanel.Controls.Add(nameLabel);   // Add name below the imag
                        productPanel.Controls.Add(priceLabel);

                        // Add the productPanel to the dashboardPanel to display the product
                        dashboardPanel.Controls.Add(productPanel);
                    }

                    // Close the data reader after we are done with it
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                // Show an error message if something goes wrong
                MessageBox.Show($"Error loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Method to open the EditProductForm with the product ID to edit
        private void OpenEditProductForm(int productId)
        {
            // Create a new instance of the EditProductForm and pass the product ID
            edit editForm = new edit(productId);
            editForm.ShowDialog();  // Show the edit form as a dialog to wait for user interaction
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            new milktea().Show();
            this.Hide();
        }
        private void btnManagement_Click(object sender, EventArgs e)
        {
            new fruit().Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPopular_Click(object sender, EventArgs e)
        {

        }
    }
}