﻿/*
Your task is to create a function that does four basic mathematical operations.

The function should take three 

arguments - operation(string/char), value1(number), value2(number).

The function should return result of numbers after applying the chosen operation.
Examples(Operator, value1, value2) --> output

('+', 4, 7) --> 11
('-', 15, 18) --> -3
('*', 5, 5) --> 25
('/', 49, 7) --> 7


*/

public class kata 
{

    public static double basicOp(char op, double val1, double val2)
    {
      switch(op){
        case '+': return val1+val2;
        case '-': return val1-val2;
        case '*': return val1*val2;
        case '/': return val1/val2;
        default:
           throw new System.ArgumentException("Unknown operation!", op.ToString());
      }
    }

    static void Main(string[] args)
    {
        Console.WriteLine(basicOp('+',4,7)); // 11
    }

}