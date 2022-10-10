using System;

public class program {
  public static void Main(String[] args) {
    string nome = Console.ReadLine();
    double salario = double.Parse(Console.ReadLine());
    double vendas = double.Parse(Console.ReadLine());

    double bonus = vendas * 0.15;
    double total = salario + bonus;

    Console.WriteLine($"TOTAL = R$ {total:0.00}");
  }
}