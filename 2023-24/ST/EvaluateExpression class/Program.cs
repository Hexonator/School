namespace EvaluateExpression_class;

class Program
{
    class EvaluateExpression
    {
        public double Evaluate(string expression, double x)
        {
            double num1 = 0;
            double num2 = 0;
            int index_of_bracket = expression.IndexOf('(');
            int index_of_comma = expression.IndexOf(',');
            if (expression.Contains(','))
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
            else if (index_of_bracket == -1 && index_of_comma == -1)
            {
                return double.Parse(expression);
            }
            else
            {
                if (expression[(index_of_bracket+1)..^1] != "x")
                {
                    if (expression[0] == '^')
                    {
                        double power = double.Parse(expression[1..index_of_bracket]);
                        num1 = double.Parse(expression[(index_of_bracket+1)..^1]);
                    }
                    else
                    {
                        num1= double.Parse(expression[(index_of_bracket+1)..^1]);
                    }
                }
            }

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
            int index_of_second_to_last_bracket = FindNthCharFromEnd(input_expression, ')', 1);
            return new string[2] {FullBracket(input_expression, index_of_first_bracket),
                                  FullBracketFromEnd(input_expression, index_of_second_to_last_bracket)};
            // TODO: Include occasions where there aren't brackets
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
            return all_found_chars[n];
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
                    return expression[index_of_first_bracket..i];
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
        Console.WriteLine(eval.Evaluate(".(2, ^2(x))", 10));
        Console.WriteLine(eval.Evaluate("+(-(.(2, ^2(x)), .(5, x)), 12)", 10)); // 2x^2 - 5x + 12
        Console.WriteLine(eval.Evaluate("s(c(x))", 10));
    }
}
