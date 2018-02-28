//
// ICT2106 Software Design - Shop example
//
// Singapore Post courier.
//
// Author: Scott Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    public class SingaporePostCourier : ICourier
    {
        public string GetName()
        {
            return "Singapore Post";
        }

        public string GenerateConsignmentLabelFor(IOrder order)
        {
            return "SPXXXX-XXXX-XXXX";
        }
    }
}
