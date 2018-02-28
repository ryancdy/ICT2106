//
// ICT2106 Software Design - Shop example
//
// Interface for managing products in the shop.
//
// Author: Nicholas Sheppard, based on Week 4 lab examples
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public interface IProductGateway
    {
        // delete a product from the shop
        IProduct Delete(int id);

        // add a new product to the shop
        void Insert(IProduct prod);

        // commit changes to long-term storage
        void Save();

        // get all of the products in the shop
        IEnumerable<IProduct> SelectAll();

        // get a product according to its unique identifier
        IProduct SelectById(int id);

        // update the information about an existing product
        void Update(IProduct prod);
    }
}
