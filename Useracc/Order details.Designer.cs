namespace Useracc
{
    partial class Order_details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_details));
            this.label1 = new System.Windows.Forms.Label();
            this.productPrice = new System.Windows.Forms.Label();
            this.addOnsBTN = new System.Windows.Forms.Button();
            this.nextBTN = new System.Windows.Forms.Button();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.decreaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.increaseQtyBTN = new System.Windows.Forms.PictureBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.backBTN = new System.Windows.Forms.PictureBox();
            this.productName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.decreaseQtyBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // productPrice
            // 
            this.productPrice.AutoSize = true;
            this.productPrice.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.Location = new System.Drawing.Point(274, 339);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productPrice.Name = "productPrice";
            this.productPrice.Size = new System.Drawing.Size(77, 24);
            this.productPrice.TabIndex = 6;
            this.productPrice.Text = "₱ 70.00";
            this.productPrice.Click += new System.EventHandler(this.productPrice_Click);
            // 
            // addOnsBTN
            // 
            this.addOnsBTN.Location = new System.Drawing.Point(247, 377);
            this.addOnsBTN.Name = "addOnsBTN";
            this.addOnsBTN.Size = new System.Drawing.Size(131, 51);
            this.addOnsBTN.TabIndex = 7;
            this.addOnsBTN.Text = "Customize";
            this.addOnsBTN.UseVisualStyleBackColor = true;
            // 
            // nextBTN
            // 
            this.nextBTN.Location = new System.Drawing.Point(242, 569);
            this.nextBTN.Name = "nextBTN";
            this.nextBTN.Size = new System.Drawing.Size(131, 51);
            this.nextBTN.TabIndex = 10;
            this.nextBTN.Text = "Proceed";
            this.nextBTN.UseVisualStyleBackColor = true;
            this.nextBTN.Click += new System.EventHandler(this.nextBTN_Click);
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.Location = new System.Drawing.Point(289, 449);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(30, 34);
            this.quantityLabel.TabIndex = 11;
            this.quantityLabel.Text = "1";
            this.quantityLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(319, 515);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(86, 32);
            this.totalLabel.TabIndex = 12;
            this.totalLabel.Text = "70.00";
            this.totalLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // decreaseQtyBTN
            // 
            this.decreaseQtyBTN.Image = ((System.Drawing.Image)(resources.GetObject("decreaseQtyBTN.Image")));
            this.decreaseQtyBTN.Location = new System.Drawing.Point(362, 445);
            this.decreaseQtyBTN.Name = "decreaseQtyBTN";
            this.decreaseQtyBTN.Size = new System.Drawing.Size(58, 38);
            this.decreaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.decreaseQtyBTN.TabIndex = 9;
            this.decreaseQtyBTN.TabStop = false;
            this.decreaseQtyBTN.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // increaseQtyBTN
            // 
            this.increaseQtyBTN.Image = ((System.Drawing.Image)(resources.GetObject("increaseQtyBTN.Image")));
            this.increaseQtyBTN.Location = new System.Drawing.Point(197, 445);
            this.increaseQtyBTN.Name = "increaseQtyBTN";
            this.increaseQtyBTN.Size = new System.Drawing.Size(58, 38);
            this.increaseQtyBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.increaseQtyBTN.TabIndex = 8;
            this.increaseQtyBTN.TabStop = false;
            this.increaseQtyBTN.Click += new System.EventHandler(this.increaseQtyBTN_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(186, 67);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(259, 219);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 4;
            this.productPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(200, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 32);
            this.label2.TabIndex = 14;
            this.label2.Text = "TOTAL:";
            // 
            // backBTN
            // 
            this.backBTN.Image = ((System.Drawing.Image)(resources.GetObject("backBTN.Image")));
            this.backBTN.Location = new System.Drawing.Point(30, 19);
            this.backBTN.Name = "backBTN";
            this.backBTN.Size = new System.Drawing.Size(60, 51);
            this.backBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backBTN.TabIndex = 15;
            this.backBTN.TabStop = false;
            this.backBTN.Click += new System.EventHandler(this.backBTN_Click);
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.Location = new System.Drawing.Point(264, 304);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(109, 24);
            this.productName.TabIndex = 5;
            this.productName.Text = "Chocolate";
            this.productName.Click += new System.EventHandler(this.productName_Click);
            // 
            // Order_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 632);
            this.Controls.Add(this.backBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.nextBTN);
            this.Controls.Add(this.decreaseQtyBTN);
            this.Controls.Add(this.increaseQtyBTN);
            this.Controls.Add(this.addOnsBTN);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.productPictureBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order_details";
            this.Load += new System.EventHandler(this.Order_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.decreaseQtyBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.increaseQtyBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productPrice;
        private System.Windows.Forms.Button addOnsBTN;
        private System.Windows.Forms.PictureBox increaseQtyBTN;
        private System.Windows.Forms.PictureBox decreaseQtyBTN;
        private System.Windows.Forms.Button nextBTN;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox backBTN;
        private System.Windows.Forms.Label productName;
    }
}