/*
Write a function that takes in a string of one or more words, and returns the same string, 
but with all !!five or more letter words reversed!! (Just like the name of this Kata). 
Strings passed in will consist of only letters and spaces. 
Spaces will be included only when more than one word is present.

Examples: 
spinWords( "Hey fellow warriors" ) => returns "Hey wollef sroirraw" 
spinWords( "This is a test") => returns "This is a test" 
spinWords( "This is another test" )=> returns "This is rehtona test"
*/
public class Progam {

    public static string SpinWords(string sentence)
    {
        string[] words = sentence.Split(" ");
        int x = 0;
        foreach(string i in words)
        {
            if(i.Length>4)
            {
                char[] stringArray = i.ToCharArray();
                Array.Reverse(stringArray);
                words[x] = new string(stringArray); 
            }
            x++;
        }    
        return string.Join(" ", words);
    }

    static void Main(string[] args)
    {
        Console.WriteLine(SpinWords("This is rehtona test"));
    }
}