using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            ProductDataGridDisplay();
        }

        public void ProductDataGridDisplay()
        {
            partDataGridView.Rows.Clear();
            productDataGridView.Rows.Clear();
            Inventory.PopulateSampleLists();
            var productsBS = new BindingSource
            {
                DataSource = Inventory.products
            };
            productDataGridView.DataSource = productsBS;

            var partsBS = new BindingSource
            {
                DataSource = Inventory.allParts
            };
            partDataGridView.DataSource = partsBS;
        }

        private void PartAdd_Click(object sender, EventArgs e)
        {
            new AddPartForm().ShowDialog();
        }

        private void PartModify_Click(object sender, EventArgs e)
        {
            if (partDataGridView.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse inPart = (Inhouse)partDataGridView.CurrentRow.DataBoundItem;
                new ModPartForm(inPart).ShowDialog();
            }
            else
            {
                Outsourced outPart = (Outsourced)partDataGridView.CurrentRow.DataBoundItem;
                new ModPartForm(outPart).ShowDialog();
            }
        }

        private void PartDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteAnswer = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);

            if (deleteAnswer == DialogResult.Yes)
            {
                Part part = (Part)partDataGridView.CurrentRow.DataBoundItem;
                Inventory.DeletePart(part);
            }
        }


        private void PartSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(partSearchBox.Text))
            {
                return;
            }

            Part part = Inventory.SearchParts(partSearchBox.Text);

            if (part == null)
            {
                MessageBox.Show("Sorry, a part matching that name was not found.");
                return;
            }

            foreach (DataGridViewRow row in partDataGridView.Rows)
            {
                Part matchedPart = (Part)row.DataBoundItem;

                if (matchedPart.Name.ToUpper() == part.Name.ToUpper())
                {
                    row.Selected = true;
                    break;
                }

            }
        }

        private void ProductAdd_Click(object sender, EventArgs e)
        {
            new AddProductForm().ShowDialog();
        }

        private void ProductModify_Click(object sender, EventArgs e)
        {
            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            new ModProductForm(product).ShowDialog();
        }

        private void ProductDelete_Click(object sender, EventArgs e)
        {
            Product product = (Product)productDataGridView.CurrentRow.DataBoundItem;
            if (product.associatedParts.Count > 0)
            {
                MessageBox.Show("A product cannot be deleted until all associated parts have been removed. Please modify this product to remove all parts, then try again.", "Product cannot be deleted");
                return;
            }

            DialogResult deleteAnswer = MessageBox.Show("Are you sure you want to delete this product?", "Delete Product", MessageBoxButtons.YesNo);

            if (deleteAnswer == DialogResult.Yes)
            {
                Inventory.RemoveProduct(product);
            }
        }

        public void RefreshParts()
        {
            var partsBS = new BindingSource
            {
                DataSource = Inventory.allParts.OrderBy(x => x.PartID).ToList()
            };
            partDataGridView.DataSource = partsBS;
        }

        public void RefreshProducts()
        {
            var productsBS = new BindingSource
            {
                DataSource = Inventory.products
            };
            productDataGridView.DataSource = productsBS;
        }

        private void ProductSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(productSearchBox.Text))
            {
                return;
            }

            Product product = Inventory.SearchProducts(productSearchBox.Text);

            if (product == null)
            {
                MessageBox.Show("Sorry, a product matching that name was not found.");
                return;
            }

            foreach (DataGridViewRow row in productDataGridView.Rows)
            {
                Product matchedProduct = (Product)row.DataBoundItem;

                if (matchedProduct.Name.ToUpper() == product.Name.ToUpper())
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
