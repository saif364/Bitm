namespace Class_2
{
    partial class PurchaseTicket
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
            this.btnDetails = new System.Windows.Forms.Button();
            this.btntoal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtunitPrice = new System.Windows.Forms.MaskedTextBox();
            this.txtNumberoftickets = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(300, 273);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(75, 23);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = true;
            // 
            // btntoal
            // 
            this.btntoal.Location = new System.Drawing.Point(155, 273);
            this.btntoal.Name = "btntoal";
            this.btntoal.Size = new System.Drawing.Size(75, 23);
            this.btntoal.TabIndex = 0;
            this.btntoal.Text = "Total";
            this.btntoal.UseVisualStyleBackColor = true;
            this.btntoal.Click += new System.EventHandler(this.btntoal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of tickets";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unit Price";
            // 
            // txtunitPrice
            // 
            this.txtunitPrice.Location = new System.Drawing.Point(208, 137);
            this.txtunitPrice.Name = "txtunitPrice";
            this.txtunitPrice.Size = new System.Drawing.Size(100, 20);
            this.txtunitPrice.TabIndex = 2;
            // 
            // txtNumberoftickets
            // 
            this.txtNumberoftickets.Location = new System.Drawing.Point(208, 81);
            this.txtNumberoftickets.Name = "txtNumberoftickets";
            this.txtNumberoftickets.Size = new System.Drawing.Size(100, 20);
            this.txtNumberoftickets.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Customer Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(208, 182);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // PurchaseTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 488);
            this.Controls.Add(this.txtNumberoftickets);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.txtunitPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btntoal);
            this.Controls.Add(this.btnDetails);
            this.Name = "PurchaseTicket";
            this.Text = "PurchaseTicket";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btntoal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtunitPrice;
        private System.Windows.Forms.MaskedTextBox txtNumberoftickets;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtCustomerName;
    }
}

