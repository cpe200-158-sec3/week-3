using System;

namespace Lab301
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            fraction r1 = new fraction();
            fraction r2 = new fraction(2);
            fraction r3 = new fraction(3, 9);

            Console.WriteLine("***** " + fraction.Count + " Fraction objects have been created *****");

            fraction r4 = r1 + r2;
            fraction r5 = r2 - r3;
            fraction r6 = new fraction(100, 50);
            r6 += r2;

            fraction r7 = new fraction(r3);		// case#1     
            //fraction r7 = r3;					// case#2
            r7++;

            Console.WriteLine("***** " + fraction.Count + " Fraction objects have been created *****");

            fraction r8 = 10 - (new fraction(80, 40));
            fraction r9 = (new fraction(5, 25)) + 1;

            Console.WriteLine("***** " + fraction.Count + " Fraction objects have been created *****");

            Console.WriteLine(r1);
            Console.WriteLine(r2);
            Console.WriteLine(r3);
            Console.WriteLine(r4);
            Console.WriteLine(r5);
            Console.WriteLine(r6);
            Console.WriteLine(r7);
            Console.WriteLine(r8);
            Console.WriteLine(r9);

            Console.WriteLine(r2 == r4);
            Console.WriteLine(r4.Equals(r2)); // Equals method must be overriden
            Console.WriteLine(r2 != r4);

            r3.setValue(10, 12 / 3 * 0);
            Console.WriteLine(r3);

            Console.WriteLine("***** " + fraction.Count + " Fraction objects have been created *****");

            Console.WriteLine("GCD of 3650 and 360: " + fraction.GCD(3650, 360));
            Console.WriteLine("GCD of 3600 and 360: " + fraction.GCD(3600, 360));

            Console.ReadLine();
        }

    }
}
