using System.Collections.Generic;
using System;
using System.Linq;

/*
Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.
Example 1:

a1 = ["arp", "live", "strong"]
a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns ["arp", "live", "strong"]
Example 2:

a1 = ["tarp", "mice", "bull"]
a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns []
Notes:
    Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
    In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.
    Beware: r must be without duplicates.
*/

public class Program
{
     public static string[] inArray(string[] array1, string[] array2)
     {   
        List<string> l = new List<string>();
        string[] r = {};
        
        // Compare arrays
        foreach (string so in array2)
        {
             foreach (string si in array1)
             {
                Console.WriteLine($"outer: {so}    inner: {si}     compare: {so.Contains(si)}");
                if ( so.Contains(si) ) { l.Add(si); }
             }
         }
         
        l = l.Distinct().ToList(); // l = l.Distinct().ToList();
        r = l.ToArray();
        Array.Sort(r);
        foreach (string s in r) { Console.WriteLine(s); }
        return r;
     }

    public static string[] inArray2(string[] array1, string[] array2)
    {
        return array1.Distinct()
                    .Where(s1 => array2.Any(s2 => s2.Contains(s1)))
                    .OrderBy(s => s)
                    .ToArray();
    }

    static void Main(string[] args)
    {
        Console.WriteLine(inArray( 
            new string[] {"arp", "live", "strong"}, 
            new string[] {"lively", "alive", "harp", "sharp", "armstrong"}
        ));
    }
}