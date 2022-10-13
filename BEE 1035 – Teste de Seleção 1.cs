using System;

public class program {
  public static void Main(String[] args) {
    String input = Console.ReadLine();
    String[] entrada = input.Split();

    int a = int.Parse(entrada[0]);
    int b = int.Parse(entrada[1]);
    int c = int.Parse(entrada[2]);
    int d = int.Parse(entrada[3]);

    if (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0) {
      Console.WriteLine("Valores aceitos");  
    } else {
      Console.WriteLine("Valores nao aceitos");
    }
  }  
}