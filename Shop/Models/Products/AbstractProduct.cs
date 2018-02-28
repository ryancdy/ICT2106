//
// ICT2106 Software Design - Shop example
//
// Abstract base class for all products
//
// Author: Nicholas Sheppard
//
using System.Collections.Generic;

namespace ICT2106.Shop.Models.Products
{
    public abstract class AbstractProduct : IProduct
    {
        // the unique product identifier
        private int id;

        // the product name
        private string name;


        // constructor
        public AbstractProduct(int idIn, string nameIn)
        {
            // save the identifier and name for later
            id = idIn;
            name = nameIn;
        }


        // default comparison - compare by identifier
        public int CompareTo(IProduct other)
        {
            if (id < other.GetId())
                return -1;
            else if (other.GetId() < id)
                return 1;
            else
                return 0;
        }


        // get the unique identifier
        public int GetId()
        {
            return id;
        }


        // get the product name
        public string GetName()
        {
            return name;
        }

        // get the price of the product
        public abstract decimal GetPrice();

        // get the weight of the product
        public abstract decimal GetWeightInKG();

        // enumerate the components of this product
        public abstract IEnumerable<AbstractProduct> GetComponents();

        // get the number of components that make up this product
        public abstract int GetNumberOfComponents();
    }
}
