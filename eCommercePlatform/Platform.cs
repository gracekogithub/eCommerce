using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class Platform
    {
        // variable 
        public List<Product> inventory;
       

        //constructor
        public Platform() 
        {
            inventory = new List<Product>();            
        }

        //methods
        
        private Product CreateProduct(int uniqueIdentifier, string name, string category, double price)
        {
            Product product = new Product(uniqueIdentifier, name, category, price);
            return product;
        }
        private void PopulateInventory(Product product) 

        {
            Console.WriteLine("Welcome to my store!");
           
            string userInput = Console.ReadLine();


        }

       


    }
}
