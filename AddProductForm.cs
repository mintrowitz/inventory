using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddProductForm : Form
    {
        BindingList<Part> selectedParts = new BindingList<Part>();

        public AddProductForm()
        {
            InitializeComponent();
            ComponentParts();
            AddProductIDBoxText = Inventory.products.Count + 1;
        }

        public void ComponentParts()
        {
            var allparts = new BindingSource();
            allparts.DataSource = Inventory.allParts;
            allPartsGridView.DataSource = allparts;


            var selectedparts = new BindingSource();
            selectedparts.DataSource = selectedParts;
            selectedPartsGridView.DataSource = selectedparts;
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

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            Part selectedPart = (Part)allPartsGridView.CurrentRow.DataBoundItem;
            selectedParts.Add(selectedPart);


        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text) || String.IsNullOrEmpty(inventoryTextBox.Text)
                || String.IsNullOrEmpty(minTextBox.Text) || String.IsNullOrEmpty(maxTextBox.Text))
            {
                MessageBox.Show("All fields must have a value. Please update and try saving again.");
                return;
            }

            if (AddProductMinBoxText > AddProductMaxBoxText)
            {
                MessageBox.Show("Your minimum value cannot be higher than your maximum value. Please enter a different value.");
            }

            if (Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory value must not be less than minimum or greater than maximum. Please update and try saving again.");
                return;
            }

            else
            {
                Product newProduct = new Product(Inventory.products.Count + 1, AddProductNameBoxText, AddProductPriceBoxText, AddProductInvBoxText, AddProductMinBoxText, AddProductMaxBoxText);
                Inventory.products.Add(newProduct);

                foreach (Part part in selectedParts)
                {
                    newProduct.AddAssociatedPart(part);
                }
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal temp = Convert.ToDecimal(inventoryTextBox.Text);
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
    }
}
