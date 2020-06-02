using System.ComponentModel;

namespace Inventory_System
{

    public class Product
    {
        public BindingList<Part> associatedParts = new BindingList<Part>();

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Product() { }
        public Product(int ID, string productName, decimal productPrice, int productInStock, int productMin, int productMax)
        {
            ProductID = ID;
            Name = productName;
            Price = productPrice;
            InStock = productInStock;
            Min = productMin;
            Max = productMax;
        }

        public void AddAssociatedPart(Part part)
        {
            associatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(int ID)
        {
            bool success = false;
            foreach (Part part in associatedParts)
            {
                if (part.PartID == ID)
                {
                    associatedParts.Remove(part);
                    success = true;
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in associatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            Inhouse emptyInPart = new Inhouse();
            return emptyInPart;
        }
    }
}