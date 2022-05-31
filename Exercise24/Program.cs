/*
Given a list and a number, create a new list that contains each 
number of list at most N times, without reordering.
For example if the input number is 2, 
and the input list is [1,2,3,1,2,1,2,3], 
you take [1,2,3,1,2], drop the next [1,2] 
since this would lead to 1 and 2 being in 
the result 3 times, and then take 3, which leads to [1,2,3,1,2,3].
With list [20,37,20,21] and number 1, the result would be [20,37,21]. 
*/

using System;
using System.Collections.Generic;


namespace Exercise24
{
    class Program
    {
        public static int[] DeleteNth(int[] arr, int x) 
        {
            foreach (int val in arr)
            {
                List<List<int>> multiList = new List<List<int>>();
                multiList.Add(new List<int>()); // create first inner list
                multiList[0].Add(1); //adds a value to the first list
                multiList[0].Add(0); //adds a second value to the first list

                for (int i=0; i<multiList.Count; i++)
                {
                    Console.WriteLine(multiList.Count);
                    
                    // is current value in the multiList
                    if (val == multiList[i][0])
                    {
                        Console.WriteLine($"{val} is in the list");
                        multiList[i][1] =  (int) multiList[i][1] +1; // not adding up
                        Console.WriteLine($"number of {val} is {multiList[i][1]}");

                    }
                }
            }
            return arr;
        }


        static void Main(string[] args)
        {
            int[] arr = {1,2,3,1,2,1,2,3};
            Console.WriteLine(DeleteNth(arr,2) );
        }
    }
}
