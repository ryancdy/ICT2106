//
// ICT2106 Software Design - Shop example
//
// Comparer for sorting products by rpice.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public class ProductPriceComparer : IComparer<IProduct>
    {
        public int Compare(IProduct prod1, IProduct prod2)
        {
            if (prod1.GetPrice() < prod2.GetPrice())
                return -1;
            else if (prod2.GetPrice() < prod1.GetPrice())
                return 1;
            else
                return 0;
        }
    }
}
