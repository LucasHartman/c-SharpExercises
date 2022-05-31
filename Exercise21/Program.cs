using System.Collections.Generic;

/*
Write Number in Expanded Form
You will be given a number and you will need to return 
it as a string in Expanded Form. For example:

Kata.ExpandedForm(12); # Should return "10 + 2"
Kata.ExpandedForm(42); # Should return "40 + 2"
Kata.ExpandedForm(70304); # Should return "70000 + 300 + 4"

NOTE: All numbers will be whole numbers greater than 0.
*/

public class Program
{

    public static string ExpandedForm(long num) 
    {
         Console.WriteLine($"input: {num}");
        char[] chars = num.ToString().ToCharArray();
        List<string> expanded = new List<string>();
        
        int i = 0;
        foreach(char c in chars) {
            if ( !(c=='0')) { 
                //Console.WriteLine(c);
                int zeros= chars.Length-i-1;
                string temp=c.ToString();
                for(int x=0; x<zeros; x++)
                {
                    if(zeros==0)
                    {
                        break;
                    }
                    else
                    {
                        temp += "0";
                    }
                }
                //Console.WriteLine(temp);
                 expanded.Add(temp);
            }
            i++;
        }

        string res = "";
        foreach(string v in expanded) { 
            res+= $"{v} + ";
        }

        //Console.WriteLine(res.Substring(0,res.Length-2));
        return res.Substring(0,res.Length-3);
    }

        public static string ExpandedForm2(long num) 
    {
            var str = num.ToString();
            return String.Join(" + ", str
                .Select((x, i) => char.GetNumericValue(x) * Math.Pow(10, str.Length - i - 1))
                .Where(x => x > 0));
    }



    static void Main(string[] args)
    {
        Console.WriteLine(ExpandedForm(92093403034573)); //
    }
}