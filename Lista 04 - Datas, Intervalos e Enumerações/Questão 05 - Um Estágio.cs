using System;
using System.Globalization;
using System.Threading;

enum SituacaoEstagio {
  cadastrado, iniciado, cancelado, finalizado
}

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Console.WriteLine("Informe o nome do estagiário:");
    string nome = Console.ReadLine();  // Ler o nome do estagiário
    Console.WriteLine("Informe o nome da empresa:");
    string em = Console.ReadLine();  // Ler o nome da empresa
    Estagio e = new Estagio(nome, em);
    Console.WriteLine("Informe a data de início:");
    e.Iniciar(DateTime.Parse(Console.ReadLine()));  // Ler a data de início
    Console.WriteLine("Informe a data de término:");
    e.Finalizar(DateTime.Parse(Console.ReadLine()));  // Ler a data de término
    Console.WriteLine(e.ToString());
  }
}

class Estagio {
  private string estagio = "Antônio", empresa = "Catolé";
  private DateTime dataInicio, dataCancelamento, dataFim;
  private SituacaoEstagio situacao;
  public Estagio(string est, string emp) {
    if (est != "") estagio = est;
    if (emp != "") empresa = emp;
    situacao = SituacaoEstagio.cadastrado;
  }
  public bool Iniciar(DateTime data) {
    if (Situacao() == SituacaoEstagio.cadastrado) {
      situacao = SituacaoEstagio.iniciado;
      dataInicio = data;
      return true;
    }
    return false;
  } 
  public bool Cancelar(DateTime data) {
    if (Situacao() == SituacaoEstagio.iniciado) {
      dataCancelamento = data;
      situacao = SituacaoEstagio.cancelado;
      return true;
    }
    return false;
  }
  public bool Finalizar(DateTime data) {
    if (Situacao() == SituacaoEstagio.iniciado) {
      dataFim = data;
      situacao = SituacaoEstagio.finalizado;
      return true;
    }
    return false;
  }
  public TimeSpan TempoEstagio() {
    if (Situacao() == SituacaoEstagio.iniciado) {
      return DateTime.Today - dataInicio;
    } 
    if (Situacao() == SituacaoEstagio.cancelado) {
      return dataCancelamento - dataInicio;
    } 
    if (Situacao() == SituacaoEstagio.finalizado) {
      return dataFim - dataInicio;
    } 
    else {
      return DateTime.Today - DateTime.Today;
    }
  }
  public SituacaoEstagio Situacao() {
    return situacao;
  }
  public override string ToString() {
    return $"Nome: {estagio} | Empresa: {empresa} | Status: {Situacao()} | Tempo: {TempoEstagio().Days} dia(s)";
  }
}