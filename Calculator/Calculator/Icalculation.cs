using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public interface ICalculation 
    {
        void Sum(int a, int b);

        void Subtract(int a, int b);

        void Multiply(int a, int b);

        void Divide(int a, int b);
    }
}
