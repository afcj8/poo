using System;

public class Program {
  public static void Main() {
    Viagem v = new Viagem();
    Console.WriteLine("Informe a distancia (Km):");
    v.SetDistancia(double.Parse(Console.ReadLine()));  // Ler o valor da distância
    Console.WriteLine("Informe o tempo (h):");
    v.SetTempo(double.Parse(Console.ReadLine()));  // Ler o valor do tempo
    Console.WriteLine($"Velocidade média: {v.VelocidadeMedia()} Km/h");
  }
}

class Viagem {
  private double distancia, tempo;
  public void SetDistancia(double d) {
    if (d > 0) distancia = d;
  }
  public void SetTempo(double t) {
    if (t > 0) tempo = t;
  }
  public double GetDistancia() {
    return distancia;
  }
  public double GetTempo() {
    return tempo;
  }
  public double VelocidadeMedia() {
    double vm = distancia / tempo;
    return vm;
  }
}