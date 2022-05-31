/*
Our football team finished the championship. The result of each match look like "x:y". Results of all matches are recorded in the collection.

For example: ["3:1", "2:2", "0:1", ...]

Write a function that takes such collection and counts the points of our team in the championship. Rules for counting points for each match:

    if x > y: 3 points
    if x < y: 0 point
    if x = y: 1 point

Notes:
    there are 10 matches in the championship
    0 <= x <= 4
    0 <= y <= 4
*/

public class Kata {

        public static int TotalPoints(string[] games)
        {
            int points =0;
            foreach (string score in games) {
                string[] result = score.Split(":");
                int p1 =  Int32.Parse(result[0]);
                int p2 =  Int32.Parse(result[1]);
                points += p1 > p2 ? 3 : p1 < p2 ? 0 : 1;
                Console.WriteLine($"{p1} vs {p2} : points: {points}");
            }
        return points;
        }

    static void Main(string[] args)
    {
        Console.WriteLine(TotalPoints(new[] { "1:0", "2:0", "3:0", "4:0", "2:1", "1:3", "1:4", "2:3", "2:4", "3:4" }));
    }
}