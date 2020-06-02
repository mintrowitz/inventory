namespace Inventory_System
{
    abstract public class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }


        public Part() { }
        public Part(int ID, string partName, decimal partPrice, int partInStock, int partMin, int partMax)
        {
            PartID = ID;
            Name = partName;
            Price = partPrice;
            InStock = partInStock;
            Min = partMin;
            Max = partMax;
        }
    }
}