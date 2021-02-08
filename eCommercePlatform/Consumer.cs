using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class Consumer
    {
        //variable (has)
        public string firstName;
        public string lastName;
        public ShoppingCart shoppingCart;

        //constructor
        public Consumer(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            
        }
        //methods
        public void EnterYourName()
        {
            string fullName = firstName + lastName;
            Console.WriteLine("What is your first name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("What is your last name: ");
            string userInput2 = Console.ReadLine();
        }
        
       
        public void ChooseYourProduct(string Product)
        {
            Console.WriteLine("You chose" + Product);
        }


    }
}
    