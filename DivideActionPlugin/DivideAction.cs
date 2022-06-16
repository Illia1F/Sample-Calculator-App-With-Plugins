using CalculatorBasePlugin;

namespace DivideActionPlugin
{
    public class DivideAction : ICalculatorAction
    {
        public string DisplayName => "Divide";

        public string ActionSign => "/";

        public float Calculate(float num1, float num2)
        {
            if (num2 == 0)
                throw new System.DivideByZeroException("Cannot divide by zero.");

            return num1 / num2;
        }
    }
}