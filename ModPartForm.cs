using System;
using System.Windows.Forms;

namespace Inventory_System
{
    public partial class ModPartForm : Form
    {
        Main MainForm = (Main)Application.OpenForms["Main"];

        public ModPartForm(Inhouse inPart)
        {
            InitializeComponent();

            ModPartIDBoxText = inPart.PartID;
            ModPartNameBoxText = inPart.Name;
            ModPartInvBoxText = inPart.InStock;
            ModPartPriceBoxText = inPart.Price;
            ModPartMinBoxText = inPart.Min;
            ModPartMaxBoxText = inPart.Max;
            ModPartMachComBoxText = inPart.MachineID.ToString();

            InHouseRadio.Checked = true;
        }
        public ModPartForm(Outsourced outPart)
        {
            InitializeComponent();

            ModPartIDBoxText = outPart.PartID;
            ModPartNameBoxText = outPart.Name;
            ModPartInvBoxText = outPart.InStock;
            ModPartPriceBoxText = outPart.Price;
            ModPartMinBoxText = outPart.Min;
            ModPartMaxBoxText = outPart.Max;
            ModPartMachComBoxText = outPart.CompanyName;

            OutsourcedRadio.Checked = true;
        }

        private void InHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineIDLabel.Text = "Machine ID";
        }

        private void OutsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            CompanyMachineIDLabel.Text = "Company Name";
        }

        private void PartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PartSaveButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nameTextBox.Text) || String.IsNullOrEmpty(priceTextBox.Text) || String.IsNullOrEmpty(inventoryTextBox.Text) || String.IsNullOrEmpty(minTextBox.Text)
             || String.IsNullOrEmpty(maxTextBox.Text) || String.IsNullOrEmpty(machineIDTextBox.Text))
            {
                MessageBox.Show("All fields must have a value. Please update and try saving again.");
                return;
            }

            if (ModPartMaxBoxText < ModPartMinBoxText)
            {
                MessageBox.Show("This part's minimum value is currently higher than the maximum value. Please update and retry.");
            }

            if (Convert.ToInt32(inventoryTextBox.Text) < Convert.ToInt32(minTextBox.Text) || Convert.ToInt32(inventoryTextBox.Text) > Convert.ToInt32(maxTextBox.Text))
            {
                MessageBox.Show("Inventory value must not be less than minimum or greater than maximum. Please update and try saving again.");
                return;
            }

            if (InHouseRadio.Checked == true)
            {

                Inhouse inHouse = new Inhouse(ModPartIDBoxText, ModPartNameBoxText, ModPartPriceBoxText, ModPartInvBoxText, ModPartMinBoxText, ModPartMaxBoxText, int.Parse(ModPartMachComBoxText));
                Inventory.DeletePart(inHouse);
                Inventory.AddPart(inHouse);
                //Inventory.UpdateInhousePart(ModPartIDBoxText, inHouse);
                this.Close();
            }

            //else if (OutsourcedRadio.Checked == true)
            //{
            //    Outsourced outSourced = new Outsourced(ModPartIDBoxText, ModPartNameBoxText, ModPartPriceBoxText, ModPartInvBoxText, ModPartMinBoxText, ModPartMaxBoxText, ModPartMachComBoxText);
            //    Inventory.UpdateOutsourcedPart(ModPartIDBoxText, outSourced);
            //    this.Close();
            //}
            else if (OutsourcedRadio.Checked == true)
            {
                Outsourced outSourced = new Outsourced(ModPartIDBoxText, ModPartNameBoxText, ModPartPriceBoxText, ModPartInvBoxText, ModPartMinBoxText, ModPartMaxBoxText, ModPartMachComBoxText);
                Inventory.DeletePart(outSourced);
                Inventory.AddPart(outSourced);
                this.Close();
            }



            MainForm.RefreshParts();
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

        private void machineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadio.Checked == true)
            {
                try
                {
                    int temp = Convert.ToInt32(machineIDTextBox.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter an integer value in the machine ID field.");
                    return;
                }
            }
            else
            {
                return;
            }
        }
    }
}
