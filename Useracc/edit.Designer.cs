namespace Useracc
{
    partial class edit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit));
            this.label1 = new System.Windows.Forms.Label();
            this.orderBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.productName = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.backBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product";
            // 
            // orderBTN
            // 
            this.orderBTN.Location = new System.Drawing.Point(102, 529);
            this.orderBTN.Name = "orderBTN";
            this.orderBTN.Size = new System.Drawing.Size(196, 53);
            this.orderBTN.TabIndex = 1;
            this.orderBTN.Text = "Order";
            this.orderBTN.UseVisualStyleBackColor = true;
            this.orderBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(336, 529);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(258, 372);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(109, 24);
            this.productName.TabIndex = 4;
            this.productName.Text = "Chocolate";
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(275, 407);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(77, 24);
            this.productPrice.TabIndex = 5;
            this.productPrice.Text = "₱ 70.00";
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(184, 137);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(259, 219);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 3;
            this.productPictureBox.TabStop = false;
            // 
            // backBTN
            // 
            this.backBTN.Image = ((System.Drawing.Image)(resources.GetObject("backBTN.Image")));
            this.backBTN.Location = new System.Drawing.Point(23, 13);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(60, 51);
            this.backBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBTN.TabIndex = 6;
            this.backBTN.TabStop = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 632);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderBTN);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "edit";
            this.Load += new System.EventHandler(this.edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button orderBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.PictureBox backBTN;
    }
}