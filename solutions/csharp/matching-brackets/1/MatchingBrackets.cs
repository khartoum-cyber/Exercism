namespace MatchingBrackets;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (var ch in input)
        {
            if(ch is '(' or '{' or '[')
                stack.Push(ch);
            if(ch is ')' or '}' or ']')
                if (stack.Count == 0)
                    return false;
                else if (!isMatchingPair(stack.Pop(), ch))
                    return false;
        }

        return stack.Count == 0;
    }

    public static bool isMatchingPair(char character1, char character2)
    {
        switch (character1)
        {
            case '(' when character2 == ')':
            case '{' when character2 == '}':
            case '[' when character2 == ']':
                return true;
            default:
                return false;
        }
    }
}