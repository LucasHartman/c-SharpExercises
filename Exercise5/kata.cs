
/*
Clock shows h hours, m minutes and s seconds after midnight.
Your task is to write a function which returns the time since midnight in milliseconds.
Example:

h = 0
m = 1
s = 1

result = 61000
*/
public class kata {
    
    public static int Past(int h, int m, int s)
    {
        string time = $"{h}:{m}:{s}";
        double seconds = TimeSpan.Parse(time).TotalMilliseconds;
        return (int)seconds;
    }

    public static int Past2(int h, int m, int s) => (int)TimeSpan.Parse($"{h}:{m}:{s}").TotalMilliseconds;

    static void Main(string[] args) {
        Console.WriteLine(kata.Past2(0,1,1));
    }
}

