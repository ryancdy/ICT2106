//
// ICT2106 Software Design - Shop example
//
// Product controller.
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

using ICT2106.Shop.Models.Products;

namespace ICT2106.Shop.Controllers
{
    public class ProductController : Controller
    {
        // interface to the products database
        private IProductGateway products;

        //
        // Constructor. Initialises the product database.
        //
        public ProductController() : base()
        {
            // our products will be stored in a dictionary
            products = new ProductDictionaryAdapter();

            // add some test products to the database
            SimpleProduct bookByOtero = new SimpleProduct(1, "Software Engineering Design book", 80.00M, 0.25M);
            SimpleProduct bookByMillett = new SimpleProduct(2, "Professional ASP.NET Design Patterns book", 50.00M, 0.50M);
            SimpleProduct notesFromLectures = new SimpleProduct(3, "Lecture slides", 10.00M, 0.00M);
            SimpleProduct notesFromLabs = new SimpleProduct(4, "Printed lab notes", 10.00M, 0.10M);
            products.Insert(bookByOtero);
            products.Insert(bookByMillett);
            products.Insert(notesFromLectures);
            products.Insert(notesFromLabs);

            // create some product packages
            CompositeProduct bookPack = new CompositeProduct(10, "Textbook pack", bookByOtero, bookByMillett);
            CompositeProduct notesPack = new CompositeProduct(11, "Notes pack", notesFromLectures, notesFromLabs);
            products.Insert(bookPack);
            products.Insert(notesPack);
        }

        //
        // GET: /Product/
        //
        // Home page for products.
        //
        public IActionResult Index()
        {
            return View(products.SelectAll());
        }
    }
}
