using System;

public class program {
  public static void Main(String[] args) {
    String l1 = Console.ReadLine();
    String[] v = l1.Split();

    int v1 = int.Parse(v[0]);
    int v2 = int.Parse(v[1]);
    int v3 = int.Parse(v[2]);

    int maiorAB = (v1 + v2 + Math.Abs(v1 - v2)) / 2;
    int maiorABC = (maiorAB + v3 + Math.Abs(maiorAB - v3)) / 2;

    Console.WriteLine(maiorABC + " eh o maior");
  } 
}