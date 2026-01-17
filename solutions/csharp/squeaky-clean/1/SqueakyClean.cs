using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        var sb = new StringBuilder(identifier.Length);
        bool upperNext = false;
        
        foreach(var ch in identifier)
        {
            if(ch == ' ')
            {
                sb.Append('_');
                upperNext = false;         
            }
            else if(char.IsControl(ch))
            {
                sb.Append("CTRL");
                upperNext = false;            
            }
            else if(ch == '-')
                upperNext = true;
            else if(!char.IsLetter(ch))
                continue;
            else if(ch >= 'α' && ch <= 'ω')
                continue;

            else
            {
                if(upperNext)
                {
                    sb.Append(char.ToUpper(ch));
                    upperNext = false;
                }
                else
                    sb.Append(ch);
            }
        }
        return sb.ToString();
    }
}
