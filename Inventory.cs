using System.ComponentModel;

namespace Inventory_System
{

    class Inventory
    {
        public static BindingList<Product> products = new BindingList<Product>();
        public static BindingList<Part> allParts = new BindingList<Part>();

        public static void PopulateSampleLists()
        {
            Product product1 = new Product(1, "Bicycle", 125.00m, 7, 5, 15);
            Product product2 = new Product(2, "Tricycle", 200.00m, 3, 2, 5);
            Product product3 = new Product(3, "Unicycle", 250.00m, 2, 1, 3);
            Product product4 = new Product(4, "Tandem Bicycle", 399.99m, 3, 3, 5);

            Part part1 = new Inhouse(1, "Tire", 30.50m, 33, 50, 100, 9001);
            Part part2 = new Inhouse(2, "Handlebars", 22.99m, 46, 25, 50, 9001);
            Part part3 = new Inhouse(3, "Seat", 33.00m, 50, 50, 100, 9002);
            Part part4 = new Inhouse(4, "Reflector", 2.50m, 756, 500, 2000, 9002);
            Part part5 = new Outsourced(5, "Chain", 3.00m, 17, 15, 30, "Bikes 'R' Us");
            Part part6 = new Outsourced(6, "Crank", 10.00m, 29, 20, 35, "Bikes 'R' Us");
            Part part7 = new Outsourced(7, "Pedal", 5.55m, 20, 15, 100, "Bikeville USA");
            Part part8 = new Outsourced(8, "Brake", 45.00m, 40, 35, 90, "Bikeville USA");

            products.Add(product1);
            products.Add(product2);
            products.Add(product3);
            products.Add(product4);

            allParts.Add(part1);
            allParts.Add(part2);
            allParts.Add(part3);
            allParts.Add(part4);
            allParts.Add(part5);
            allParts.Add(part6);
            allParts.Add(part7);
            allParts.Add(part8);

            product1.associatedParts.Add(part1);
            product1.associatedParts.Add(part2);
            product2.associatedParts.Add(part3);
            product2.associatedParts.Add(part4);
            product3.associatedParts.Add(part5);
            product3.associatedParts.Add(part6);
            product4.associatedParts.Add(part7);
            product4.associatedParts.Add(part8);
        }





        public static void AddProduct(Product newProduct)
        {
            products.Add(newProduct);
        }

        public static void RemoveProduct(Product deletedProduct)
        {
            for (int i = 0; i < products.Count; ++i)
            {
                if (products[i].ProductID == deletedProduct.ProductID)
                {
                    Product existingProduct = (Product)products[i];
                    products.Remove(existingProduct);
                }
            }
        }

        public static void UpdateProduct(int ID, Product product)
        {
            for (int i = 0; i < products.Count; ++i)
            {
                Product existingProduct = (Product)products[i];

                if (existingProduct.ProductID == ID)
                {
                    existingProduct.Name = product.Name;
                    existingProduct.InStock = product.InStock;
                    existingProduct.Price = product.Price;
                    existingProduct.Min = product.Min;
                    existingProduct.Max = product.Max;

                    existingProduct.associatedParts = product.associatedParts;
                }

            }
        }


        public static void AddPart(Part newPart)
        {
            allParts.Add(newPart);
        }

        public static void DeletePart(Part part)
        {
            for (int i = 0; i < allParts.Count; ++i)
            {
                if (allParts[i].PartID == part.PartID)
                {
                    if (allParts[i].GetType() == typeof(Outsourced))
                    {
                        Outsourced existingOutPart = (Outsourced)allParts[i];
                        allParts.Remove(existingOutPart);
                    }
                    else
                    {
                        Inhouse existingInPart = (Inhouse)allParts[i];
                        allParts.Remove(existingInPart);
                    }
                }
            }
        }

        public static Part SearchParts(string Name)
        {
            for (int i = 0; i < allParts.Count; ++i)
            {
                if (allParts[i].Name.ToUpper() == Name.ToUpper())
                {
                    return allParts[i];
                }
            }
            Part nullPart2 = null;
            return nullPart2;
        }

        public static Product SearchProducts(string Name)
        {
            for (int j = 0; j < products.Count; ++j)
            {
                if (products[j].Name.ToUpper() == Name.ToUpper())
                {
                    return products[j];
                }
            }
            Product nullProduct = null;
            return nullProduct;
        }

        //public static void UpdateInhousePart(int ID, Part updatedPart)
        //{
        //    DeletePart(updatedPart);

        //    if (updatedPart.GetType() == typeof(Outsourced))
        //    {
        //        Outsourced newPart = new Outsourced(updatedPart.PartID, updatedPart.Name, updatedPart.Price, updatedPart.InStock, updatedPart.Min, updatedPart.Max);

        //        newPart.Name = newPart.Name;
        //        newPart.InStock = newPart.InStock;
        //        newPart.Price = newPart.Price;
        //        newPart.Max = newPart.Max;
        //        newPart.Min = newPart.Min;
        //            }
        //        else
        //            {
        //                Outsourced existingOutPart = (Outsourced)allParts[i];

        //                if (existingOutPart.PartID == ID)
        //                {
        //                    existingOutPart.Name = newPart.Name;
        //                    existingOutPart.InStock = newPart.InStock;
        //                    existingOutPart.Price = newPart.Price;
        //                    existingOutPart.Max = newPart.Max;
        //                    existingOutPart.Min = newPart.Min;
        //                }
        //            }
        //        }
        //    }
        //}

        //public static void UpdateOutsourcedPart(int ID, Outsourced outsourcedPart)
        //{
        //    for (int i = 0; i < allParts.Count; ++i)
        //    {
        //        if (allParts[i].GetType() == typeof(Outsourced))
        //        {
        //            Outsourced existingPart = (Outsourced)allParts[i];

        //            if (existingPart.PartID == ID)
        //            {
        //                existingPart.Name = outsourcedPart.Name;
        //                existingPart.InStock = outsourcedPart.InStock;
        //                existingPart.Price = outsourcedPart.Price;
        //                existingPart.Max = outsourcedPart.Max;
        //                existingPart.Min = outsourcedPart.Min;
        //                existingPart.CompanyName = outsourcedPart.CompanyName;
        //            }
        //        }
        //    }
        //}


    }
}
