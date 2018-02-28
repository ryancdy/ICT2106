//
// ICT2106 Software Design - Shop example
//
// DHL courier, based on Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    class DhlCourier : ICourier
    {
        public string GetName()
        {
            return "DHL";
        }

        public string GenerateConsignmentLabelFor(IOrder order)
        {
            return "DHL-XXXX-XXXX-XXXX";
        }
    }
}
