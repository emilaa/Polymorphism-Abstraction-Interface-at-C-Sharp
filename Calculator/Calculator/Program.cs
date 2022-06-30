using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            calculation.Sum(1, 1);
            calculation.Subtract(1, 1);
            calculation.Multiply(1, 1);
            calculation.Divide(1, 1);
        }
    }
}
