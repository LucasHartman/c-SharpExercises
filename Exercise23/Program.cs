/*
Write a function, persistence, that takes in a positive parameter num and 
returns its multiplicative persistence, which is the number of times you 
must multiply the digits in num until you reach a single digit.

For example (Input --> Output):

39 --> 3 (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
999 --> 4 (because 9*9*9 = 729, 7*2*9 = 126, 1*2*6 = 12, and finally 1*2 = 2)
4 --> 0 (because 4 is already a one-digit number)
*/
using System;
using System.Collections.Generic;

public class Program
{
    public static int Persistence(long n) 
	{
        int cout = 0;
        while (n>9)
        {
            string str = n.ToString();
            long cal = 1;

            for(int i=0; i<str.Length; i++)
            {
                cal *=  Int32.Parse(str[i].ToString() );
                Console.WriteLine($"input:{str} output: {cal} persistence:{t}");
            }
            count++;
            n= (long)Convert.ToDouble(cal);
        }
		return count;
	}



  public static int Persistence2(long n)
  {
      int count = 0;
      while (n > 9)
      {
          count++;
          n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
      }
      return count;
  }


    static void Main(string[] args)
    {
        Console.WriteLine(Persistence(39));
    }
}