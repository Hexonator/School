using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_graphDrawer
{
    internal class EvaluateExpression
    {
        public EvaluateExpression()
        {

        }

        int multiplier = 100;
        char[] opearators = new char[5] { '+', '-', '*', '/', '^' };
        char[] gonio_operators = new char[4] { 's', 'c', 't', 'g' };
        public double Evaluate(string expression, double x)
        {
            //x *= 80;
            double num1, num2;
            if (HasOperators(expression))
            {
                if (gonio_operators.Contains(expression[0]))
                {
                    switch (expression[0])
                    {
                        case 's':
                            return Math.Sin(Evaluate(expression[2..], x / 50)) * multiplier;
                        case 'c':
                            return Math.Cos(Evaluate(expression[2..], x / 50)) * multiplier;
                        case 't':
                            return Math.Tan(Evaluate(expression[2..], x / 50)) * multiplier;
                        case 'g':
                            return 1 / Math.Tan(Evaluate(expression[2..], x / 50)) * multiplier;
                        default:
                            return double.NaN;
                    }
                }
                string[] split_expression = SeparateExpression(expression);
                num1 = Evaluate(split_expression[0], x);
                num2 = Evaluate(split_expression[1], x);
            }
            else
            {
                if (double.TryParse(expression, out double result))
                {
                    return result;
                }
                else
                {
                    if (expression.Length > 1 && double.TryParse(expression[..^1], out double toMultiply))
                    {
                        return toMultiply * x;
                    }
                    return x;
                }
            }

            switch (expression[0])
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    return num1 / num2;
                case '^':
                    return Math.Pow(num1, num2);
                default:
                    return double.NaN;
            }
        }

        private string[] SeparateExpression(string expression)
        {
            string expr1 = "";
            string expr2 = "";
            int open_expression_counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]) || expression[i] == 'x')
                {
                    continue;
                }
                if (opearators.Contains(expression[i]))
                {
                    open_expression_counter += 2;
                    i++;
                }
                else if (gonio_operators.Contains(expression[i]))
                {
                    i++;
                }
                else if (expression[i] == ' ')
                {
                    open_expression_counter -= 2;
                }
                if (open_expression_counter <= 0)
                {
                    expr1 = expression[2..i];
                    expr2 = expression[(i + 1)..];
                    break;
                }
            }
            return new string[2] { expr1, expr2 };
        }

        private bool HasOperators(string expression)
        {
            foreach (var character in expression)
            {
                if (opearators.Contains(character) || gonio_operators.Contains(character))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
