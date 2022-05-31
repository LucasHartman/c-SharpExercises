using System;

public class Kata {

  public static bool Check(object[] a, object x)
  {
    return Array.Exists(a,element => $"{element}" == $"{x}");
  }

  public static bool Check2(object[] a, object x ) => Array.Exists(a,element => $"{element}" == $"{x}");

public static bool Check3(object[] a, object v) => a.Contains(v);
  static void Main(string[] args)
  {
      Console.WriteLine(Check2(new object[] { 66, 101 }, 66));
  }
}