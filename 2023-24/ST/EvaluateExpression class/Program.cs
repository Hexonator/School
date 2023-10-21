using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace EvaluateExpression_class;

class Program
{
    class EvaluateExpression
    {
        static char[] opearators = new char[5] {'+', '-', '*', '/', '^'};
        static char[] gonio_operators = new char[4] {'s', 'c', 't', 'g'};
        public double Evaluate(string expression, double x)
        {
            double num1, num2;
            if (HasOperators(expression))
            {
                if (gonio_operators.Contains(expression[0]))
                {
                    switch (expression[0])
                    {
                        case 's':
                            return Math.Sin(Evaluate(expression[2..], x));
                        case 'c':
                            return Math.Cos(Evaluate(expression[2..], x));
                        case 't':
                            return Math.Tan(Evaluate(expression[2..], x));
                        case 'g':
                            return 1 / Math.Tan(Evaluate(expression[2..], x));
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
            // string expr1 = FullBracket(input_expression, FindNthChar(input_expression, '(', 2));
            // string expr2 = FullBracketFromEnd(input_expression, FindNthCharFromEnd(input_expression, ')', 2));
            string expr1 = "";
            string expr2 = "";
            int open_expression_counter = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    continue;
                }
                if (opearators.Contains(expression[i]))
                {
                    open_expression_counter+=2;
                    i++;
                }
                else if (gonio_operators.Contains(expression[i]))
                {
                    open_expression_counter++;
                    i++;
                }
                else if (expression[i] == ' ')
                {
                    open_expression_counter-=2;
                }
                if (open_expression_counter == 0)
                {
                    expr1 = expression[2..i];
                    expr2 = expression[(i+1)..];
                    break;
                }
            }
            return new string[2] {expr1, expr2};
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

    static void Main(string[] args)
    {
        EvaluateExpression eval = new();
        Console.WriteLine(eval.Evaluate("* 2 ^ x 2", 10)); // 2x^2
        Console.WriteLine(eval.Evaluate("+ - * 2 ^ x 2 * 25 x 12", 10 )); // 2x^2 - 5x + 12
        Console.WriteLine(eval.Evaluate("s c x", 10));
    }
}
