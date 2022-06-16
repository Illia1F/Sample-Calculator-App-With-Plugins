using CalculatorBasePlugin;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Calculator
{
    public partial class fm_Main : Form
    {
        private readonly string[] pluginPaths = new string[]
        {
            @"SumActionPlugin\bin\Debug\net6.0\SumActionPlugin.dll",
            @"SubtractActionPlugin\bin\Debug\net6.0\SubtractActionPlugin.dll",
            @"MultiplyActionPlugin\bin\Debug\net6.0\MultiplyActionPlugin.dll",
            @"DivideActionPlugin\bin\Debug\net6.0\DivideActionPlugin.dll"
        };

        private readonly Font _groupActionBtnFont 
            = new Font("Segoe UI Semibold",
                15.75F,
                FontStyle.Bold,
                GraphicsUnit.Point);

        private readonly IPluginService _pluginService;

        public fm_Main(IPluginService pluginService)
        {
            _pluginService = pluginService;

            InitializeComponent();
        }

        private void fm_Main_Load(object sender, EventArgs e)
        {
            lableAction.Text = "?";
            tbNum1.Text = string.Empty;
            tbNum2.Text = string.Empty;
            tbResult.Text = string.Empty;

            InitializeGroupActionButtons();
        }

        private void InitializeGroupActionButtons()
        {
            IEnumerable<ICalculatorAction> actions = pluginPaths
                .Where(pluginPath => _pluginService.PluginExists(pluginPath))
                .SelectMany(pluginPath =>
                {
                    Assembly pluginAssembly = _pluginService.LoadPlugin(pluginPath);
                    return _pluginService.CreateActions(pluginAssembly);
                });

            foreach (ICalculatorAction action in actions)
            {
                var groupBtnAction = new Button()
                {
                    Font = _groupActionBtnFont,
                    Location = new Point(3, 3),
                    Size = new Size(110, 38),
                    TabIndex = 0,
                    Text = action.DisplayName,
                    UseVisualStyleBackColor = true
                };

                groupBtnAction.Click += (sender, args) => groupActionButtonOnClick(this, 
                    new CalculatorActionArgs()
                    { 
                        CalculatorAction = action
                    });

                groupActionButtons.Controls.Add(groupBtnAction);
            }
        }

        private void groupActionButtonOnClick(object sender, CalculatorActionArgs e)
        {
            lableAction.Text = e.CalculatorAction.ActionSign;

            try
            {
                if (float.TryParse(tbNum1.Text, out float num1) == false)
                    throw new Exception("Wrong number 1!");

                if (float.TryParse(tbNum2.Text, out float num2) == false)
                    throw new Exception("Wrong number 2!");

                tbResult.Text = e.CalculatorAction.Calculate(num1, num2).ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }
    }
}