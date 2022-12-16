using System;

public class Program {
  public static void Main() {
    Frete f = new Frete();
    Console.WriteLine("Informe o valor da distância em km:");
    f.Distancia = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe o valor do peso em kg:");
    f.Peso = double.Parse(Console.ReadLine());
    Console.WriteLine(f.ToString());
  }
}

class Frete {
  private double distancia = 1, peso = 1;
  public double Distancia {
    get { return distancia; }
    set { if (value > 0) distancia = value; }
  }
  public double Peso {
    get { return peso; }
    set { if (value > 0) peso = value; }
  }
  public double ValorFrete {
    get { return peso * distancia * 0.01; }
  }
  public override string ToString() {
    return $"Distância: {distancia} | Peso: {peso} | Valor do Frete: {ValorFrete:0.00} R$";
  }
}