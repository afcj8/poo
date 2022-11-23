using System;

public class Program {
  public static void Main() {
    Console.WriteLine("Informe os dados do 1º país:");
    string p = Console.ReadLine();  // Ler o nome
    int h = int.Parse(Console.ReadLine());  // Ler o número de habitantes
    double a = double.Parse(Console.ReadLine());  // Ler o valor da área demográfica
    Pais y = new Pais(p, h, a);
    for (int i = 2; i <= 10; i++) {
      Console.WriteLine($"Informe os dados do {i}º país:");
      string pop = Console.ReadLine();  // Ler o nome
      int hab = int.Parse(Console.ReadLine());  // Ler o número de habitantes
      double ar = double.Parse(Console.ReadLine());  // Ler o valor da área demográfica
      Pais x = new Pais(pop, hab, ar);
      if (x.Densidade() > y.Densidade()) y = x;  // Compara os países e retorna o com a maior densidade demográfica
    }
    Console.WriteLine($"{y.ToString()}");
  }
}

class Pais {
  private string nome = "Sem nome";
  private int populacao = 1;
  private double area = 1;
  public Pais(string n, int p, double a) {
    if (n != "") nome = n;
    if (p > 0) populacao = p;
    if (a > 0) area = a;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetPopulacao(int populacao) {
    if (populacao > 0) this.populacao = populacao;
  }
  public void SetArea(double area) {
    if (area > 0) this.area = area;
  }
  public string GetNome() {
    return nome;
  }
  public int GetPopulacao() {
    return populacao;
  }
  public double GetArea() {
    return area;
  }
  public double Densidade() {
    return populacao / area;
  }
  public override string ToString() {
    return $"País: {nome} | Nº de habitantes: {populacao} | Densidade: {Densidade():0.00}";
  }
}