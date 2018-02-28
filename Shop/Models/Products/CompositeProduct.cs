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
    public class CompositeProduct : AbstractProduct
    {
        // the sub-components of this product
        private IList<AbstractProduct> components;


        // constructor
        public CompositeProduct(int idIn, string nameIn, params AbstractProduct[] componentsIn) : base(idIn, nameIn)
        {
            // copy references to the input components into our internal list
            components = new List<AbstractProduct>();
            foreach (AbstractProduct prod in componentsIn)
                components.Add(prod);
        }


        // get the price of the package (the sum of the components prices, less 10%)
        public override decimal GetPrice()
        {
            // get the sum of the prices of the component products
            decimal price = 0.00M;
            foreach (AbstractProduct prod in components)
                price += prod.GetPrice();

            // reduce it by 10%
            return price * 0.9M;
        }


        // get the weight of the package
        public override decimal GetWeightInKG()
        {
            // get the sum of the weights of the component products
            decimal weight = 0.00M;
            foreach (AbstractProduct prod in components)
                weight += prod.GetWeightInKG();

            return weight;
        }


        // enumerate the sub-components of the package
        public override IEnumerable<AbstractProduct> GetComponents()
        {
            return components;
        }


        // get the number of sub-components in the package
        public override int GetNumberOfComponents()
        {
            return components.Count;
        }
    }
}
