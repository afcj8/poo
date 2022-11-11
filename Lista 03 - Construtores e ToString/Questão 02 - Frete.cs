using System;

public class Program {
  public static void Main() {
    Frete f = new Frete();
    Console.WriteLine("Informe a distância a ser percorrida (Km):");
    f.SetDistancia(double.Parse(Console.ReadLine()));  // Ler o valor da distancia
    Console.WriteLine("Informe o peso do produto (Kg):");
    f.SetPeso(double.Parse(Console.ReadLine()));  // Ler o valor do peso
    Console.WriteLine($"Valor do frete: {f.CalcFrete():0.00} R$");
    Console.WriteLine(f.ToString());
  }
}

class Frete {
  private double distancia, peso;
  public Frete() { }
  public Frete(double d, double p) {
    if (d > 0) this.distancia = d;
    if (p > 0) this.peso = p;
  }
  public void SetDistancia(double d) {
    if (d > 0) this.distancia = d;
  }
  public void SetPeso(double p) {
    if (p > 0) this.peso = p;
  }
  public double GetDistancia() {
    return this.distancia;
  }
  public double GetPeso() {
    return this.peso;
  }
  public double CalcFrete() {
    double valor = distancia * peso * 0.01;
    return valor;
  }
  public override string ToString() {
    return $"Distância = {distancia}, Peso = {peso}";
  }
}