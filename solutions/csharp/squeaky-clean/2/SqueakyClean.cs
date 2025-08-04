using System;
using System.Text;

public static class Identifier
{
	public static string Clean(string identifier)
    {
		StringBuilder sb = new();
		bool nextCharToUpper = false;

		foreach (char c in identifier)
		{
			if (Char.IsLetter(c))
			{
				if (!(c >= 'α' && c <= 'ω'))
				{
					if (nextCharToUpper)
					{
						sb.Append(Char.ToUpper(c));
					}
					else
					{
						sb.Append(c);
					}
				}
			}

			else if (c == ' ')
			{
				sb.Append('_');
			}

			else if (Char.IsControl(c))
			{
				sb.Append("CTRL");
			}

			nextCharToUpper = false;

			if (c == '-')
			{
				nextCharToUpper = true;
			}
		}
		return sb.ToString();
	}
}
