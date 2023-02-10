using System;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    try {
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
      Console.WriteLine($"Idade: {x.Idade}");
    }
    catch (ArgumentOutOfRangeException erro) {
      Console.WriteLine("Erro: " + erro.Message);
    }
  }
}

class Paciente {
  private string nome, cpf, fone;
  private DateTime nascimento;
  public string Idade { get { return $"{DateTime.Today.Year - nascimento.Year} ano(s) e {DateTime.Today.Month - nascimento.Month} mês(es)"; } }
    public Paciente(string n, string c, string t, DateTime nasc) {
    nome = n;
    cpf = c;
    fone = t;
    if (nasc.Day + 1 > DateTime.Today.Day) throw new ArgumentOutOfRangeException("Data invalida");
    else nascimento = nasc;
  }
  public override string ToString() {
    return $"Nome: {nome} | CPF: {cpf} | Telefone: {fone} | Nascimento: {nascimento:dd/MM/yyyy}";
  }
}