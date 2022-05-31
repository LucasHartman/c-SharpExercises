/*
It's pretty straightforward. 
Your goal is to create a function that removes the first and 
last characters of a string. You're given one parameter, 
the original string. You don't have to worry with 
strings with less than two characters.
*/

public class Kata {

     public static string Remove_char(string s)
    {
        int size = s.Length;
        Console.WriteLine(size);
        return s.Substring(1, s.Length-2);
    }

    public static string Remove_char2(string s) => s.Substring(1, s.Length-2);

    static void Main(string[] args){
        Console.WriteLine(Remove_char2("Lucas")); // uca
    }
}