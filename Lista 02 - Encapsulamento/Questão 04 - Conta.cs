using System;

public class Program {
  public static void Main() {
    Conta c = new Conta();
    Console.WriteLine("Informe o nome do cliente:");
    c.SetNome(Console.ReadLine());  // Ler o nome do cliente
    Console.WriteLine("Informe o número da conta:");
    c.SetNumero(int.Parse(Console.ReadLine()));  // Ler o número da conta
    Console.WriteLine("Informe o saldo da conta:");
    c.SetSaldo(double.Parse(Console.ReadLine()));  // Ler o saldo da conta
    Console.WriteLine("Quantia que deseja depositar:");
    c.Depositar(double.Parse(Console.ReadLine()));  // Ler o valor que deseja depositar
    Console.WriteLine("Quantia que deseja sacar:");
    c.Saque(double.Parse(Console.ReadLine()));  // Ler o valor que deseja sacar
    double s = c.Verificar();
    if (s > 0) {
      Console.WriteLine($"Saldo final: {s} R$ -> Positivo");
    } else if (s < 0) {
      Console.WriteLine($"Saldo final: {s} R$ -> Negativo"); 
    } else {
      Console.WriteLine($"Saldo final: {s} R$");
    }
  }
}

class Conta {
  private string nome;
  private int numero;
  private double saldo;
  public void SetNome(string n) {
    if (n != "") nome = n;
  }
  public string GetNome() {
    return nome;
  }
  public void SetNumero(int num) {
    if (num > 0) numero = num;
  }
  public void SetSaldo(double s) {
    if (s >= 0 || s <= 0) saldo = s;
  }
  public int GetNumero() {
    return numero;
  }
  public double GetSaldo() {
    return saldo;
  }
  public void Depositar(double valor) {
    if (valor >= 0) saldo = saldo + valor;
  }
  public void Saque(double valor) {
    if (valor >= 0) saldo = saldo - valor;
  }
  public double Verificar() {
    return saldo;
  }
}