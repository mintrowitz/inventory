namespace Inventory_System
{
    public class Inhouse : Part
    {

        public int MachineID { get; set; }

        public Inhouse() { }
        public Inhouse(int ID, string partName, decimal partPrice, int partInStock, int partMin, int partMax, int machineID) : base(ID, partName, partPrice, partInStock, partMin, partMax)
        {
            PartID = ID;
            Name = partName;
            Price = partPrice;
            InStock = partInStock;
            Min = partMin;
            Max = partMax;

            MachineID = machineID;
        }


    }
}
