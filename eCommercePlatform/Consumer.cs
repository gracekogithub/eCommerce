using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Consumer
    {
        public string firstName;
        public string lastName;
        public string shoppingCart;


        //constructor
        public Consumer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }



        //methods
        public void UsePlatform(Consumer consumer)
        {

        }
        public void FullNameIs()
        {
            Console.WriteLine();
        }


    }
}
    