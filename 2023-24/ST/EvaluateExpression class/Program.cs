namespace EvaluateExpression_class;

class Program
{
    class EvaluateExpression
    {
        public double Evaluate(string expression)
        {

            return 1;
        } 

// TODO: implementovat infixový zápis např. +(x;2)
        private List<string> CreateList()
        {

        }
    }

    static void Main(string[] args)
    {
        EvaluateExpression eval = new();
        Console.WriteLine(eval.Evaluate("sin(cos(x))"));
    }
}
