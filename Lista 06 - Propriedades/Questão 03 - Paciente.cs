using System;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Paciente p = new Paciente();
    Console.WriteLine($"Informe o nome do paciente:");
    p.Nome = Console.ReadLine();
    Console.WriteLine($"Informe o CPF do paciente:");
    p.CPF = Console.ReadLine();
    Console.WriteLine($"Informe o telefone do paciente:");
    p.Telefone = Console.ReadLine();
    Console.WriteLine($"Informe a data de nascimento do paciente:");
    p.Nascimento = DateTime.Parse(Console.ReadLine());
    Console.WriteLine(p.ToString());
    Console.WriteLine($"Idade: {p.Idade}");
  }
}

class Paciente {
  private string nome = "Antônio", cpf = "xxxxxxxxxxx", telefone = "xxxxxxxxxxx";
  private DateTime nascimento;
  public string Nome {
    get { return nome; }
    set { if (value != "") nome = value; }
  }
  public string CPF {
    get { return cpf; }
    set { if (value != "") cpf = value; }
  }
  public string Telefone {
    get { return telefone; }
    set { if (value != "") telefone = value; }
  }
  public DateTime Nascimento {
    get { return nascimento; }
    set { nascimento = value; }
  }
  public string Idade {
    get { return $"{DateTime.Today.Year - nascimento.Year} ano(s) e {DateTime.Today.Month - nascimento.Month} mês(es)"; }
  }
  public override string ToString() {
    return $"Nome: {nome} | CPF: {cpf} | Telefone: {telefone} | Data de nascimento: {nascimento:dd/MM/yyyy}";
  }
}