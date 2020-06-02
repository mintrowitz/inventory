using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class ModProductForm : Form
    {
        Main MainForm = (Main)Application.OpenForms["Main"];
        BindingList<Part> modSelectedParts = new BindingList<Part>();


        public ModProductForm(Product product)
        {
            InitializeComponent();

            ModProductIDBoxText = product.ProductID;
            ModProductNameBoxText = product.Name;
            ModProductInvBoxText = product.InStock;
            ModProductPriceBoxText = product.Price;
            ModProductMinBoxText = product.Min;
            ModProductMaxBoxText = product.Max;

            foreach (Part part in product.associatedParts)
            {
                modSelectedParts.Add(part);
            }

            var associatedpartsBS = new BindingSource
            {
                DataSource = modSelectedParts
            };
            selectedPartsGridView.DataSource = associatedpartsBS;

            var allpartsBS = new BindingSource
            {
                DataSource = Inventory.allParts
            };
            allPartsGridView.DataSource = allpartsBS;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text) || String.IsNullOrEmpty(inventoryTextBox.Text)
                || String.IsNullOrEmpty(minTextBox.Text) || String.IsNullOrEmpty(maxTextBox.Text))
            {
                MessageBox.Show("All fields must have a value. Please update and try saving again.");
                return;
            }

            if (ModProductMaxBoxText < ModProductMinBoxText)
            {
                MessageBox.Show("This product's maximum value is currently lower than the minimum value. Please update and retry.");
                return;
            }

            if (Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory value must not be less than minimum or greater than maximum. Please update and try saving again.");
                return;
            }

            else
            {
                Product product = new Product(ModProductIDBoxText, ModProductNameBoxText, ModProductPriceBoxText, ModProductInvBoxText, ModProductMinBoxText, ModProductMaxBoxText);

                foreach (Part part in modSelectedParts)
                {
                    product.associatedParts.Add(part);
                }

                Inventory.UpdateProduct(ModProductIDBoxText, product);
                this.Close();
            }

            MainForm.RefreshProducts();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult deleteAnswer = MessageBox.Show("Are you sure you want to delete the association between this product and part?", "Remove Part", MessageBoxButtons.YesNo);

            if (deleteAnswer == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in selectedPartsGridView.SelectedRows)
                {
                    selectedPartsGridView.Rows.RemoveAt(row.Index);
                }
            }
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)allPartsGridView.CurrentRow.DataBoundItem;
            modSelectedParts.Add(selectedPart);
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(inventoryTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter an integer value in the inventory field.");
                return;
            }
        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal temp = Convert.ToDecimal(priceTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter a decimal value in the price field.");
                return;
            }
        }

        private void minTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(minTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter an integer value in the minimum field.");
                return;
            }
        }

        private void maxTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int temp = Convert.ToInt32(maxTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Please enter an integer value in the maximum field.");
                return;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchBoxText.Text))
            {
                return;
            }

            Part part = Inventory.SearchParts(searchBoxText.Text);

            if (part == null)
            {
                MessageBox.Show("Sorry, a part matching that name was not found.");
                return;
            }

            foreach (DataGridViewRow row in allPartsGridView.Rows)
            {
                Part matchedPart = (Part)row.DataBoundItem;

                if (matchedPart.Name.ToUpper() == part.Name.ToUpper())
                {
                    row.Selected = true;
                    break;
                }

            }
        }
    }
}
