using System;

public static class SimpleCalculator
{
    public static string Calculate(int operand1, int operand2, string operation) => operation switch
    {
        "/" => operand2 != 0 ? $"{operand1} {operation} {operand2} = {SimpleOperation.Division(operand1, operand2)}" : "Division by zero is not allowed.",
        "*" => $"{operand1} {operation} {operand2} = {SimpleOperation.Multiplication(operand1, operand2)}",
        "+" => $"{operand1} {operation} {operand2} = {SimpleOperation.Addition(operand1, operand2)}",
        "" => throw new ArgumentException(),
        null => throw new ArgumentNullException(),
        _ => throw new ArgumentOutOfRangeException()
    };
}
