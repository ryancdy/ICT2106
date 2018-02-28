//
// ICT2106 Software Design - Shop example
//
// Null courier, an example of the Null Object pattern
//
// Author: Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    public class NullCourier : ICourier
    {
        public string GetName()
        {
            return "no one";
        }

        public string GenerateConsignmentLabelFor(IOrder order)
        {
            return "N/A";
        }
    }
}
