using System;

public class program {
  public static void Main(String[] args) {
    String ped = Console.ReadLine();
    String[] distancia = ped.Split();

    int l = int.Parse(distancia[0]);
    int d = int.Parse(distancia[1]);

    String pedagio = Console.ReadLine();
    String[] custo = pedagio.Split();

    int k = int.Parse(custo[0]);
    int p = int.Parse(custo[1]);

    int x = l * k;
    int y = (l / d) * p;

    int total = x + y;

    Console.WriteLine(total);
  }
}