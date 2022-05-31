/*
Write a function to convert a name into initials. 
This kata strictly takes two words with one space in between them.

The output should be two capital letters with a dot separating them.
It should look like this:

Sam Harris => S.H

patrick deny => P.F
*/

public class Program
{
  public static string AbbrevName(string name)
  {
    string[] myStr = name.Split(' ');
    string x = myStr[0][0].ToString().ToUpper();
    string y = myStr[1][0].ToString().ToUpper();
    return $"{x}.{y}";
  }

  static void Main(string[] args) 
  {
      Console.WriteLine( AbbrevName("Lucas Hartman") );
  }
}