using System;

class Program {
  public static void Main() {
    Compromisso c1 = new Compromisso {
      Assunto = "Avaliação de Algoritmos",
      Local = "Lab. 05",
      Data = DateTime.Parse("2022-11-30")
    };
    Compromisso c2 = new Compromisso {
      Assunto = "Avaliação de POO",
      Local = "Lab. 04",
      Data = DateTime.Parse("2022-12-07")
    };
    Compromisso c3 = new Compromisso {
      Assunto = "Meu aniversário",
      Local = "Minha casa",
      Data = DateTime.Parse("2022-10-19")
    };
    
    Agenda x = new Agenda();
    x.Inserir(c1);
    x.Inserir(c2);
    x.Inserir(c3);
    Console.WriteLine("Lista de compromissos: ");
    foreach(Compromisso c in x.Listar())
      Console.WriteLine(c);
    Console.WriteLine("\n-------------------------\n");
    Console.WriteLine("Informe o mês e o ano que deseja pesquisar:");
    int m = int.Parse(Console.ReadLine());
    int a = int.Parse(Console.ReadLine());
    Console.WriteLine("Lista de pesquisa: ");
    foreach(Compromisso i in x.Pesquisar(m, a))
      Console.WriteLine(i);
    Console.WriteLine("\n-------------------------");
    // x.Excluir(c2); -> para excluir um compromisso
  }  
}

class Agenda {
  private Compromisso[] comps = new Compromisso[1];
  private int k = 0;
  public int Qtd {
    get { return k; }
  }
  public void Inserir(Compromisso c) {
    if (k == comps.Length)
      Array.Resize(ref comps, 2 * comps.Length);
    comps[k++] = c;
  }
  public void Excluir(Compromisso c) {
    for (int i = 0; i < comps.Length; i++) {
      if (comps[i] == c) {
        comps[i] = null;
      }
    }
  }
  public Compromisso[] Listar() {
    Compromisso[] vetor = new Compromisso[k];
    Array.Copy(comps, vetor, k);
    return vetor;
  }
  public Compromisso[] Pesquisar(int mes, int ano) {
    int j = 0;
    foreach (Compromisso i in Listar()) {
      if (i != null) {
        if (i.Data.Month == mes && i.Data.Year == ano) {
          j++;
        }
      }
    }
    int m = 0;
    Compromisso[] r = new Compromisso[j];
    foreach (Compromisso i in Listar()) {
      if (i != null) {
        if (i.Data.Month == mes && i.Data.Year == ano) {
          r[m++] = i;
        }
      }
    }
    return r;
  }
}

class Compromisso {
  public string Assunto { get; set; }
  public string Local { get; set; }
  public DateTime Data { get; set; }
  public override string ToString() {
    return $"Assunto: {Assunto} | Local: {Local} | Data: {Data:dd/MM/yyyy}";
  }
}