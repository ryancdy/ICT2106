//
// ICT2106 Software Design - Shop example
//
// Interface for couriers.
//
// Author: Scott Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    public interface ICourier
    {
        string GetName();
        string GenerateConsignmentLabelFor(IOrder order);
    }
}
