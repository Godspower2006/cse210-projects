using System;
using FractionsApp;

namespace FractionsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Using no-arg constructor
                Fraction f1 = new Fraction();
                Console.WriteLine(f1.GetFractionString());   // 1/1
                Console.WriteLine(f1.GetDecimalValue());     // 1

                // Using single-arg constructor
                Fraction f2 = new Fraction(5);
                Console.WriteLine(f2.GetFractionString());   // 5/1
                Console.WriteLine(f2.GetDecimalValue());     // 5

                // Using two-arg constructor
                Fraction f3 = new Fraction(3, 4);
                Console.WriteLine(f3.GetFractionString());   // 3/4
                Console.WriteLine(f3.GetDecimalValue());     // 0.75

                Fraction f4 = new Fraction(1, 3);
                Console.WriteLine(f4.GetFractionString());   // 1/3
                Console.WriteLine(f4.GetDecimalValue());     // ~0.3333

                // Demonstrate getters and setters
                Fraction f5 = new Fraction(2, 5);
                Console.WriteLine(f5.GetFractionString());   // 2/5
                f5.SetNumerator(7);
                f5.SetDenominator(8);
                Console.WriteLine(f5.GetFractionString());   // 7/8
                Console.WriteLine(f5.GetDecimalValue());     // 0.875

                // Uncomment to test invalid denominator
                // Fraction fInvalid = new Fraction(1, 0);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
