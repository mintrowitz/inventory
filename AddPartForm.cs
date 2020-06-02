using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class AddPartForm : Form
    {
        public AddPartForm()
        {
            InitializeComponent();
            AddPartIDBoxText = Inventory.allParts.Count + 1;
        }

        //Changing label for last field, dependent on inhouse/outsourced radio option
        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineIDLabel.Text = "Machine ID";
        }
        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineIDLabel.Text = "Company Name";
        }

        //Closes addpartform if cancel button is clicked
        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Saves all entered fields as a new inhouse/outsourced part object, dependent on inhouse/outsourced radio option
        private void PartSaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text) || String.IsNullOrEmpty(inventoryTextBox.Text) || String.IsNullOrEmpty(minTextBox.Text)
                || String.IsNullOrEmpty(maxTextBox.Text) || String.IsNullOrEmpty(companyMachineTextBox.Text))
            {
                MessageBox.Show("All fields must have a value. Please update and try saving again.");
                return;
            }

            if (AddPartMinBoxText > AddPartMaxBoxText)
            {
                MessageBox.Show("Your minimum value cannot be higher than your maximum value. Please enter a different value.");
                return;
            }

            if (Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory value must not be less than minimum or greater than maximum. Please update and try saving again.");
                return;
            }

            else if (InHouseRadio.Checked)
            {
                Inhouse inHousePart = new Inhouse(Inventory.allParts.Count + 1, AddPartNameBoxText, AddPartPriceBoxText, AddPartInvBoxText, AddPartMinBoxText, AddPartMaxBoxText, int.Parse(AddPartMachComBoxText));
                Inventory.allParts.Add(inHousePart);
                this.Close();
            }

            else
            {
                Outsourced outsourcedPart = new Outsourced(Inventory.allParts.Count + 1, AddPartNameBoxText, AddPartPriceBoxText, AddPartInvBoxText, AddPartMinBoxText, AddPartMaxBoxText, AddPartMachComBoxText);
                Inventory.allParts.Add(outsourcedPart);
                this.Close();

            }
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

        private void companyMachineTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CompanyMachineIDLabel.Text == "Machine ID")
            {
                try
                {
                    int temp = Convert.ToInt32(companyMachineTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter an integer value in the machine ID field.");
                    return;
                }
            }
        }


    }
}
