using System;

public class Program {
  public static void Main() {
    Conta bank = new Conta();
    Console.WriteLine("Informe o nome do cliente:");
    bank.nome = Console.ReadLine();  // Ler o nome do cliente
    Console.WriteLine("Infomre o número da conta:");
    bank.numero = int.Parse(Console.ReadLine());  // Ler o número da conta
    Console.WriteLine("Informe o saldo da conta:");
    bank.saldo = double.Parse(Console.ReadLine());  // Ler o saldo da conta
    Console.WriteLine("Quantia que deseja depositar:");
    bank.Depositar(double.Parse(Console.ReadLine()));  // Ler o valor que deseja depositar
    Console.WriteLine("Quantia que deseja sacar:");
    bank.Saque(double.Parse(Console.ReadLine()));  // Ler o valor que deseja sacar
    double s = bank.Verificar();
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
  public string nome;
  public int numero;
  public double saldo;
  public void Depositar(double valor) {
    saldo = saldo + valor;
  }
  public void Saque(double valor) {
    saldo = saldo - valor;
  } 
  public double Verificar() {
    return saldo;
  }
}