using System;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Contato c1 = new Contato("Junior", "84987599207", DateTime.Parse("19/10/1998"));
    Contato c2 = new Contato("Aurora", "84981225490", DateTime.Parse("05/05/2000"));
    Agenda a = new Agenda();
    a.Inserir(c1);
    a.Inserir(c2);
    
    foreach (Contato c in a.Listar())
      Console.WriteLine(c);  // Imprime a lista de contatos
    Console.WriteLine("Informe o mês do aniversariante:");
    int x = int.Parse(Console.ReadLine());
    foreach (Contato c in a.AniversariantesMes(x))
      Console.WriteLine(c);  // Imprime os contatos correspondentes ao mês de aniversário informado 
  }
}

class Agenda {
  private Contato[] cont = new Contato[1];
  private int k = 0;
  public void Inserir(Contato c) {
    if (k == cont.Length) {
      Array.Resize(ref cont, 2 * cont.Length);
    }
    cont[k++] = c;
  }
  public Contato[] Listar() {
    Contato[] vetor = new Contato[k];
    Array.Copy(cont, vetor, k);
    return vetor;
  }
  public Contato[] AniversariantesMes(int mes) {
    int j = 0;
    foreach (Contato i in Listar())
      if (i.GetMes() == mes) {
        j++;
      }
    Contato[] r = new Contato[j];
    int l = 0;
    foreach (Contato i in Listar())
      if (i.GetMes() == mes) {
        r[l] = i;
        l++;
      }
    return r;
  }
}

class Contato {
  private string nome = "Antônio", telefone = "xxxxxxxxxxx";
  private DateTime nascimento;
  public Contato(string n, string t, DateTime nasc) {
    nome = n;
    telefone = t;
    nascimento = nasc;
  }
  public int GetMes() {
    return nascimento.Month;
  }
  public override string ToString() {
    return $"Nome: {nome} | Telefone: {telefone} | Nascimento: {nascimento:dd/MM}";
  }
}