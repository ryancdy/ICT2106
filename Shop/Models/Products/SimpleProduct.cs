//
// ICT2106 Software Design - Shop example
//
// Class representing a simple product with no sub-components
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public class SimpleProduct : AbstractProduct
    {
        // the price of the product
        private decimal price;

        // the weight of the product
        private decimal weight;


        // constructor
        public SimpleProduct(int idIn, string nameIn, decimal priceIn, decimal weightIn) : base(idIn, nameIn)
        {
            // save the price and weight for later
            price = priceIn;
            weight = weightIn;
        }


        // get the price of the product
        public override decimal GetPrice()
        {
            return price;
        }


        // get the weight of the product
        public override decimal GetWeightInKG()
        {
            return weight;
        }


        // get the sub-components of this product
        public override IEnumerable<AbstractProduct> GetComponents()
        {
            // the only component of a simple product is the product itself ('this')
            yield return this;
        }


        // get the number of sub-components in this product (always 1 for simple products)
        public override int GetNumberOfComponents()
        {
            return 1;
        }
    }
}
