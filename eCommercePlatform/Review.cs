using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class Review
    {
        // variable
        double rating;
        string text;

        //constructor
        public Review(double rating, string text)
        {
            this.rating = rating;
            this.text = text;
            
            Console.WriteLine("Please rate the item you purchased");
            Console.WriteLine("Please, write your comment");
            string userInput = Console.ReadLine();
        }

        //methods
        
    }
}
