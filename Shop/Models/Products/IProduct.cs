//
// ICT2106 Software Design - Shop example
//
// Interface to be implemented by products.
//
// Author: Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Products
{
    public interface IProduct
    {
        // get the unique product identifier
        int GetId();

        // get the name of the product
        string GetName();

        // get the price of the product
        decimal GetPrice();

        // get the weight of the product
        decimal GetWeightInKG();
    }
}
