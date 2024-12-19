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

namespace Useracc
{

    public partial class edit : Form
    {
        private int productId;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";
        private object pictureBoxProductImage;
        private object textBoxProductName;


        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public int Quantity { get; set; } = 1; // Default quantity to 1
        public decimal BaseProductPrice { get; set; }

        public edit(int productId)
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Ensure ProductPrice is initialized correctly
            // Ensure ProductPrice is correctly set before navigating to the next form
            if (ProductPrice <= 0)
            {
                MessageBox.Show("Invalid product price. Please ensure the price is set correctly.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var orderDetailsForm = new Order_details
            {
                ProductImage = ProductImage,      // Set the product image
                ProductName = ProductName,        // Set the product name
                BaseProductPrice = ProductPrice,  // Pass the current ProductPrice as BaseProductPrice
                ProductPrice = ProductPrice,      // Initialize ProductPrice with the correct value
                AddOns = "",                      // No add-ons initially
                SpecialInstructions = "",         // No special instructions initially
                Quantity = 1                      // Default quantity is 1
            };
            orderDetailsForm.Show();
            this.Close();
        }

        private void edit_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}";
            AlignLabels();
        }

        private void AlignLabels()
        {
            productName.Width = 300; // Set a width for the name label (you can adjust this value as needed)
            productName.Location = new Point((this.Width - productName.Width) / 2, productName.Location.Y);

            // Center-align the product price label horizontally
            productPrice.Width = 300; // Set a width for the price label (you can adjust this value as needed)
            productPrice.Location = new Point((this.Width - productPrice.Width) / 2, productPrice.Location.Y);

            // Optional: Adjust the Y-positions of the labels if necessary to make them look better
            productName.Top = 300; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

