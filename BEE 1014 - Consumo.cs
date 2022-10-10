using System;

public class program {
  public static void Main(String[] args) {

    int distancia = int.Parse(Console.ReadLine());
    double combustivel = double.Parse(Console.ReadLine());

    double consumo = distancia / combustivel;

    Console.WriteLine($"{consumo:0.000}" + " km/l");
  }
}