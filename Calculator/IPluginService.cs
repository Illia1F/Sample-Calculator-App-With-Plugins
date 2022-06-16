using CalculatorBasePlugin;
using System.Collections.Generic;
using System.Reflection;

namespace Calculator
{
    public interface IPluginService
    {
        bool PluginExists(string relativePath);
        Assembly LoadPlugin(string relativePath);
        IEnumerable<ICalculatorAction> CreateActions(Assembly assembly);
    }
}
