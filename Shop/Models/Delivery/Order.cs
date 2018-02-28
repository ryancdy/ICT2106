//
// ICT2106 Software Design - Shop example
//
// Class representing an order.
//
// Author: Scott Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    public class Order : IOrder
    {
        public decimal TotalCost { get; set; }        
        public decimal WeightInKG { get; set; }
        public string CourierTrackingId { get; set; }
        public Address DispatchAddress { get; set; }
    }
}
