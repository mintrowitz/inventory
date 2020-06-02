namespace Inventory_System
{
    partial class AddPartForm
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
            this.InHouseRadio = new System.Windows.Forms.RadioButton();
            this.OutsourcedRadio = new System.Windows.Forms.RadioButton();
            this.AddPartLabel = new System.Windows.Forms.Label();
            this.PartIDLabel = new System.Windows.Forms.Label();
            this.PartNameLabel = new System.Windows.Forms.Label();
            this.PartInventoryLabel = new System.Windows.Forms.Label();
            this.PartPriceLabel = new System.Windows.Forms.Label();
            this.PartMaxLabel = new System.Windows.Forms.Label();
            this.PartMinLabel = new System.Windows.Forms.Label();
            this.CompanyMachineIDLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.inventoryTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.maxTextBox = new System.Windows.Forms.TextBox();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.companyMachineTextBox = new System.Windows.Forms.TextBox();
            this.PartSaveButton = new System.Windows.Forms.Button();
            this.PartCancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InHouseRadio
            // 
            this.InHouseRadio.AutoSize = true;
            this.InHouseRadio.Location = new System.Drawing.Point(96, 36);
            this.InHouseRadio.Name = "InHouseRadio";
            this.InHouseRadio.Size = new System.Drawing.Size(68, 17);
            this.InHouseRadio.TabIndex = 0;
            this.InHouseRadio.TabStop = true;
            this.InHouseRadio.Text = "In-House";
            this.InHouseRadio.UseVisualStyleBackColor = true;
            this.InHouseRadio.CheckedChanged += new System.EventHandler(this.InHouseRadio_CheckedChanged);
            // 
            // OutsourcedRadio
            // 
            this.OutsourcedRadio.AutoSize = true;
            this.OutsourcedRadio.Location = new System.Drawing.Point(167, 36);
            this.OutsourcedRadio.Name = "OutsourcedRadio";
            this.OutsourcedRadio.Size = new System.Drawing.Size(80, 17);
            this.OutsourcedRadio.TabIndex = 1;
            this.OutsourcedRadio.TabStop = true;
            this.OutsourcedRadio.Text = "Outsourced";
            this.OutsourcedRadio.UseVisualStyleBackColor = true;
            this.OutsourcedRadio.CheckedChanged += new System.EventHandler(this.OutsourcedRadio_CheckedChanged);
            // 
            // AddPartLabel
            // 
            this.AddPartLabel.AutoSize = true;
            this.AddPartLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartLabel.Location = new System.Drawing.Point(12, 9);
            this.AddPartLabel.Name = "AddPartLabel";
            this.AddPartLabel.Size = new System.Drawing.Size(76, 21);
            this.AddPartLabel.TabIndex = 2;
            this.AddPartLabel.Text = "Add Part";
            // 
            // PartIDLabel
            // 
            this.PartIDLabel.AutoSize = true;
            this.PartIDLabel.Location = new System.Drawing.Point(83, 81);
            this.PartIDLabel.Name = "PartIDLabel";
            this.PartIDLabel.Size = new System.Drawing.Size(18, 13);
            this.PartIDLabel.TabIndex = 3;
            this.PartIDLabel.Text = "ID";
            this.PartIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartNameLabel
            // 
            this.PartNameLabel.AutoSize = true;
            this.PartNameLabel.Location = new System.Drawing.Point(66, 111);
            this.PartNameLabel.Name = "PartNameLabel";
            this.PartNameLabel.Size = new System.Drawing.Size(35, 13);
            this.PartNameLabel.TabIndex = 4;
            this.PartNameLabel.Text = "Name";
            this.PartNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartInventoryLabel
            // 
            this.PartInventoryLabel.AutoSize = true;
            this.PartInventoryLabel.Location = new System.Drawing.Point(50, 143);
            this.PartInventoryLabel.Name = "PartInventoryLabel";
            this.PartInventoryLabel.Size = new System.Drawing.Size(51, 13);
            this.PartInventoryLabel.TabIndex = 5;
            this.PartInventoryLabel.Text = "Inventory";
            this.PartInventoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartPriceLabel
            // 
            this.PartPriceLabel.AutoSize = true;
            this.PartPriceLabel.Location = new System.Drawing.Point(70, 181);
            this.PartPriceLabel.Name = "PartPriceLabel";
            this.PartPriceLabel.Size = new System.Drawing.Size(31, 13);
            this.PartPriceLabel.TabIndex = 6;
            this.PartPriceLabel.Text = "Price";
            this.PartPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PartMaxLabel
            // 
            this.PartMaxLabel.AutoSize = true;
            this.PartMaxLabel.Location = new System.Drawing.Point(185, 223);
            this.PartMaxLabel.Name = "PartMaxLabel";
            this.PartMaxLabel.Size = new System.Drawing.Size(27, 13);
            this.PartMaxLabel.TabIndex = 7;
            this.PartMaxLabel.Text = "Max";
            // 
            // PartMinLabel
            // 
            this.PartMinLabel.AutoSize = true;
            this.PartMinLabel.Location = new System.Drawing.Point(121, 223);
            this.PartMinLabel.Name = "PartMinLabel";
            this.PartMinLabel.Size = new System.Drawing.Size(24, 13);
            this.PartMinLabel.TabIndex = 8;
            this.PartMinLabel.Text = "Min";
            // 
            // CompanyMachineIDLabel
            // 
            this.CompanyMachineIDLabel.Location = new System.Drawing.Point(11, 263);
            this.CompanyMachineIDLabel.Name = "CompanyMachineIDLabel";
            this.CompanyMachineIDLabel.Size = new System.Drawing.Size(90, 13);
            this.CompanyMachineIDLabel.TabIndex = 9;
            this.CompanyMachineIDLabel.Text = "Machine ID";
            this.CompanyMachineIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(122, 78);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(125, 20);
            this.idTextBox.TabIndex = 10;
            this.idTextBox.TabStop = false;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(122, 108);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(125, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // inventoryTextBox
            // 
            this.inventoryTextBox.Location = new System.Drawing.Point(122, 140);
            this.inventoryTextBox.Name = "inventoryTextBox";
            this.inventoryTextBox.Size = new System.Drawing.Size(125, 20);
            this.inventoryTextBox.TabIndex = 12;
            this.inventoryTextBox.TextChanged += new System.EventHandler(this.inventoryTextBox_TextChanged);
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(122, 178);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(125, 20);
            this.priceTextBox.TabIndex = 13;
            this.priceTextBox.TextChanged += new System.EventHandler(this.priceTextBox_TextChanged);
            // 
            // maxTextBox
            // 
            this.maxTextBox.Location = new System.Drawing.Point(212, 220);
            this.maxTextBox.Name = "maxTextBox";
            this.maxTextBox.Size = new System.Drawing.Size(35, 20);
            this.maxTextBox.TabIndex = 15;
            this.maxTextBox.TextChanged += new System.EventHandler(this.maxTextBox_TextChanged);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(144, 220);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.Size = new System.Drawing.Size(35, 20);
            this.minTextBox.TabIndex = 14;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // companyMachineTextBox
            // 
            this.companyMachineTextBox.Location = new System.Drawing.Point(122, 260);
            this.companyMachineTextBox.Name = "companyMachineTextBox";
            this.companyMachineTextBox.Size = new System.Drawing.Size(125, 20);
            this.companyMachineTextBox.TabIndex = 16;
            this.companyMachineTextBox.TextChanged += new System.EventHandler(this.companyMachineTextBox_TextChanged);
            // 
            // PartSaveButton
            // 
            this.PartSaveButton.Location = new System.Drawing.Point(105, 314);
            this.PartSaveButton.Name = "PartSaveButton";
            this.PartSaveButton.Size = new System.Drawing.Size(59, 31);
            this.PartSaveButton.TabIndex = 17;
            this.PartSaveButton.Text = "Save";
            this.PartSaveButton.UseVisualStyleBackColor = true;
            this.PartSaveButton.Click += new System.EventHandler(this.PartSaveButton_Click);
            // 
            // PartCancelButton
            // 
            this.PartCancelButton.Location = new System.Drawing.Point(188, 314);
            this.PartCancelButton.Name = "PartCancelButton";
            this.PartCancelButton.Size = new System.Drawing.Size(59, 31);
            this.PartCancelButton.TabIndex = 18;
            this.PartCancelButton.Text = "Cancel";
            this.PartCancelButton.UseVisualStyleBackColor = true;
            this.PartCancelButton.Click += new System.EventHandler(this.PartCancelButton_Click);
            // 
            // AddPartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(264, 361);
            this.Controls.Add(this.PartCancelButton);
            this.Controls.Add(this.PartSaveButton);
            this.Controls.Add(this.companyMachineTextBox);
            this.Controls.Add(this.minTextBox);
            this.Controls.Add(this.maxTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.inventoryTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.CompanyMachineIDLabel);
            this.Controls.Add(this.PartMinLabel);
            this.Controls.Add(this.PartMaxLabel);
            this.Controls.Add(this.PartPriceLabel);
            this.Controls.Add(this.PartInventoryLabel);
            this.Controls.Add(this.PartNameLabel);
            this.Controls.Add(this.PartIDLabel);
            this.Controls.Add(this.AddPartLabel);
            this.Controls.Add(this.OutsourcedRadio);
            this.Controls.Add(this.InHouseRadio);
            this.Name = "AddPartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton InHouseRadio;
        private System.Windows.Forms.RadioButton OutsourcedRadio;
        private System.Windows.Forms.Label AddPartLabel;
        private System.Windows.Forms.Label PartIDLabel;
        private System.Windows.Forms.Label PartNameLabel;
        private System.Windows.Forms.Label PartInventoryLabel;
        private System.Windows.Forms.Label PartPriceLabel;
        private System.Windows.Forms.Label PartMaxLabel;
        private System.Windows.Forms.Label PartMinLabel;
        private System.Windows.Forms.Label CompanyMachineIDLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox inventoryTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox maxTextBox;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox companyMachineTextBox;
        private System.Windows.Forms.Button PartSaveButton;
        private System.Windows.Forms.Button PartCancelButton;

        public int AddPartIDBoxText
        {
            get { return int.Parse(idTextBox.Text); }
            set { idTextBox.Text = value.ToString(); }
        }
        public string AddPartNameBoxText
        {
            get { return nameTextBox.Text; }
            set { nameTextBox.Text = value; }
        }
        public int AddPartInvBoxText
        {
            get { return int.Parse(inventoryTextBox.Text); }
            set { inventoryTextBox.Text = value.ToString(); }
        }
        public decimal AddPartPriceBoxText
        {
            get { return decimal.Parse(priceTextBox.Text); }
            set { priceTextBox.Text = value.ToString(); }
        }
        public int AddPartMaxBoxText
        {
            get { return int.Parse(maxTextBox.Text); }
            set { maxTextBox.Text = value.ToString(); }
        }
        public int AddPartMinBoxText
        {
            get { return int.Parse(minTextBox.Text); }
            set { minTextBox.Text = value.ToString(); }
        }

        public string AddPartMachComBoxText
        {
            get { return companyMachineTextBox.Text; }
            set { companyMachineTextBox.Text = value; }
        }


    }
}