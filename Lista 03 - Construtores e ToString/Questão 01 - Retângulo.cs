using System;

public class Program {
  public static void Main() {
    Retangulo r = new Retangulo();
    Console.WriteLine("Informe o valor da base do retângulo:");
    r.SetBase(double.Parse(Console.ReadLine()));  // Ler o valor da base
    Console.WriteLine("Informe o valor da altura do retângulo:");
    r.SetAltura(double.Parse(Console.ReadLine()));  // Ler o valor da altura
    Console.WriteLine($"Área: {r.CalcArea()}");
    Console.WriteLine($"Diagonal: {r.CalcDiagonal():0.000}");
    Console.WriteLine(r.ToString());
  }
}

class Retangulo {
  private double b, h;
  public Retangulo() { }
  public Retangulo(double b, double h) {
    if (b > 0) this.b = b;
    if (h > 0) this.h = h;
  }
  public void SetBase(double b) {
    if (b > 0) this.b = b;
  }
  public void SetAltura(double h) {
    if (h > 0) this.h = h;
  }
  public double GetBase() {
    return this.b;
  }
  public double GetAltura() {
    return this.h;
  }
  public double CalcArea() {
    double area = this.b * this.h;
    return area;
  }
  public double CalcDiagonal() {
    double d = Math.Sqrt(Math.Pow(this.b, 2) + Math.Pow(this.h, 2));
    return d;
  }
  public override string ToString() {
    return $"Base = {b}, Altura = {h}";
  }
}