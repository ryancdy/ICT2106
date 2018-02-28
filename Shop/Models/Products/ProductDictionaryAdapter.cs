//
// ICT2106 Software Design - Shop example
//
// Adapter pattern for using a Dictionary as a realisation of IProductGateway.
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public class ProductDictionaryAdapter : IProductGateway
    {
        // the dictionary in which the products are to be storied
        private Dictionary<int, IProduct> dict;


        // constructor
        public ProductDictionaryAdapter()
        {
            // create the dictionary
            dict = new Dictionary<int, IProduct>();
        }


        // delete a product from the shop
        public IProduct Delete(int id)
        {
            IProduct prod = SelectById(id);
            dict.Remove(id);

            return prod;
        }


        // add a new product to the shop
        public void Insert(IProduct prod)
        {
            if (!dict.ContainsKey(prod.GetId()))
            {
                dict.Add(prod.GetId(), prod);
            }
        }


        // commit changes to long-term storage
        public void Save()
        {
            // not implemented
        }


        // get all of the products in the shop
        public IEnumerable<IProduct> SelectAll()
        {
            return dict.Values;
        }


        // get a product according to its unique identifier
        public IProduct SelectById(int id)
        {
            return dict.ContainsKey(id) ? dict[id] : null;
        }


        // update the information about an existing product
        public void Update(IProduct prod)
        {
            if (dict.ContainsKey(prod.GetId()))
            {
                dict[prod.GetId()] = prod;
            }
        }
    }
}
