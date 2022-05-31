/*
Sum all the numbers of a given array ( cq. list ), 
except the highest and the lowest element ( by value, not by index! ).

The highest or lowest element respectively is a single element at each edge, 
even if there are more than one with the same value.

Mind the input validation.
Example

{ 6, 2, 1, 8, 10 } => 16
{ 1, 1, 11, 2, 3 } => 6

Input validation

If an empty value ( null, None, Nothing etc. ) is given instead of an array, or the given array is an empty list or a list with only 1 element, return 0.
*/

public class Kata 
{
    public static int Sum(int[] numbers)
    {
        if( (numbers == null) || !numbers.Any() || numbers.Length == 1)
        {
            Console.WriteLine("There's no data");
            return 0;
        }
        else
        {
            Array.Sort(numbers);
            int[] arr = new int[numbers.Length-2];
            for(int i=1; i<=arr.Length; i++) { 
                arr[i-1] = numbers[i];
            }
            return arr.Sum();
        }   
    }

    public static int Sum2(int[] numbers) => ( numbers == null) || !numbers.Any() ? 0 : numbers.Except(new int[]{numbers.Max()}).Except(new int[]{numbers.Min()}).ToArray().Sum();

    static void Main(string[] args)
    {
        Console.WriteLine(Sum(new int[] {3}));
    }
}