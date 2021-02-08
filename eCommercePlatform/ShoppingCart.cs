using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class ShoppingCart
    {
        // variable(has a..)
        public List<Product> products;
        public double totalCostProducts;
        //constructor(initial value)
        public ShoppingCart()
        {
            List<Product>itemChosen = new List<Product>();
           
          
            
        }
        //methods(can do)
        public void PurchasedProduct()
        {
            
            Console.WriteLine($"You have added following items{products}.");
            Console.WriteLine("Please click place your order button");
            
        }

        

    }
}
