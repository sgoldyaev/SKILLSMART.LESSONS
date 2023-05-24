namespace AlgorithmsDataStructures;

public class Calculator
{
    private static readonly Dictionary<string, Func<int, int, int>> operations =
        new Dictionary<string, Func<int, int, int>>()
        {
            { "+", (left, right) => left + right },
            { "-", (left, right) => left - right },
            { "*", (left, right) => left * right },
            { "/", (left, right) => left / right },
        };

    public int Calculate(string postfixExpression)
    {
        var s1 = new Stack<string>();
        var s2 = new Stack<int>();

        var expression = postfixExpression.Split(' ');
        
        for (var index = expression.Length - 1; index >= 0; index--)
            s1.Push(expression[index]);

        while (s1.Size() > 0)
        {
            var element = s1.Pop();

            if (int.TryParse(element, out var e))
                s2.Push(e);
            
            else if (operations.TryGetValue(element, out var operation))
            {
                var right = s2.Pop();
                var left = s2.Pop();
                var result = operation(left, right);
                
                s2.Push(result);
            }
            
            else if (element == "=")
                return s2.Pop();
        }

        return default;
    }
}
