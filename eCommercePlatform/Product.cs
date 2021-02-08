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
       
        public int uniqueIdentifier;
        public string name;
        public string category;
        public double price;
        public int averageRating;
        List<Review> review;
        

        //constructor

        public Product(int uniqueIdentifier, string name, string category, double price)
        {
            this.uniqueIdentifier = uniqueIdentifier;
            this.name = name;
            this.category = category;
            this.price = price;
            averageRating = 0;
            review = new List<Review>();
        }
       //method
       public void ListProducts()
        {
            List<Product> items = new List<Product>();
            items.Add(new Product(uniqueIdentifier,name,category,price));
            items[0].uniqueIdentifier = 11;
            items[0].name = "round table";
        }
        //{
        //    Product product11 = new Product(11, "round table", "tables", 49.99);
        //    Product product12 = new Product(12, "square table", "tables", 39.99);
        //    Product product21 = new Product(21, "arm chair", "chairs", 144.99);
        //    Product product22 = new Product(22, "stool", "chairs", 44.99);
        //    Product product31 = new Product(31, "sectional sofa", "sofas", 44.99);
        //    Product product32 = new Product(32, "loveseat", "sofas", 44.99);
        //    Product product33 = new Product(33, "L shape sofa", "sofas", 44.99);
        //}







    }
}
