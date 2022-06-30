using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculation : ICalculation
    {
       
        public void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
        }

        public void Subtract(int a, int b)
        {
            int subtract = a - b;
            Console.WriteLine(subtract);
        }

        public void Multiply(int a, int b)
        {
            int multiply = a * b;
            Console.WriteLine(multiply);
        }

        public void Divide(int a, int b)
        {
            int divide =  a / b;
            Console.WriteLine(divide);
        }


    }
}
