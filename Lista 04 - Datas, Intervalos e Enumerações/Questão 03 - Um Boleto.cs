using System;
using System.Globalization;
using System.Threading;

enum Pagamento {
  EmAberto, PagoParcial, Pago
}

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("Informe o código de barras do boleto:");
    string c = Console.ReadLine();  // Ler o código de barras
    Console.WriteLine("Informe a data de emissão do boleto:");
    DateTime de = DateTime.Parse(Console.ReadLine());  // Ler a data de emissão
    Console.WriteLine("Informe a data de vencimento do boleto:");
    DateTime dv = DateTime.Parse(Console.ReadLine());  // Ler a data de vencimento
    Console.WriteLine("Informe o valor do boleto:");
    double v = double.Parse(Console.ReadLine());  // Ler o valor do boleto
    Boleto b = new Boleto(c, de, dv, v);
    Console.WriteLine("Informe o valor que será pago do boleto:");
    b.Pagar(double.Parse(Console.ReadLine()));  // Ler o valor que será pago
    Console.WriteLine(b.ToString());
  }
}

class Boleto {
  private string codBarras = "2146.21548...";
  private DateTime dataEmissao, dataVencimento;
  private double valorBoleto, valorPago;
  private Pagamento situacaoPagamento;
  public Boleto(string cod, DateTime emissao, DateTime venc, double valor) {
    if (cod != "") codBarras = cod;
    dataEmissao = emissao;
    dataVencimento = venc;
    valorBoleto = valor;
  }
  public void Pagar(double valorPago) {
    this.valorPago = valorPago;
  }
  public Pagamento Situacao() {
    if (valorPago >= valorBoleto) {
      situacaoPagamento = Pagamento.Pago;
    } else if (valorPago > 0 && valorPago < valorBoleto) {
      situacaoPagamento = Pagamento.PagoParcial;
    } else {
      situacaoPagamento = Pagamento.EmAberto;
    }
    return situacaoPagamento;
  }
  public override string ToString() {
    return $"Valor do boleto: {valorBoleto:0.00} R$ | Valor pago: {valorPago:0.00} R$ | Status: {Situacao()}";
  }
}