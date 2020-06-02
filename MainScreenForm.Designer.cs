namespace Inventory_System
{
    partial class Main
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
            this.Exit = new System.Windows.Forms.Button();
            this.ProductDelete = new System.Windows.Forms.Button();
            this.ProductModify = new System.Windows.Forms.Button();
            this.ProductAdd = new System.Windows.Forms.Button();
            this.PartAdd = new System.Windows.Forms.Button();
            this.PartModify = new System.Windows.Forms.Button();
            this.PartDelete = new System.Windows.Forms.Button();
            this.PartSearch = new System.Windows.Forms.Button();
            this.ProductSearch = new System.Windows.Forms.Button();
            this.partSearchBox = new System.Windows.Forms.TextBox();
            this.productSearchBox = new System.Windows.Forms.TextBox();
            this.MainTitle = new System.Windows.Forms.Label();
            this.PartsLabel = new System.Windows.Forms.Label();
            this.ProductsLabel = new System.Windows.Forms.Label();
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.partDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(811, 339);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(55, 30);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ProductDelete
            // 
            this.ProductDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDelete.Location = new System.Drawing.Point(811, 288);
            this.ProductDelete.Name = "ProductDelete";
            this.ProductDelete.Size = new System.Drawing.Size(55, 30);
            this.ProductDelete.TabIndex = 1;
            this.ProductDelete.Text = "Delete";
            this.ProductDelete.UseVisualStyleBackColor = true;
            this.ProductDelete.Click += new System.EventHandler(this.ProductDelete_Click);
            // 
            // ProductModify
            // 
            this.ProductModify.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductModify.Location = new System.Drawing.Point(750, 288);
            this.ProductModify.Name = "ProductModify";
            this.ProductModify.Size = new System.Drawing.Size(55, 30);
            this.ProductModify.TabIndex = 2;
            this.ProductModify.Text = "Modify";
            this.ProductModify.UseVisualStyleBackColor = true;
            this.ProductModify.Click += new System.EventHandler(this.ProductModify_Click);
            // 
            // ProductAdd
            // 
            this.ProductAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductAdd.Location = new System.Drawing.Point(689, 288);
            this.ProductAdd.Name = "ProductAdd";
            this.ProductAdd.Size = new System.Drawing.Size(55, 30);
            this.ProductAdd.TabIndex = 3;
            this.ProductAdd.Text = "Add";
            this.ProductAdd.UseVisualStyleBackColor = true;
            this.ProductAdd.Click += new System.EventHandler(this.ProductAdd_Click);
            // 
            // PartAdd
            // 
            this.PartAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartAdd.Location = new System.Drawing.Point(226, 288);
            this.PartAdd.Name = "PartAdd";
            this.PartAdd.Size = new System.Drawing.Size(55, 30);
            this.PartAdd.TabIndex = 6;
            this.PartAdd.Text = "Add";
            this.PartAdd.UseVisualStyleBackColor = true;
            this.PartAdd.Click += new System.EventHandler(this.PartAdd_Click);
            // 
            // PartModify
            // 
            this.PartModify.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartModify.Location = new System.Drawing.Point(287, 288);
            this.PartModify.Name = "PartModify";
            this.PartModify.Size = new System.Drawing.Size(55, 30);
            this.PartModify.TabIndex = 5;
            this.PartModify.Text = "Modify";
            this.PartModify.UseVisualStyleBackColor = true;
            this.PartModify.Click += new System.EventHandler(this.PartModify_Click);
            // 
            // PartDelete
            // 
            this.PartDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDelete.Location = new System.Drawing.Point(348, 288);
            this.PartDelete.Name = "PartDelete";
            this.PartDelete.Size = new System.Drawing.Size(55, 30);
            this.PartDelete.TabIndex = 4;
            this.PartDelete.Text = "Delete";
            this.PartDelete.UseVisualStyleBackColor = true;
            this.PartDelete.Click += new System.EventHandler(this.PartDelete_Click);
            // 
            // PartSearch
            // 
            this.PartSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearch.Location = new System.Drawing.Point(164, 49);
            this.PartSearch.Name = "PartSearch";
            this.PartSearch.Size = new System.Drawing.Size(63, 26);
            this.PartSearch.TabIndex = 7;
            this.PartSearch.Text = "Search";
            this.PartSearch.UseVisualStyleBackColor = true;
            this.PartSearch.Click += new System.EventHandler(this.PartSearch_Click);
            // 
            // ProductSearch
            // 
            this.ProductSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSearch.Location = new System.Drawing.Point(630, 49);
            this.ProductSearch.Name = "ProductSearch";
            this.ProductSearch.Size = new System.Drawing.Size(63, 26);
            this.ProductSearch.TabIndex = 8;
            this.ProductSearch.Text = "Search";
            this.ProductSearch.UseVisualStyleBackColor = true;
            this.ProductSearch.Click += new System.EventHandler(this.ProductSearch_Click);
            // 
            // partSearchBox
            // 
            this.partSearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partSearchBox.Location = new System.Drawing.Point(232, 49);
            this.partSearchBox.Name = "partSearchBox";
            this.partSearchBox.Size = new System.Drawing.Size(166, 25);
            this.partSearchBox.TabIndex = 9;
            // 
            // productSearchBox
            // 
            this.productSearchBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productSearchBox.Location = new System.Drawing.Point(699, 49);
            this.productSearchBox.Name = "productSearchBox";
            this.productSearchBox.Size = new System.Drawing.Size(166, 25);
            this.productSearchBox.TabIndex = 10;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTitle.Location = new System.Drawing.Point(11, 8);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(250, 21);
            this.MainTitle.TabIndex = 13;
            this.MainTitle.Text = "Inventory Management System";
            // 
            // PartsLabel
            // 
            this.PartsLabel.AutoSize = true;
            this.PartsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartsLabel.Location = new System.Drawing.Point(13, 55);
            this.PartsLabel.Name = "PartsLabel";
            this.PartsLabel.Size = new System.Drawing.Size(48, 21);
            this.PartsLabel.TabIndex = 14;
            this.PartsLabel.Text = "Parts";
            // 
            // ProductsLabel
            // 
            this.ProductsLabel.AutoSize = true;
            this.ProductsLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductsLabel.Location = new System.Drawing.Point(480, 55);
            this.ProductsLabel.Name = "ProductsLabel";
            this.ProductsLabel.Size = new System.Drawing.Size(77, 21);
            this.ProductsLabel.TabIndex = 15;
            this.ProductsLabel.Text = "Products";
            // 
            // productDataGridView
            // 
            this.productDataGridView.AllowUserToAddRows = false;
            this.productDataGridView.AllowUserToDeleteRows = false;
            this.productDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.productDataGridView.Location = new System.Drawing.Point(484, 81);
            this.productDataGridView.MultiSelect = false;
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.ReadOnly = true;
            this.productDataGridView.RowHeadersVisible = false;
            this.productDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDataGridView.Size = new System.Drawing.Size(381, 189);
            this.productDataGridView.TabIndex = 16;
            // 
            // partDataGridView
            // 
            this.partDataGridView.AllowUserToAddRows = false;
            this.partDataGridView.AllowUserToDeleteRows = false;
            this.partDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partDataGridView.Location = new System.Drawing.Point(17, 81);
            this.partDataGridView.MultiSelect = false;
            this.partDataGridView.Name = "partDataGridView";
            this.partDataGridView.ReadOnly = true;
            this.partDataGridView.RowHeadersVisible = false;
            this.partDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDataGridView.Size = new System.Drawing.Size(381, 189);
            this.partDataGridView.TabIndex = 17;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(878, 382);
            this.Controls.Add(this.partDataGridView);
            this.Controls.Add(this.productDataGridView);
            this.Controls.Add(this.ProductsLabel);
            this.Controls.Add(this.PartsLabel);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.productSearchBox);
            this.Controls.Add(this.partSearchBox);
            this.Controls.Add(this.ProductSearch);
            this.Controls.Add(this.PartSearch);
            this.Controls.Add(this.PartAdd);
            this.Controls.Add(this.PartModify);
            this.Controls.Add(this.PartDelete);
            this.Controls.Add(this.ProductAdd);
            this.Controls.Add(this.ProductModify);
            this.Controls.Add(this.ProductDelete);
            this.Controls.Add(this.Exit);
            this.Name = "Main";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button ProductDelete;
        private System.Windows.Forms.Button ProductModify;
        private System.Windows.Forms.Button ProductAdd;
        private System.Windows.Forms.Button PartAdd;
        private System.Windows.Forms.Button PartModify;
        private System.Windows.Forms.Button PartDelete;
        private System.Windows.Forms.Button PartSearch;
        private System.Windows.Forms.Button ProductSearch;
        private System.Windows.Forms.TextBox partSearchBox;
        private System.Windows.Forms.TextBox productSearchBox;
        private System.Windows.Forms.Label MainTitle;
        private System.Windows.Forms.Label PartsLabel;
        private System.Windows.Forms.Label ProductsLabel;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.DataGridView partDataGridView;


    }
}

