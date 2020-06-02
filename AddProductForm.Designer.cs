namespace Inventory_System
{
    partial class AddProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.PartMinLabel = new System.Windows.Forms.Label();
            this.PartMaxLabel = new System.Windows.Forms.Label();
            this.PartPriceLabel = new System.Windows.Forms.Label();
            this.PartInventoryLabel = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartIDLabel = new System.Windows.Forms.Label();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.allPartsGridView = new System.Windows.Forms.DataGridView();
            this.selectedPartsGridView = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.CandidatePartsLabel = new System.Windows.Forms.Label();
            this.AssociatedPartsLabel = new System.Windows.Forms.Label();
            this.Delete = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.searchBoxText = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPartsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(116, 243);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(35, 20);
            this.minTextBox.TabIndex = 28;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(184, 243);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(35, 20);
            this.maxTextBox.TabIndex = 29;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(94, 201);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 20);
            this.priceTextBox.TabIndex = 27;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(94, 158);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(125, 20);
            this.inventoryTextBox.TabIndex = 26;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(94, 115);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameTextBox.TabIndex = 25;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(94, 77);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(125, 20);
            this.idTextBox.TabIndex = 24;
            this.idTextBox.TabStop = false;
            // 
            // PartMinLabel
            // 
            this.PartMinLabel.AutoSize = true;
            this.PartMinLabel.Location = new System.Drawing.Point(93, 246);
            this.PartMinLabel.Name = "PartMinLabel";
            this.PartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.PartMinLabel.TabIndex = 22;
            this.PartMinLabel.Text = "Min";
            // 
            // PartMaxLabel
            // 
            this.PartMaxLabel.AutoSize = true;
            this.PartMaxLabel.Location = new System.Drawing.Point(157, 246);
            this.PartMaxLabel.Name = "PartMaxLabel";
            this.PartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.PartMaxLabel.TabIndex = 21;
            this.PartMaxLabel.Text = "Max";
            // 
            // PartPriceLabel
            // 
            this.PartPriceLabel.AutoSize = true;
            this.PartPriceLabel.Location = new System.Drawing.Point(42, 204);
            this.PartPriceLabel.Name = "PartPriceLabel";
            this.PartPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PartPriceLabel.TabIndex = 20;
            this.PartPriceLabel.Text = "Price";
            this.PartPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartInventoryLabel
            // 
            this.PartInventoryLabel.AutoSize = true;
            this.PartInventoryLabel.Location = new System.Drawing.Point(22, 161);
            this.PartInventoryLabel.Name = "PartInventoryLabel";
            this.PartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.PartInventoryLabel.TabIndex = 19;
            this.PartInventoryLabel.Text = "Inventory";
            this.PartInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Location = new System.Drawing.Point(38, 118);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PartNameLabel.TabIndex = 18;
            this.PartNameLabel.Text = "Name";
            this.PartNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartIDLabel
            // 
            this.PartIDLabel.AutoSize = true;
            this.PartIDLabel.Location = new System.Drawing.Point(55, 80);
            this.PartIDLabel.Name = "PartIDLabel";
            this.PartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.PartIDLabel.TabIndex = 17;
            this.PartIDLabel.Text = "ID";
            this.PartIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(12, 9);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(105, 21);
            this.AddProductLabel.TabIndex = 30;
            this.AddProductLabel.Text = "Add Product";
            // 
            // allPartsGridView
            // 
            this.allPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allPartsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.allPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allPartsGridView.Location = new System.Drawing.Point(272, 60);
            this.allPartsGridView.MultiSelect = false;
            this.allPartsGridView.Name = "allPartsGridView";
            this.allPartsGridView.ReadOnly = true;
            this.allPartsGridView.RowHeadersVisible = false;
            this.allPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allPartsGridView.Size = new System.Drawing.Size(516, 129);
            this.allPartsGridView.TabIndex = 31;
            // 
            // selectedPartsGridView
            // 
            this.selectedPartsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.selectedPartsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.selectedPartsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedPartsGridView.Location = new System.Drawing.Point(272, 243);
            this.selectedPartsGridView.MultiSelect = false;
            this.selectedPartsGridView.Name = "selectedPartsGridView";
            this.selectedPartsGridView.ReadOnly = true;
            this.selectedPartsGridView.RowHeadersVisible = false;
            this.selectedPartsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.selectedPartsGridView.Size = new System.Drawing.Size(515, 84);
            this.selectedPartsGridView.TabIndex = 32;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(728, 195);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(60, 30);
            this.AddProductButton.TabIndex = 33;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CandidatePartsLabel
            // 
            this.CandidatePartsLabel.AutoSize = true;
            this.CandidatePartsLabel.Location = new System.Drawing.Point(269, 44);
            this.CandidatePartsLabel.Name = "CandidatePartsLabel";
            this.CandidatePartsLabel.Size = new System.Drawing.Size(96, 13);
            this.CandidatePartsLabel.TabIndex = 34;
            this.CandidatePartsLabel.Text = "All Candidate Parts";
            // 
            // AssociatedPartsLabel
            // 
            this.AssociatedPartsLabel.AutoSize = true;
            this.AssociatedPartsLabel.Location = new System.Drawing.Point(269, 227);
            this.AssociatedPartsLabel.Name = "AssociatedPartsLabel";
            this.AssociatedPartsLabel.Size = new System.Drawing.Size(167, 13);
            this.AssociatedPartsLabel.TabIndex = 35;
            this.AssociatedPartsLabel.Text = "Parts Associated with this Product";
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(728, 333);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(60, 30);
            this.Delete.TabIndex = 36;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(727, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(60, 30);
            this.CancelButton.TabIndex = 37;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(661, 389);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(60, 30);
            this.SaveButton.TabIndex = 38;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // searchBoxText
            // 
            this.searchBoxText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBoxText.Location = new System.Drawing.Point(546, 16);
            this.searchBoxText.Name = "searchBoxText";
            this.searchBoxText.Size = new System.Drawing.Size(241, 25);
            this.searchBoxText.TabIndex = 39;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(480, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(60, 25);
            this.SearchButton.TabIndex = 40;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(800, 430);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.searchBoxText);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.AssociatedPartsLabel);
            this.Controls.Add(this.CandidatePartsLabel);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.selectedPartsGridView);
            this.Controls.Add(this.allPartsGridView);
            this.Controls.Add(this.AddProductLabel);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.PartMinLabel);
            this.Controls.Add(this.PartMaxLabel);
            this.Controls.Add(this.PartPriceLabel);
            this.Controls.Add(this.PartInventoryLabel);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.PartIDLabel);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add New Product";
            ((System.ComponentModel.ISupportInitialize)(this.allPartsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedPartsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label PartMinLabel;
        private System.Windows.Forms.Label PartMaxLabel;
        private System.Windows.Forms.Label PartPriceLabel;
        private System.Windows.Forms.Label PartInventoryLabel;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Label PartIDLabel;
        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.DataGridView allPartsGridView;
        private System.Windows.Forms.DataGridView selectedPartsGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Label CandidatePartsLabel;
        private System.Windows.Forms.Label AssociatedPartsLabel;
        private System.Windows.Forms.Button Delete;
        private new System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox searchBoxText;
        private System.Windows.Forms.Button SearchButton;

        public int AddProductIDBoxText
        {
            get { return int.Parse(idTextBox.Text); }
            set { idTextBox.Text = value.ToString(); }
        }
        public string AddProductNameBoxText
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }
        public int AddProductInvBoxText
        {
            get { return int.Parse(inventoryTextBox.Text); }
            set { inventoryTextBox.Text = value.ToString(); }
        }
        public decimal AddProductPriceBoxText
        {
            get { return decimal.Parse(priceTextBox.Text); }
            set { priceTextBox.Text = value.ToString(); }
        }
        public int AddProductMinBoxText
        {
            get { return int.Parse(minTextBox.Text); }
            set { minTextBox.Text = value.ToString(); }
        }
        public int AddProductMaxBoxText
        {
            get { return int.Parse(maxTextBox.Text); }
            set { maxTextBox.Text = value.ToString(); }
        }
    }
}