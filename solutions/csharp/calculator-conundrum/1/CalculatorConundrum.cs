public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string? operation)
    {
        try
        {
            string result = operation switch
            {
                "+" => $"{operand1} + {operand2} = {operand1 + operand2}",
                "*" => $"{operand1} * {operand2} = {operand1 * operand2}",
                "/" => $"{operand1} / {operand2} = {operand1 / operand2}",
                "" => throw new ArgumentException(),
                null => throw new ArgumentNullException(),
                _ => throw new ArgumentOutOfRangeException()
            };
            return result;
        }
        catch(DivideByZeroException e)
        {
            return "Division by zero is not allowed.";
        }
    }
}
