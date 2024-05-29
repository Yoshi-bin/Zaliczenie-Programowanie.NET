using System;
using System.Windows;
using System.Windows.Controls;
using System.Data;

namespace CalculatorApp
{
    public partial class MainWindow : Window
    {
        private string expression = "";
        private string history = "";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnButtonClick(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            string buttonText = button.Content.ToString();

            switch (buttonText)
            {
                case "=":
                    try
                    {
                        DataTable table = new DataTable();
                        var result = table.Compute(expression, null).ToString();
                        history = expression;
                        expression = result;
                        UpdateDisplay();
                    }
                    catch
                    {
                        expression = "Error";
                        UpdateDisplay();
                        expression = "";
                    }
                    break;
                case "C":
                    expression = "";
                    history = "";
                    UpdateDisplay();
                    break;
                case "sqrt":
                case "log":
                case "ln":
                case "!":
                case "ceil":
                case "floor":
                case "1/x":
                    try
                    {
                        double value = Convert.ToDouble(expression);
                        switch (buttonText)
                        {
                            case "sqrt":
                                expression = Math.Sqrt(value).ToString();
                                break;
                            case "log":
                                expression = Math.Log10(value).ToString();
                                break;
                            case "ln":
                                expression = Math.Log(value).ToString();
                                break;
                            case "!":
                                expression = Factorial(Convert.ToInt32(value)).ToString();
                                break;
                            case "ceil":
                                expression = Math.Ceiling(value).ToString();
                                break;
                            case "floor":
                                expression = Math.Floor(value).ToString();
                                break;
                            case "1/x":
                                expression = (1 / value).ToString();
                                break;
                        }
                        history = buttonText + "(" + history + ")";
                        UpdateDisplay();
                    }
                    catch
                    {
                        expression = "Error";
                        UpdateDisplay();
                        expression = "";
                    }
                    break;
                default:
                    expression += buttonText;
                    UpdateDisplay();
                    break;
            }
        }

        private void UpdateDisplay()
        {
            HistoryTextBlock.Text = history;
            ResultTextBlock.Text = expression;
        }

        private long Factorial(int n)
        {
            if (n <= 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
