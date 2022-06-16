namespace CalculatorBasePlugin
{
    public interface ICalculatorAction
    {
        string DisplayName { get; }
        string ActionSign { get; }
        float Calculate(float num1, float num2);
    }
}