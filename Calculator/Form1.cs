using System.Data;
using System.Linq.Expressions;
using System.Runtime.Versioning;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string expression = "";
        bool isError = false;
        bool isResultDisplayed = false;
        bool convertedNegative = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            expression = "Under Development";
            displayExpression();
            expression = "";
        }

        private void numberButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (isResultDisplayed)
            {
                expression = "";
                isResultDisplayed = false;
            }

            if (button != null)
            {
                checkError();

                expression += button.Text;
                displayExpression();
            }
        }

        private void checkError()
        {
            if (isError)
            {
                expression = "";
                textBox.Clear();
                isError = false;
            }
        }

        private void operatorButtonClicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
            isResultDisplayed = false;
            if (button != null)
            {
                checkError();


                string input = button.Text;
                if (validateInput(input))
                {
                    if (input == ".")
                    {
                        if (string.IsNullOrEmpty(expression) || IsLastCharOperator(expression))
                        {
                            expression += "0.";
                        }
                        else
                        {
                            expression += ".";
                        }
                    }
                    else
                    {
                        expression += input;
                    }
                }
                displayExpression();
            }
        }

        private void eraseButtonClick(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(Button))
            {
                expression = "";
                textBox.Clear();
                convertedNegative = false;
            }

        }
        //private void AlignBottomRight()
        //{
        //    // Align text horizontally to the right
        //    textBox.SelectAll();
        //    textBox.SelectionAlignment = HorizontalAlignment.Right;

        //    // Move caret to the end and scroll down
        //    textBox.SelectionStart = textBox.Text.Length;
        //    textBox.ScrollToCaret();
        //}

        private double calculate()
        {

            string expr = expression;
            if (string.IsNullOrEmpty(expr))
            {
                return 0;
            }
            expr = expr.Replace("x", "*");
            expr = expr.Replace("÷", "/");

            expr = Regex.Replace(expr, @"(\d+(\.\d+)?)%", "($1/100)");

            var table = new DataTable();
            try
            {
                var result = table.Compute(expr, string.Empty);
                return Convert.ToDouble(result);
            }
            catch
            {
                return double.NaN;
            }

        }

        private void equalsButtonClick(object sender, EventArgs e)
        {
            double res = calculate();
            if (double.IsNaN(res))
            {
                return;
            }
            if (double.IsInfinity(res) || double.IsNaN(res))
            {
                expression = "Error";
                isError = true;
            }
            else
            {
                expression = res.ToString();
            }
            displayExpression();
            isResultDisplayed = true;
        }

        private void displayExpression()
        {
            textBox.Text = expression;
        }

        private bool IsLastCharOperator(string expr)
        {
            if (string.IsNullOrEmpty(expr))
                return true;

            char lastChar = expr[^1];
            // Define valid operators and decimal
            char[] validOperators = { '+', '-', 'x', '÷', '*', '/' };

            return validOperators.Contains(lastChar);
        }

        private bool IsLastNumberDecimal(string expr)
        {
            if (string.IsNullOrEmpty(expr))
                return false;

            // Find the last operator
            int lastOperatorIndex = expr.LastIndexOfAny(new char[] { '+', '-', 'x', '÷', '*', '/' });

            // Get the last number segment
            string lastNumber = lastOperatorIndex >= 0 ? expr[(lastOperatorIndex + 1)..] : expr;

            // Check if it already contains a decimal point
            return lastNumber.Contains('.');
        }

        private bool validateInput(string input)
        {
            if (input == ".")
            {
                if (string.IsNullOrEmpty(expression))
                    return true; // Will handle "0." in the click handler

                char lastChar = expression[^1];

                // If last char is operator, allow (will handle "0." in click handler)
                if (IsLastCharOperator(expression))
                    return true;

                // If last number already has a decimal, block
                if (IsLastNumberDecimal(expression))
                    return false;

                // If last char is '.', block
                if (lastChar == '.')
                    return false;

                // If last char is '0', allow
                if (lastChar == '0')
                    return true;

                // Otherwise, allow
                return true;
            }

            // Handle negative sign
            // Replace the negative sign handling block in validateInput with the following:
            if (input == "-")
            {
                if (string.IsNullOrEmpty(expression))
                    return true;

                char lastChar = expression[^1];

                if (IsLastCharOperator(expression) && lastChar != '-')
                    return true;

                if (lastChar == '-')
                {
                    if (convertedNegative || expression.Length < 2 || IsLastCharOperator(expression[..^1]))
                    {
                        return false; // Block successive negative signs
                    }
                    // Only convert to plus if length > 1
                    if (expression.Length > 1)
                    {
                        expression = expression.Substring(0, expression.Length - 1) + "+";
                        displayExpression();
                        convertedNegative = true;
                        return false;
                    }
                }
                return true;
            }

            // Handle other operators
            if ("+x÷*/%".Contains(input))
            {
                if (string.IsNullOrEmpty(expression))
                    return false;
                char lastChar = expression[^1];
                if (IsLastCharOperator(expression))
                    return false;
                if (lastChar == input[0])
                    return false; // Block successive same operator
                convertedNegative = false;
                return true;
            }

            // Allow numbers
            if (char.IsDigit(input, 0))
                return true;

            return false;
        }

        private void toggleSignButton_Click(object sender, EventArgs e)
        {
            expression = "Under Development";
            displayExpression();
            expression = "";
        }
    }
}
