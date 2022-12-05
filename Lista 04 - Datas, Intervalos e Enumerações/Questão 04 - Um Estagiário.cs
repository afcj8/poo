using System;

enum Dias {
  segunda, terca, quarta, quinta, sexta
}

enum Turno {
  matutino, vespertino, noturno
}

public class Program {
  public static void Main() {
    Console.WriteLine("Informe o nome do estagiário:");
    string e = Console.ReadLine();  // Ler o nome do estagiário
    Console.WriteLine("Informe o CPF do estagiário:");
    string cp = Console.ReadLine();  // Ler o CPF do estagiário
    Console.WriteLine("Informe o telefone do estagiário:");
    string tel = Console.ReadLine();  // Ler o telefone do estagiário
    Estagiario est = new Estagiario(e, cp, tel);
    Console.WriteLine(est.ToString());
  }
}

class Estagiario {
  private string nome = "Antônio", cpf = "00000000000", telefone = "00000000000";
  private Dias dias = Dias.segunda;
  private Turno turno = Turno.matutino;
  public Estagiario(string n, string c, string t) {
    if (n != "") nome = n;
    if (c != "") cpf = c;
    if (t != "") telefone = t;
  }
  public void SetDias(Dias d) {
    dias = d;
  }
  public void SetTurno(Turno t) {
    turno = t;
  }
  public Dias GetDias() {
    return dias;
  }
  public Turno GetTurno() {
    return turno;
  }
  public override string ToString() {
    return $"Nome: {nome} | CPF: {cpf} | Telefone: {telefone} | Dias: {dias} | Turno: {turno}";
  }
}