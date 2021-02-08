using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            Consumer consumer1 = new Consumer("Alex", "Washington");
            consumer1.EnterYourName();
            Console.WriteLine($"Please select one from: ");
            List<string> shoppingList = new List<string>();
            shoppingList.Add("round table");
            shoppingList.Add("stoll");
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }
            
            
            
            
            
            
            Console.WriteLine($"Thank you for shopping!");
            Console.ReadLine();

        }
    }
}
