using System;

public class Program {
  public static void Main() {
    Circulo c = new Circulo();
    Console.WriteLine("Digite o valor do raio:");
    c.SetRaio(double.Parse(Console.ReadLine()));  // Ler o valor do raio
    Console.WriteLine($"Valor da área: {c.CalcArea()}");
    Console.WriteLine($"Valor da circunferência: {c.CalcCircunferencia()}");
  }
}

class Circulo {
  private double raio;
  public void SetRaio(double r) {
    if (r >= 0) raio = r;
  }
  public double GetRaio() {
    return raio;
  }
  public double CalcArea() {
    double area = Math.Pow(raio, 2) * 3.14;
    return area;
  }
  public double CalcCircunferencia() {
    double circun = 3.14 * raio * 2;
    return circun;    
  }
}