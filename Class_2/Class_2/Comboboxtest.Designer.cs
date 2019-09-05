namespace Class_2
{
    partial class Comboboxtest
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
            this.btnComboTest = new System.Windows.Forms.Button();
            this.cmbPlanet = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnComboTest
            // 
            this.btnComboTest.Location = new System.Drawing.Point(232, 186);
            this.btnComboTest.Name = "btnComboTest";
            this.btnComboTest.Size = new System.Drawing.Size(75, 23);
            this.btnComboTest.TabIndex = 0;
            this.btnComboTest.Text = "Combo Test";
            this.btnComboTest.UseVisualStyleBackColor = true;
            this.btnComboTest.Click += new System.EventHandler(this.btnComboTest_Click);
            // 
            // cmbPlanet
            // 
            this.cmbPlanet.FormattingEnabled = true;
            this.cmbPlanet.Items.AddRange(new object[] {
            "world",
            "earth",
            "moon"});
            this.cmbPlanet.Location = new System.Drawing.Point(149, 102);
            this.cmbPlanet.Name = "cmbPlanet";
            this.cmbPlanet.Size = new System.Drawing.Size(121, 21);
            this.cmbPlanet.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "planet";
            // 
            // Comboboxtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbPlanet);
            this.Controls.Add(this.btnComboTest);
            this.Name = "Comboboxtest";
            this.Text = "Comboboxtest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComboTest;
        private System.Windows.Forms.ComboBox cmbPlanet;
        private System.Windows.Forms.Label label1;
    }
}