using CalculatorBasePlugin;

namespace SubtractActionPlugin
{
    public class SubtractAction : ICalculatorAction
    {
        public string DisplayName => "Subtract";

        public string ActionSign => "-";

        public float Calculate(float num1, float num2)
        {
            return num1 - num2;
        }
    }
}