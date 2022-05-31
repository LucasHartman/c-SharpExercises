using System;

/*
Create a function that takes an integer as an argument and 
returns "Even" for even numbers 
or      "Odd" for odd numbers.
*/

namespace Solution {
  public class SolutionClass {
    public static string EvenOrOdd(int number) {
      return ((number%=2)==0) ? "Even" : "Odd"; 
    }
  }
}

public class TestClass {
  static void Main(string[] args) {
    //Solution.SolutionClass obj = new Solution.SolutionClass();
    Console.WriteLine(Solution.SolutionClass.EvenOrOdd(6));
  }
}