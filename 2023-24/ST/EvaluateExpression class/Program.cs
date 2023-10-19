namespace EvaluateExpression_class;

class Program
{
    class EvaluateExpression
    {
        public double Evaluate(string expression, double x)
        {
            double num1;
            double num2;
            int index_of_bracket = expression.IndexOf('(');
            int index_of_comma = expression.IndexOf(',');
            if (index_of_comma != -1)
            {
                string[] split_expression = SeparateExpression(expression);
                if (expression[0] == '^')
                {
                    num1 = Evaluate(split_expression[0], x);
                    num2 = Evaluate(split_expression[1], x);
                    double power = double.Parse(expression[1..index_of_bracket]);
                }
                else
                {
                    num1 = Evaluate(split_expression[0], x);
                    num2 = Evaluate(split_expression[1], x);
                }
            }
            else //if (index_of_comma == -1)
            {
                return double.Parse(expression[^1..^1]);
            }
            // else
            // {
            //     if (expression[(index_of_bracket+1)..^1] != "x")
            //     {
            //         if (expression[0] == '^')
            //         {
            //             double power = double.Parse(expression[1..index_of_bracket]);
            //             num1 = double.Parse(expression[(index_of_bracket+1)..^1]);
            //         }
            //         else
            //         {
            //             num1= double.Parse(expression[(index_of_bracket+1)..^1]);
            //         }
            //     }
            // }

            switch (expression[0])
            {
                case '+':
                    return num1 + num2;
                case '-':
                    break;
                case '.':
                    break;
                case '/':
                    break;
                case 's':
                    break;
                case 'c':
                    break;
                case '^':
                    break;
                default:
                    return double.MaxValue;
            }
            return double.MaxValue;
        }

        private string[] SeparateExpression(string input_expression)
        {
            int index_of_first_bracket = input_expression.IndexOf('(');
            int index_of_second_to_last_bracket = FindNthCharFromEnd(input_expression, ')', 2);
            string expr1 = FullBracket(input_expression, FindNthChar(input_expression, '(', 2));
            string expr2 = FullBracketFromEnd(input_expression, index_of_second_to_last_bracket);
            return new string[2] {expr1, expr2};
        }

        private int FindNthCharFromEnd(string expression, char charToFind, int n)
        {
            List<int> all_found_chars = new(10);
            for (int i = expression.Length-1; i >= 0; i--)
            {
                if (expression[i] == charToFind)
                {
                    all_found_chars.Add(i);
                }
            }
            return all_found_chars[n+1];
        }

        private int FindNthChar(string expression, char charToFind, int n)
        {
            List<int> all_found_chars = new(10);
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == charToFind)
                {
                    all_found_chars.Add(i);
                }
            }
            return all_found_chars[n+1];
        }

        private string FullBracket(string expression, int index_of_first_bracket)
        {
            int counter = 1;
            for (int i = index_of_first_bracket+1; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
                if (counter == 0)
                {
                    return expression[(index_of_first_bracket+1)..i];
                }
            }
            return "";
        }
        private string FullBracketFromEnd(string expression, int index_of_last_bracket)
        {
            int counter = 1;
            for (int i = index_of_last_bracket+1; i <= 0; i--)
            {
                if (expression[i] == '(')
                {
                    counter++;
                }
                else if (expression[i] == ')')
                {
                    counter--;
                }
                if (counter == 0)
                {
                    return expression[i..index_of_last_bracket];
                }
            }
            return "";
        }
    }

    static void Main(string[] args)
    {
        EvaluateExpression eval = new();
        Console.WriteLine(eval.Evaluate(".((2), ^2(x))", 10));
        Console.WriteLine(eval.Evaluate("+(-(.(2, ^2(x)), .(25, x)), (12))", 10)); // 2x^2 - 5x + 12
        Console.WriteLine(eval.Evaluate("s(c(x))", 10));
    }
}
