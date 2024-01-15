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

        static int multiplier = 100;
        static char[] dual_opearators = new char[5] { '+', '-', '*', '/', '^' };
        static char[] unar_operators = new char[5] { 's', 'c', 't', 'g', '|'};

        public static double EvaluatePrefixNotation(string expression, double x)
        {
            double num1, num2;
            if (HasOperators(expression))
            {
                if (unar_operators.Contains(expression[0]))
                {
                    switch (expression[0])
                    {
                        case 's':
                            return Math.Sin(EvaluatePrefixNotation(expression[2..], x));
                        case 'c':
                            return Math.Cos(EvaluatePrefixNotation(expression[2..], x));
                        case 't':
                            return Math.Tan(EvaluatePrefixNotation(expression[2..], x));
                        case 'g':
                            return 1 / Math.Tan(EvaluatePrefixNotation(expression[2..], x));
                        case '|':
                            return Math.Abs(EvaluatePrefixNotation(expression[2..], x));
                        default:
                            return double.NaN;
                    }
                }
                string[] split_expression = SeparateExpression(expression);
                num1 = EvaluatePrefixNotation(split_expression[0], x);
                num2 = EvaluatePrefixNotation(split_expression[1], x);

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
            else
            {
                if (double.TryParse(expression, out double result))
                {
                    return result;
                }
                else
                {
                    return x;
                }
            }
        }

        private static string[] SeparateExpression(string expression)
        {
            string expr1 = "";
            string expr2 = "";
            int open_expression_counter = 0;
            for (int iteration = 0; iteration < expression.Length; iteration++)
            {
                if (char.IsDigit(expression[iteration]) || expression[iteration] == 'x')
                {
                    continue;
                }
                if (dual_opearators.Contains(expression[iteration]))
                {
                    open_expression_counter += 1;
                    iteration++;
                }
                else if (unar_operators.Contains(expression[iteration]))
                {
                    iteration++;
                }
                else if (expression[iteration] == ' ')
                {
                    open_expression_counter -= 1;
                }
                if (open_expression_counter <= 0)
                {
                    expr1 = expression[2..(iteration-1)];
                    expr2 = expression[(iteration + 1)..^1];
                    break;
                }
            }
            return new string[2] { expr1, expr2 };
        }

        private static bool HasOperators(string expression)
        {
            bool operatorFound = false;
            foreach (var character in expression)
            {
                if (dual_opearators.Contains(character) || unar_operators.Contains(character))
                {
                    operatorFound = true;
                }
                else if (operatorFound && character == '(')
                {
                    return true;
                }
                else
                {
                    operatorFound = false;
                }
            }
            return false;
        }
    }
}
