using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Useracc
{
    public partial class Order_received : Form
    {
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\USER\\Desktop\\edzel\\Final.accdb";
        public Image ProductImage { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string AddOns { get; set; }
        public string SpecialInstructions { get; set; }
        public decimal Total { get; set; }
        public Order_received()
        {
            InitializeComponent();
        }

        private void specialLabel_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Order_received_Load(object sender, EventArgs e)
        {

            productPictureBox.Image = ProductImage;
            productName.Text = ProductName;
            productPrice.Text = $"₱ {ProductPrice:F2}";
            qtyLabel.Text = Quantity.ToString();
            specialLabel.Text = SpecialInstructions;
            totalLabel.Text = $"₱ {Total:F2}";

            // Generate Order ID 
            Random random = new Random();
            int orderId = random.Next(100, 1000);
            orderIdLabel.Text = orderId.ToString();

            // Save to database
            SaveOrderToDatabase(orderId);
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
            productName.Top = 200; // Adjust Y position for product name
            productPrice.Top = productName.Bottom + 10;
        }

        private void SaveOrderToDatabase(int orderId)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO orders ([Order ID], [Order List and Quantity], Total, [Status], [Date and Time]) " +
                               "VALUES (@orderId, @orderListQuantity, @total, @status, @dateTime)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    // Concatenate product name and quantity for "Order List and Quantity"
                    string orderListQuantity = $"{ProductName} - {Quantity} pcs";

                    // Default status
                    string status = "Processing";

                    // Get the current date and time
                    DateTime currentDateTime = DateTime.Now;

                    // Add parameters
                    command.Parameters.AddWithValue("@orderId", orderId);
                    command.Parameters.AddWithValue("@orderListQuantity", orderListQuantity);
                    command.Parameters.AddWithValue("@total", Total);
                    command.Parameters.AddWithValue("@status", status);

                    // Add the DateTime parameter with correct type
                    OleDbParameter dateTimeParam = new OleDbParameter("@dateTime", OleDbType.Date);
                    dateTimeParam.Value = currentDateTime;
                    command.Parameters.Add(dateTimeParam);

                    // Execute query
                    command.ExecuteNonQuery();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void qtyLabel_Click(object sender, EventArgs e)
        {

        }

        private void orderIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void closeBTN_Click(object sender, EventArgs e)
        {

            this.Close();
        }
    }
}
