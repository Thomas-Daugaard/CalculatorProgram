using System;

namespace CalculatorProgram
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Mulitply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            if (x < 0 && exp < 0)
                throw new InvalidOperationException("Cannot raise a negative number to the power of a negative number");

            return Math.Pow(x, exp);
        }
    }
}
