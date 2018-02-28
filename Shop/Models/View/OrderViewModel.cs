//
// ICT2106 Software Design - shop example
//
// View model for the order submission page.
//
// Author: Nicholas Sheppard
//
using ICT2106.Shop.Models.Delivery;

namespace ICT2106.Shop.Models.View
{
    public class OrderViewModel
    {
        // the courier who will deliver the order
        private ICourier courier;

        // the order
        private IOrder order;
        
        // constructor
        public OrderViewModel(ICourier courierIn, Order orderIn)
        {
            courier = courierIn;
            order = orderIn;
        }

        // get the courier's name
        public string GetCourierName()
        {
            return courier.GetName();
        }

        // get the order
        public string GetConsignmentLabel()
        {
            return courier.GenerateConsignmentLabelFor(order);
        }
    }
}
