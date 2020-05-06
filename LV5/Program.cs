using System;
using System.Collections.Generic;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IShipable> ProductList = new List<IShipable>();
            Box box = new Box("Box 1");
            ProductList.Add(new Product("Product 1", 10, 5));
            ProductList.Add(new Product("Product 2", 20, 8));
            box.Add(new Box("Box num1"));
            foreach (IShipable item in ProductList)
            {
                box.Add(item);
            }


            ShippingService service = new ShippingService(1.7);
            double totalPrice = box.Price + service.ShippingPrice(box);
            Console.WriteLine("Total weight of package your package is " + box.Weight);
            Console.WriteLine("Total price of your package is" + totalPrice);
        }
    }
}