using System;

public class Program {
  public static void Main() {
    Retangulo r = new Retangulo();
    Console.WriteLine("Informe o valor da base:");
    r.Base = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor da altura:");
    r.Altura = Double.Parse(Console.ReadLine());
    Console.WriteLine($"Área    : {r.Area:0.00}");
    Console.WriteLine($"Diagonal: {r.Diagonal:0.00}");
  }
}

class Retangulo {
  private double b = 1, h = 1;
  public double Base {
    get { return b; }
    set { if (value > 0) b = value; }
  }
  public double Altura {
    get { return h; }
    set { if (value > 0) h = value; }
  }
  public double Area {
    get {return b * h / 2; }
  }
  public double Diagonal {
    get { return Math.Sqrt((b * b) + (h * h)); }
  }
  public override string ToString() {
    return $"Base: {b} | Altura: {h} | Área: {Area:0.00} | Diagonal: {Diagonal:0.00}";
  }
}