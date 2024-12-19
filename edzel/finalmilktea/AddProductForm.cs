using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalmilktea
{
    public partial class AddProductForm : Form
    {
        private Form parentForm;
        private string category;

        // Delegate and event to notify parent form to refresh product list after adding a new product
        public delegate void ProductAddedEventHandler();
        public event ProductAddedEventHandler ProductAdded;

        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";
        public AddProductForm(Form parentForm, string category)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.category = category;
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            // Create an OpenFileDialog to select an image
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp",  // Filter for common image formats
                Title = "Select a Product Image"
            };

            // If the user selects a file and clicks OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Display the selected image in pictureBox1
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtProductName.Text) || pictureBox1.Image == null)
                {
                    MessageBox.Show("Please fill in all fields and upload an image.");
                    return;
                }

                using (MemoryStream ms = new MemoryStream())
                {
                    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = ms.ToArray();

                    using (OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb"))
                    {
                        connection.Open();
                        string query = "INSERT INTO products (product_name, product_image, category) VALUES (@name, @image, @category)";
                        using (OleDbCommand cmd = new OleDbCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@name", txtProductName.Text);
                            cmd.Parameters.AddWithValue("@image", imageBytes);
                            cmd.Parameters.AddWithValue("@category", this.category); // Use the category passed from the parent form

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Product added successfully!");

                            // Trigger the ProductAdded event to notify the parent form to reload the product list
                            ProductAdded?.Invoke();  // If there's a subscriber (parent form), invoke the event

                            this.Close();  // Close the AddProductForm after saving
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
             this.Close();
        }
    }
}


