using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Platform
    {
        //variables
        public List<Product> inventory;
        
        //constructor
        public Platform()
        {
            
            List<Product> inventory= new List<Product>();
            inventory.Add(new Product(11, "round table", "tables", 49.99));
            inventory.Add(new Product(12, "square table", "tables", 39.99));
            inventory.Add(new Product(21, "arm chair", "chairs", 144.99));
            inventory.Add(new Product(22, "stool", "chairs", 44.99));
            inventory.Add(new Product(31, "sectional sofa", "sofas", 44.99));


            //Inventory.Add("tables");
            //Inventory.Add("chairs");
            //Inventory.Add("sofas");

            //foreach (var inventory in Inventory)
            //{
            //    Console.WriteLine(inventory);
            //}
        }
        //methods

       
    }
}
