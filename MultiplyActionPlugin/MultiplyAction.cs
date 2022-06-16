using CalculatorBasePlugin;

namespace MultiplyActionPlugin
{
    public class MultiplyAction : ICalculatorAction
    {
        public string DisplayName => "Multiply";

        public string ActionSign => "*";

        public float Calculate(float num1, float num2)
        {
            return num1 * num2;
        }
    }
}