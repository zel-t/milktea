namespace Useracc
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnNontea = new System.Windows.Forms.Button();
            this.btnFruittea = new System.Windows.Forms.Button();
            this.btnMilktea = new System.Windows.Forms.Button();
            this.btnPopular = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNontea
            // 
            this.btnNontea.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNontea.Location = new System.Drawing.Point(37, 384);
            this.btnNontea.Margin = new System.Windows.Forms.Padding(2);
            this.btnNontea.Name = "btnNontea";
            this.btnNontea.Size = new System.Drawing.Size(114, 45);
            this.btnNontea.TabIndex = 45;
            this.btnNontea.Text = "NON-TEA DRINKS";
            this.btnNontea.UseVisualStyleBackColor = true;
            // 
            // btnFruittea
            // 
            this.btnFruittea.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFruittea.Location = new System.Drawing.Point(37, 318);
            this.btnFruittea.Margin = new System.Windows.Forms.Padding(2);
            this.btnFruittea.Name = "btnFruittea";
            this.btnFruittea.Size = new System.Drawing.Size(114, 45);
            this.btnFruittea.TabIndex = 44;
            this.btnFruittea.Text = "FRUIT TEA";
            this.btnFruittea.UseVisualStyleBackColor = true;
            this.btnFruittea.Click += new System.EventHandler(this.btnManagement_Click);
            // 
            // btnMilktea
            // 
            this.btnMilktea.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMilktea.Location = new System.Drawing.Point(37, 243);
            this.btnMilktea.Margin = new System.Windows.Forms.Padding(2);
            this.btnMilktea.Name = "btnMilktea";
            this.btnMilktea.Size = new System.Drawing.Size(114, 45);
            this.btnMilktea.TabIndex = 43;
            this.btnMilktea.Text = "MILKTEA";
            this.btnMilktea.UseVisualStyleBackColor = true;
            this.btnMilktea.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnPopular
            // 
            this.btnPopular.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPopular.Location = new System.Drawing.Point(37, 171);
            this.btnPopular.Margin = new System.Windows.Forms.Padding(2);
            this.btnPopular.Name = "btnPopular";
            this.btnPopular.Size = new System.Drawing.Size(114, 45);
            this.btnPopular.TabIndex = 42;
            this.btnPopular.Text = "POPULAR";
            this.btnPopular.UseVisualStyleBackColor = true;
            this.btnPopular.Click += new System.EventHandler(this.btnPopular_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // dashboardPanel
            // 
            this.dashboardPanel.AutoScroll = true;
            this.dashboardPanel.Location = new System.Drawing.Point(174, 132);
            this.dashboardPanel.Margin = new System.Windows.Forms.Padding(2);
            this.dashboardPanel.Name = "dashboardPanel";
            this.dashboardPanel.Size = new System.Drawing.Size(781, 370);
            this.dashboardPanel.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Useracc.Properties.Resources.carto;
            this.pictureBox2.Location = new System.Drawing.Point(833, 32);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 62);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 49;
            this.label1.Text = "POPULAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 589);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.dashboardPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNontea);
            this.Controls.Add(this.btnFruittea);
            this.Controls.Add(this.btnMilktea);
            this.Controls.Add(this.btnPopular);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNontea;
        private System.Windows.Forms.Button btnFruittea;
        private System.Windows.Forms.Button btnMilktea;
        private System.Windows.Forms.Button btnPopular;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel dashboardPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

