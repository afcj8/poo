using System;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("Informe no nome do paciente:");
    string p = Console.ReadLine();  // Ler o nome do paciente
    Console.WriteLine("Informe o número do CPF do paciente:");
    string cp = Console.ReadLine();  // Ler o CPF do paciente
    Console.WriteLine("Informe o número do telefone do paciente:");
    string tel = Console.ReadLine();  // Ler o número do telefone do paciente
    Console.WriteLine("Informe a data de nascimento do paciente:");
    DateTime data = DateTime.Parse(Console.ReadLine());  // Ler a data de nascimento do paciente
    Paciente x = new Paciente(p, cp, tel, data);
    Console.WriteLine(x.ToString());
    Console.WriteLine($"Idade: {x.Idade()}");
  }
}

class Paciente {
  private string nome = "Antônio", cpf = "00000000000", telefone = "00000000000";
  private DateTime nascimento;
  public Paciente() { }
  public Paciente(string n, string c, string t, DateTime nasc) {
    if (n != "") nome = n;
    if (c != "") cpf = c;
    if (t != "") telefone = t;
    nascimento = nasc;
  }
  public string Idade() {
    return $"{DateTime.Today.Year - nascimento.Year} ano(s) e {DateTime.Today.Month - nascimento.Month} mês(es)";
  }
  public override string ToString() {
    return $"Nome: {nome} | CPF: {cpf} | Telefone: {telefone} | Data de nascimento: {nascimento:dd/MM/yyyy}";
  }
}