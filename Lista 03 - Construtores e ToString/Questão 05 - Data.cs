using System;

public class Program {
  public static void Main() {
    Data d = new Data();
    Console.WriteLine("Informe o dia:");
    d.SetDia(int.Parse(Console.ReadLine()));  // Ler o dia
    Console.WriteLine("Informe o mes:");
    d.SetMes(int.Parse(Console.ReadLine()));  // Ler o mês
    Console.WriteLine("Informe o ano:");
    d.SetAno(int.Parse(Console.ReadLine()));  // Ler o ano
    Console.WriteLine($"Data: {d.ToString()}");
  }
}

class Data {
  private int dia, mes, ano;
  public Data() { }
  public Data (int dia, int mes, int ano) {
    if (dia >= 1 && dia <= 30) this.dia = dia;
    if (mes >= 1 && mes <= 12) this.mes = mes;
    if (ano > 0) this.ano = ano;
  }
  public void SetDia(int dia) {
    if (dia >= 1 && dia <= 30) this.dia = dia;
  }
  public void SetMes(int mes) {
    if (mes >= 1 && mes <= 12) this.mes = mes;
  }
  public void SetAno(int ano) {
    if (ano > 0) this.ano = ano;
  }
  public int GetDia() {
    return this.dia;
  }
  public int GetMes() {
    return this.mes;
  }
  public int GetAno() {
    return this.ano;
  }
  public override string ToString() {
    return $"{dia:00}/{mes:00}/{ano:0000}";
  }
}