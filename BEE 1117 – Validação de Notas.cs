using System;

public class program {
  public static void Main(String[] args) {
    int cont = 0;
    double media = 0;

    while (cont != 2) {
      double nota = double.Parse(Console.ReadLine());
      if (nota >= 0 && nota <= 10) {
        cont++;
        media = media + nota;
      } else Console.WriteLine("nota invalida");
    }

    double med = media / 2;
    Console.WriteLine($"media = {med:0.00}");
  }
}