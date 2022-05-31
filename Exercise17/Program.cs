/*
The first century spans from the year 1     up to and including the year 100, 
the second century-     from the year 101   up to and including the year 200, etc.
Task

Given a year, return the century it is in.
Examples
1705 --> 18
1900 --> 19
1601 --> 17
2000 --> 20
*/

public class Program {

    public static int СenturyFromYear(int year)
    {
        Console.WriteLine($"input{year}");
        string str = year.ToString();
        string res ="";

        if (str.Length<=2 ) 
        {
            res="0"; 
            return Int32.Parse(res);
        } // 0 t/m 99
        else
        {
            for (int i=1; i<str.Length; i++)
            {
                res= str.Substring(0,i-1);
                Console.WriteLine($"loop{i} - Century: {res}");
            }
            return (Int32.Parse(str[str.Length-1].ToString())>0 && str.Length>2) ? Int32.Parse(res) +1 : Int32.Parse(res);
        }
    }




    static void Main()
    {
        Console.WriteLine(СenturyFromYear(101064)); // 18
    }
}

