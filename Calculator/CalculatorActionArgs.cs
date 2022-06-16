using CalculatorBasePlugin;
using System;

namespace Calculator
{
    public class CalculatorActionArgs : EventArgs
    {
        public ICalculatorAction CalculatorAction { get; set; }
    }
}
