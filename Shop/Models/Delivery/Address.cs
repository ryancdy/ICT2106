//
// ICT2106 Software Design - shop example
//
// Class representing an address.
//
// Author: Scott Millett (2010) Ch. 5, modified by Nicholas Sheppard
//

namespace ICT2106.Shop.Models.Delivery
{
    public class Address
    {
        public string CountryCode { get; set; }

        // constructor
        public Address(string CountryCodeIn)
        {
            CountryCode = CountryCodeIn;
        }
    }
}
