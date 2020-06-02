namespace Inventory_System
{
    public class Outsourced : Part
    {

        public string CompanyName { get; set; }

        public Outsourced() { }
        public Outsourced(int PartID, string Name, decimal Price, int inStock, int min, int max, string company) : base(PartID, Name, Price, inStock, min, max)
        {
            CompanyName = company;
        }
    }
}
