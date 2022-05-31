
/*
Complete the method that takes a boolean value and 
return a    "Yes" string for true, 
or a        "No" string for false.
*/

public class Program {

  static void Main(string[] args) {
      boolToWord(false);
  }

public static string boolToWord(bool word) {
    string res = (word == true) ? "Yes" : "No";
    Console.WriteLine(res);
    return res;
    }

}