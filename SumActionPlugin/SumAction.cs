using CalculatorBasePlugin;

namespace SumActionPlugin
{
    public class SumAction : ICalculatorAction
    {
        public string DisplayName => "SUM";

        public string ActionSign => "+";

        public float Calculate(float num1, float num2)
        {
            return num1 + num2;
        }
    }
}