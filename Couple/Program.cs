//
// Test program for the Couple class.
//
// Author: Nicholas Sheppard
//

using System;

namespace Couple
{
    class Program
    {
        static void Main(string[] args)
        {
			// get the couple
            Couple c1 = Couple.GetInstance(1);
			Couple c2 = Couple.GetInstance(2);
			
			// print out some diagnostic information
			if (c1 != null && c2 != null) {
				Console.WriteLine("Couple.GetInstance(1) returns " + c1.GetHashCode());
				Console.WriteLine("Couple.GetInstance(2) returns " + c2.GetHashCode());
			} else {
				Console.WriteLine("Couple.GetInstance() did not return an instance.");
				return;
			}
			
			// check that it really is a couple
			bool ok = true;
			Couple newc1 = Couple.GetInstance(1);
			Couple newc2 = Couple.GetInstance(2);
			if (c1 != newc1) {
				Console.WriteLine("Couple.GetInstance(1) returned a different instance " + newc1.GetHashCode());
				ok = false;
			}
			if (c2 != newc2) {
				Console.WriteLine("Couple.GetInstance(2) returned a different instance " + newc2.GetHashCode());
				ok = false;
			}
			if (c1 == c2) {
				Console.WriteLine("Couple.GetInstance(1) and Couple.GetInstance(2) return the same instance.");
				ok = false;
			}
			
			if (ok) {
				Console.WriteLine("Tests passed.");
			}
        }
    }
}
