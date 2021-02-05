using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommercePlatform
{
    public class ShoppingCart
    {
        // variable
        string chosenProduct;
        int numberChosen;
        double eachPrice;
        double totalCostProducts;
        string summaryOfSelection;


        //constructor
        public ShoppingCart(string chosenProduct, int numberChosen, double eachPrice, 
            double totalCostProducts, string summaryOfSelection)
        {
            this.chosenProduct = chosenProduct;
            this.numberChosen = numberChosen;
            this.eachPrice = eachPrice;
            this.totalCostProducts = totalCostProducts;
            this.summaryOfSelection = summaryOfSelection;
        }
        //methods
        public void PurchasedProduct()
        {

        }



    }
}
