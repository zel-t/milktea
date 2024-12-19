using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Useracc
{
    public partial class Order_details : Form
    {
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }

        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public int Quantity { get; set; } = 1; // Default quantity to 1
        public decimal BaseProductPrice { get; set; }

        public Order_details()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void productPrice_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Quantity > 1)
            {
                Quantity--;
                quantityLabel.Text = Quantity.ToString();
                UpdateTotal();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void backBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Order_details_Load(object sender, EventArgs e)
        {
            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;

            // Display ProductPrice which should now correctly reflect the base price + add-ons
            productPrice.Text = $"₱ {ProductPrice:F2}";
            quantityLabel.Text = Quantity.ToString();
            
            UpdateTotal();
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
            productName.Top = 240; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }
        private void increaseQtyBTN_Click(object sender, EventArgs e)
        {
            Quantity++;
            quantityLabel.Text = Quantity.ToString();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            // Calculate the add-ons price
            decimal addOnsPrice = ProductPrice - BaseProductPrice;

            // Calculate the total
            decimal total = (BaseProductPrice * Quantity) + addOnsPrice;

            // Update the total label
            totalLabel.Text = $"₱ {total:F2}";
        }

        private void nextBTN_Click(object sender, EventArgs e)
        {
            decimal addOnsPrice = ProductPrice - BaseProductPrice; // Calculate add-ons price
            decimal total = (BaseProductPrice * Quantity) + addOnsPrice; // Correct total calculation

            var orderSummaryForm = new Order_Summary
            {
                ProductImage = ProductImage,
                ProductName = ProductName,
                BaseProductPrice = BaseProductPrice, // Ensure base price consistency
                ProductPrice = ProductPrice,         // Keep the adjusted price with add-ons
                Quantity = Quantity,
                Total = (BaseProductPrice * Quantity) + (ProductPrice - BaseProductPrice),
            };

            orderSummaryForm.Show();
            this.Hide();  // Hide the current orderDetails form
        }
    }
}
