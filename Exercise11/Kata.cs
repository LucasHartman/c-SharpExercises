﻿/*
Create a function with two arguments that will return an 
array of the first (n) multiples of (x).

Assume both the given number and the number of times 
to count will be positive numbers greater than 0.

Return the results as an array

Examples:
countBy(1,10)  should return  {1,2,3,4,5,6,7,8,9,10}
countBy(2,5)  should return {2,4,6,8,10}
*/

public class Kata {

    public static int[] CountBy(int x, int n)
    {
        int[] z = new int[n];
        for (int i=1; i<=n; i++) 
        { 
        z[i-1]=x*i;
        }
        return z;
    }

    //public static int[] CountBy2(int x , int n) => ;

    static void Main(string[] args) 
    {
        foreach(int i in CountBy(2,5)) 
        {
        Console.WriteLine(i);
        }
    }
}