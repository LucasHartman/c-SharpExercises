/*
There was a test in your class and you passed it. Congratulations!
But you're an ambitious person. 
You want to know if you're better than the average student in your class.

You receive an array with your peers' test scores. 
Now calculate the average and compare your score!

Return True if you're better, else False!
Note:
Your points are not included in the array of your class's points. 
For calculating the average point you may add your point to the given array!
*/

public class Kata
{
    public static bool BetterThanAverage(int[] ClassPoints, int YourPoints)
    {
        int sum=0;
        foreach(int x in ClassPoints) 
        {
        sum += x;    
        }
        return (YourPoints > sum/ClassPoints.Length) ? true : false; 
    }

    public static bool BetterThanAverage2(int[] ClassPoints, int YourPoints) => YourPoints > ClassPoints.Average();

    static void Main(string[] args)
    {
    Console.WriteLine(BetterThanAverage2(new int[]{2,3}, 5));
    }
}