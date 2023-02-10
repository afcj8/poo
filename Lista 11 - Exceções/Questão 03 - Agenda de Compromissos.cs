using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Compromisso a = new Compromisso{Assunto = "Prova de IHC", Local = "Lab. 07", Data = DateTime.Parse("09/01/2023")};
    Compromisso b = new Compromisso{Assunto = "Prova de POO", Local = "Lab. 04", Data = DateTime.Parse("11/12/2022")};
    Compromisso c = new Compromisso{Assunto = "Prova de SO ", Local = "Lab. 05", Data = DateTime.Parse("12/11/2022")};
    Agenda x = new Agenda();
    x.Inserir(a);
    x.Inserir(b);
    x.Inserir(c);
    // x.Inserir(b); -> para gerar a exceção 

    Console.WriteLine("----------------- Lista de Compromissos -----------------");
    foreach(Compromisso i in x.Listar())
      Console.WriteLine(i);
    Console.WriteLine();
    Console.WriteLine($"Qtd de elementos: {x.Qtd}");
    Console.WriteLine();

    // x.Excluir(b)  -> para excluir o compromisso b

    Console.Write("Informe o mês: ");
    int m = int.Parse(Console.ReadLine());
    Console.Write("Informe o ano: ");
    int y = int.Parse(Console.ReadLine());

    foreach(Compromisso i in x.Pesquisar(m, y))
      Console.WriteLine(i);
  }
}

class Agenda {
  private List<Compromisso> comps = new List<Compromisso>();
  public int Qtd { get { return comps.Count; } }
  public void Inserir(Compromisso c) {
    if (comps.IndexOf(c) != -1) { 
      throw new InvalidOperationException("Compromisso já inserido na agenda!");
    }
    comps.Add(c);
  }
  public void Excluir(Compromisso c) {
    comps.Remove(c);
  }
  public List<Compromisso> Listar() {
    return comps;
  }
  public List<Compromisso> Pesquisar(int mes, int ano) {
    List<Compromisso> aux = new List<Compromisso>();
    foreach (Compromisso i in comps)
      if (i.Data.Month == mes && i.Data.Year == ano)
        aux.Add(i);
    return aux;
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"Assunto: {Assunto} | Local: {Local} | Data: {Data:dd/MM/yyyy}";
  }
}