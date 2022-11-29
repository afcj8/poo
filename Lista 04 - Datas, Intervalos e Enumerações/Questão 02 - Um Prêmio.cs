using System;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("Informe o nome do cliente:");
    string nome = Console.ReadLine();  // Ler o nome do cliente
    Console.WriteLine("Informe a data de recebimento do prêmio:");
    DateTime d = DateTime.Parse(Console.ReadLine());  // Ler a data de recebimento do prêmio
    Premio p = new Premio(nome, d);
    ValeCompra vc = new ValeCompra(DateTime.Parse("31/12/2022"), 100.00);  // Vale compras
    Produto prod = new Produto("4 - Batata Pringles", 50.00);  // Produto
    Console.WriteLine("Informe o prêmio escolhido: Vale compras ou Produto?");
    string escolha = Console.ReadLine();
    
    if (escolha == "Vale compras" || escolha == "vale compras") {
      p.SetPremio("Vale compras");
      Console.WriteLine(p.ToString());
      Console.WriteLine(vc.ToString());
    } else {
      p.SetPremio("Produto");
      Console.WriteLine(p.ToString());
      Console.WriteLine(prod.ToString());
    }
  }
}

class Premio {
  private string cliente = "Antônio";
  private DateTime data;
  private object premio;
  public Premio() { }
  public Premio(string c, DateTime d) {
    if (c != "") cliente = c;
    data = d;
  }
  public void SetPremio(object p) {
    premio = p;
  }
  public object GetPremio() {
    return premio;
  }
  public override string ToString() {
    return $"Cliente : {cliente} | Recebimento: {data} | Prêmio: {premio}";
  }
}

class ValeCompra {
  private DateTime dataValidade;
  private double valor = 1;
  public ValeCompra() { }
  public ValeCompra(DateTime d, double v) {
    dataValidade = d;
    valor = v;
  }
  public override string ToString() {
    return $"Validade: {dataValidade} | Valor: {valor:0.00} R$";
  }
}

class Produto {
  private string descricao;
  private double valor = 1;
  public Produto() { }
  public Produto(string d, double v) {
    descricao = d;
    valor = v;
  }
  public override string ToString() {
    return $"Descrição do produto: {descricao} | Valor: {valor:0.00} R$";
  }
}