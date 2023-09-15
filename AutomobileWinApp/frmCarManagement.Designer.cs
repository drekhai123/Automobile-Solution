namespace AutomobileWinApp
{
    partial class frmCarManagement
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
            lbCarID = new System.Windows.Forms.Label();
            lbCarName = new System.Windows.Forms.Label();
            lbManufacturer = new System.Windows.Forms.Label();
            lbReleaseYear = new System.Windows.Forms.Label();
            lbPrice = new System.Windows.Forms.Label();
            txtCarID = new System.Windows.Forms.TextBox();
            txtCarName = new System.Windows.Forms.TextBox();
            txtManufacturer = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtReleaseYear = new System.Windows.Forms.TextBox();
            btLoad = new System.Windows.Forms.Button();
            btNew = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            dgvCarList = new System.Windows.Forms.DataGridView();
            btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Location = new System.Drawing.Point(12, 53);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new System.Drawing.Size(85, 38);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new System.Drawing.Point(12, 113);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new System.Drawing.Size(140, 38);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new System.Drawing.Point(12, 170);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new System.Drawing.Size(184, 38);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new System.Drawing.Point(616, 109);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new System.Drawing.Size(171, 38);
            lbReleaseYear.TabIndex = 3;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new System.Drawing.Point(616, 46);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new System.Drawing.Size(78, 38);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Price";
            // 
            // txtCarID
            // 
            txtCarID.Location = new System.Drawing.Point(202, 46);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new System.Drawing.Size(403, 45);
            txtCarID.TabIndex = 5;
            // 
            // txtCarName
            // 
            txtCarName.Location = new System.Drawing.Point(202, 106);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new System.Drawing.Size(403, 45);
            txtCarName.TabIndex = 6;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new System.Drawing.Point(202, 170);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new System.Drawing.Size(403, 45);
            txtManufacturer.TabIndex = 7;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(793, 43);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(403, 45);
            txtPrice.TabIndex = 8;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new System.Drawing.Point(793, 109);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new System.Drawing.Size(403, 45);
            txtReleaseYear.TabIndex = 9;
            // 
            // btLoad
            // 
            btLoad.Location = new System.Drawing.Point(202, 243);
            btLoad.Name = "btLoad";
            btLoad.Size = new System.Drawing.Size(151, 68);
            btLoad.TabIndex = 10;
            btLoad.Text = "Load";
            btLoad.UseVisualStyleBackColor = true;
            btLoad.Click += btLoad_Click;
            // 
            // btNew
            // 
            btNew.Location = new System.Drawing.Point(543, 243);
            btNew.Name = "btNew";
            btNew.Size = new System.Drawing.Size(151, 68);
            btNew.TabIndex = 11;
            btNew.Text = "New";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new System.Drawing.Point(916, 243);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(151, 68);
            btDelete.TabIndex = 12;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new System.Drawing.Point(202, 357);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 62;
            dgvCarList.RowTemplate.Height = 33;
            dgvCarList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new System.Drawing.Size(994, 437);
            dgvCarList.TabIndex = 13;
            // 
            // btClose
            // 
            btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btClose.Location = new System.Drawing.Point(616, 800);
            btClose.Name = "btClose";
            btClose.Size = new System.Drawing.Size(152, 42);
            btClose.TabIndex = 14;
            btClose.Text = "Close";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 38F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1344, 872);
            Controls.Add(btClose);
            Controls.Add(dgvCarList);
            Controls.Add(btDelete);
            Controls.Add(btNew);
            Controls.Add(btLoad);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManufacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbPrice);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "frmCarManagement";
            Text = "frmCarManagement";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbCarID;
        private System.Windows.Forms.Label lbCarName;
        private System.Windows.Forms.Label lbManufacturer;
        private System.Windows.Forms.Label lbReleaseYear;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.TextBox txtCarID;
        private System.Windows.Forms.TextBox txtCarName;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtReleaseYear;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.DataGridView dgvCarList;
        private System.Windows.Forms.Button btClose;
    }
}