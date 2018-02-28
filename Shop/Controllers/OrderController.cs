//
// ICT2106 Software Design - Shop example
//
// Order controller
//
// Author: Nicholas Sheppard
//
using Microsoft.AspNetCore.Mvc;

using ICT2106.Shop.Models.Delivery;
using ICT2106.Shop.Models.View;

namespace ICT2106.Shop.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/
        //
        // Page for making an order.
        //
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /Order/Submit
        //
        // Handler for order submissions.
        //
        public IActionResult Submit(string trackingId, decimal cost, decimal weight, string address)
        {
            // build an Order object from the form data
            Order order = new Order();
            order.CourierTrackingId = trackingId;
            order.TotalCost = cost;
            order.WeightInKG = weight;
            order.DispatchAddress = new Address(address);

            // get the courier for the order
            ICourier courier = CourierFactory.CreateCourier(order);

            // display the delivery information
            OrderViewModel model = new OrderViewModel(courier, order);
            return View(model);
        }
    }
}
