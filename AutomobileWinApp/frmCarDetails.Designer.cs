namespace AutomobileWinApp
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.MaskedTextBox();
            txtReleaseYear = new System.Windows.Forms.MaskedTextBox();
            cboManufacturer = new System.Windows.Forms.ComboBox();
            btSave = new System.Windows.Forms.Button();
            btCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(162, 128);
            lbCarID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(93, 38);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(162, 195);
            lbCarName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(140, 38);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(162, 275);
            lbManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(184, 38);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(162, 347);
            lbPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(78, 38);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(162, 409);
            lbReleaseYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(171, 38);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(345, 128);
            txtCarID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(430, 45);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(345, 195);
            txtCarName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(430, 45);
            txtCarName.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(345, 337);
            txtPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(430, 45);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(345, 409);
            txtReleaseYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(430, 45);
            txtReleaseYear.TabIndex = 8;
            txtReleaseYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota" });
            cboManufacturer.Location = new System.Drawing.Point(346, 263);
            cboManufacturer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new System.Drawing.Size(428, 46);
            cboManufacturer.TabIndex = 9;
            // 
            // btSave
            // 
            btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            btSave.Location = new System.Drawing.Point(346, 503);
            btSave.Name = "btSave";
            btSave.Size = new System.Drawing.Size(180, 56);
            btSave.TabIndex = 10;
            btSave.Text = "&Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btCancel
            // 
            btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btCancel.Location = new System.Drawing.Point(595, 503);
            btCancel.Name = "btCancel";
            btCancel.Size = new System.Drawing.Size(180, 56);
            btCancel.TabIndex = 11;
            btCancel.Text = "&Cancel";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(892, 713);
            Controls.Add(btCancel);
            Controls.Add(btSave);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "frmCarDetails";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.MaskedTextBox txtPrice;
        private System.Windows.Forms.MaskedTextBox txtReleaseYear;
        private System.Windows.Forms.ComboBox cboManufacturer;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btCancel;
    }
}
