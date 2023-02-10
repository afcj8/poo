using System;

public class Program {
  public static void Main() {
    Retangulo rt = new Retangulo();
    try {
      Console.Write("Informe o valor da base  : ");
      rt.SetBase(double.Parse(Console.ReadLine()));
      Console.Write("Informe o valor da altura: ");
      rt.SetAltura(double.Parse(Console.ReadLine()));
      Console.WriteLine($"Área do retângulo    : {rt.Area:0.00}");
      Console.WriteLine($"Diagonal do retângulo: {rt.Diagonal:0.00}");
    }
    catch (ArgumentOutOfRangeException erro) {
      Console.WriteLine("Erro: " + erro.Message);
    }
    catch {
      Console.WriteLine("Valor informado não é um número!");
    }
  }
}

class Retangulo {
  private double b, h;
  public double Area { get { return b * h; } }
  public double Diagonal { get { return Math.Sqrt(Math.Pow(this.b, 2) + Math.Pow(this.h, 2)); } }
  public void SetBase(double b) {
    if (b < 0) throw new ArgumentOutOfRangeException("Base inválida");
    else this.b = b;
  }
  public double GetBase() {
    return b;
  }
  public void SetAltura(double h) {
    if (h < 0) throw new ArgumentOutOfRangeException("Altura inválida");
    else this.h = h;
  }
  public double GetAltura() {
    return h;
  }
  public override string ToString() {
    return $"Base: {b} | Altura: {h} | Área: {Area:0.00} | Diagonal: {Diagonal:0.00}";
  }
}