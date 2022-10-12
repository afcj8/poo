using System;

public class program {
  public static void Main(String[] args) {
    String input = Console.ReadLine();
    String[] entrada = input.Split();

    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]);
    int c = int.Parse(entrada[2]);

    if (a < b && a < c) {
      Console.WriteLine(a);
      if (b < c) {
        Console.WriteLine(b);
        Console.WriteLine(c);
      } else {
        Console.WriteLine(c);
        Console.WriteLine(b);
      }
    } else if (b < c) {
      Console.WriteLine(b);
      if (a < c) {
        Console.WriteLine(a);
        Console.WriteLine(c);
      } else {
        Console.WriteLine(c);
        Console.WriteLine(a);
      }
    } else {
      Console.WriteLine(c);
      if (a < b) {
        Console.WriteLine(a);
        Console.WriteLine(b);
      } else {
        Console.WriteLine(b);
        Console.WriteLine(a);
      }
    }

    Console.WriteLine("");
    Console.WriteLine(a);
    Console.WriteLine(b);
    Console.WriteLine(c);
    
  }
}