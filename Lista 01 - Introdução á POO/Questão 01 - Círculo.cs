using System;

public class Program {
  public static void Main() {
    Circulo c = new Circulo();
    c.raio = double.Parse(Console.ReadLine());  // Ler o valor do raio
    Console.WriteLine("Área = " + c.CalcArea());
    Console.WriteLine("Circunferência = " + c.CalcCircunferencia());
  }
}

class Circulo {
  public double raio;
  public double CalcArea() {
    double area = Math.Pow(raio, 2) * 3.14;
    return area;
  }
  public double CalcCircunferencia() {
    double cir = 3.14 * raio * 2;
    return cir;
  }
}