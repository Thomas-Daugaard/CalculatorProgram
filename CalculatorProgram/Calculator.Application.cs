using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator();
            double a = 6.4;
            double b = 3.0;
            Console.WriteLine($"{a} + {b} is {cal.Add(a,b):0.0#}");
            Console.WriteLine($"{a} - {b} is {cal.Subtract(a, b):0.0#}");
            Console.WriteLine($"{a} * {b} is {cal.Mulitply(a, b):0.0#}");
            Console.WriteLine($"{a}^{b} is {cal.Power(a, b):0.0#}");
        }
    }
}
