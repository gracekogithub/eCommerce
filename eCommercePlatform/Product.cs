using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Product
    {
        // variable
        public int uniqueIdentifier { get; set; }
        public string name { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public double averageRating;
        List<Review> reviews;
        
        //constructor
        public Product(int uniqueIdentifier, string name, 
            string category, double price)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.name = name;
            this.category = category;
            this.price = price;
            averageRating = 0;
            reviews = new List<Review>();
        }

        //methods
        public void ShowProduct()
        {
            
        }

    }
}
