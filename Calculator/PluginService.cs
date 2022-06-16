using CalculatorBasePlugin;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Calculator
{
    public class PluginService : IPluginService
    {
        public Assembly LoadPlugin(string relativePath)
        {
            // Navigate up to the solution root
            string root = Path.GetFullPath(Path.Combine(
                Path.GetDirectoryName(
                    path: Path.GetDirectoryName(
                        path: Path.GetDirectoryName(
                            path: Path.GetDirectoryName(
                                path: Path.GetDirectoryName(typeof(Program).Assembly.Location)))))));

            string pluginLocation = Path.GetFullPath(Path.Combine(root, relativePath.Replace('\\', Path.DirectorySeparatorChar)));
            Console.WriteLine($"Loading commands from: {pluginLocation}");
            PluginLoadContext loadContext = new PluginLoadContext(pluginLocation);
            return loadContext.LoadFromAssemblyName(AssemblyName.GetAssemblyName(pluginLocation));
        }

        public IEnumerable<ICalculatorAction> CreateActions(Assembly assembly)
        {
            foreach (Type type in assembly.GetTypes())
            {
                var commandInterface = type.GetInterface(nameof(ICalculatorAction));
                if (commandInterface != null)
                {
                    var result = Activator.CreateInstance(type);
                    if (result != null)
                    {
                        yield return result as ICalculatorAction;
                    }
                }
            }
        }
    }
}
