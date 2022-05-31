/*
Write a function to split a string and convert it into an array of words.
Examples (Input -> Output):

* "Robin Singh" ==> ["Robin", "Singh"]

* "I love arrays they are my favorite" ==> ["I", "love", "arrays", "they", "are", "my", "favorite"]
*/

public class Kata {

    public static string[] StringToArray(string str) => str.Split(" ");

    static void Main(string[] args)
    {
        Console.WriteLine(  StringToArray("Robin Singh") );
    }
}