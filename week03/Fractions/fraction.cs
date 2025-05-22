using System;

namespace FractionsApp
{
    public class Fraction
    {
        // Private fields
        private int _numerator;
        private int _denominator;

        // No-argument constructor: initializes to 1/1
        public Fraction()
        {
            _numerator = 1;
            _denominator = 1;
        }

        // Single-argument constructor: numerator = value, denominator = 1
        public Fraction(int numerator)
        {
            _numerator = numerator;
            _denominator = 1;
        }

        // Two-argument constructor: numerator and denominator as provided
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _numerator = numerator;
            _denominator = denominator;
        }

        // Getter for numerator
        public int GetNumerator()
        {
            return _numerator;
        }

        // Setter for numerator
        public void SetNumerator(int numerator)
        {
            _numerator = numerator;
        }

        // Getter for denominator
        public int GetDenominator()
        {
            return _denominator;
        }

        // Setter for denominator
        public void SetDenominator(int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Denominator cannot be zero.");
            }
            _denominator = denominator;
        }

        // Returns fraction as string "n/d"
        public string GetFractionString()
        {
            return $"{_numerator}/{_denominator}";
        }

        // Returns decimal value of the fraction
        public double GetDecimalValue()
        {
            return (double)_numerator / _denominator;
        }
    }
}