//
// ICT2106 Software Design - Shop example
//
// Comparer for sorting products by name.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public class ProductNameComparer : IComparer<IProduct>
    {

        public int Compare(IProduct prod1, IProduct prod2)
        {
            return prod1.GetName().CompareTo(prod2.GetName());
        }

    }
}
