/*
Complete the solution so that the function will break up camel casing, 
using a space between words.
Example

"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/

public class Program
{
public static string BreakCamelCase(string str)
{
    for (int i=0; i<str.Length; i++)
    {
        if (char.IsUpper(str, i))
        {
            str = str.Insert(i," ");
            i++;
        }
    }
    return str;
}

  public static string BreakCamelCase2(string str)
  {
    return string.Concat(str.Select(c => Char.IsUpper(c) ? " " + c : c.ToString()));
  }

  static void Main(string[] args)
  {
      Console.WriteLine(BreakCamelCase("camelCasing"));
  }
}
