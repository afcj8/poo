using System;

public class Program {
  public static void Main() {
    Viagem v = new Viagem();
    v.distancia = int.Parse(Console.ReadLine());  // Ler o valor da distância
    v.tempo = int.Parse(Console.ReadLine());  // Ler o valor do tempo
    Console.WriteLine("Velocidade Média: " + v.Velocidade() + " km/h");
  }
}

class Viagem {
  public int distancia, tempo;
  public double Velocidade() {
    double vm = distancia / tempo;
    return vm;
  }
}