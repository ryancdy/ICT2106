//
// ICT2106 Software Design - Shop example
//
// Courier factory
//
// Author: Scott Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    class CourierFactory
    {
        public static ICourier CreateCourier(Order order)
        {
            if (order.WeightInKG > 0)
            {
                if ((order.TotalCost > 100) || (order.WeightInKG > 5))
                {
                    // deliver using DHL
                    return new DhlCourier();
                }
                else
                {
                    // deliver using Singapore Post
                    return new SingaporePostCourier();
                }
            }
            else
            {
                // nothing to be delivered
                return new NullCourier();
            }
        }
    }
}
