using System;

public class Program {
  public static void Main() {
    Aplicativo app1 = new Aplicativo { 
      Nome = "Nubank",
      Categoria = "Banco",
      Preco = 1.20
    };
    Aplicativo app2 = new Aplicativo {
      Nome = "Instagram",
      Categoria = "Comunicação",
      Preco = 0.80
    };
    Aplicativo app3 = new Aplicativo {
      Nome = "Netflix",
      Categoria = "Entretenimento",
      Preco = 2.50
    };
    Loja x = new Loja { Nome = "AppStore" };
    x.Inserir(app1);
    x.Inserir(app2);
    x.Inserir(app3);

    Console.WriteLine($"\n------ {x.Nome} -----\n");
    
    Console.WriteLine("------ Lista de APP(s) -----");
    foreach (Aplicativo i in x.Listar())
      Console.WriteLine(i);

    Console.WriteLine("\nInforme a categoria que deseja pesquisar:");
    string c = Console.ReadLine();
    Console.WriteLine($"\n------ Lista de categoria(s) -----");
    foreach (Aplicativo i in x.Pesquisar(c))
      Console.WriteLine(i);

    Console.WriteLine("\n----- Quantidade de APP(s) -----");
    Console.WriteLine(x.Qtd);
  }
}

class Loja {
  private Aplicativo[] apps = new Aplicativo[1];
  private int k = 0, qtd = 0;
  public string Nome { get; set; }
  public int Qtd { get { return qtd; } }
  public void Inserir(Aplicativo app) {
    if (k == apps.Length)
      Array.Resize(ref apps, 2 * apps.Length);
    apps[k++] = app;
    qtd++;
  }
  public void Excluir(Aplicativo app) {
    for (int i = 0; i < apps.Length; i++) {
      if (apps[i] == app) {
        apps[i] = null;
      }
    }
    qtd--;
  }
  public Aplicativo[] Listar() {
    Aplicativo[] vetor = new Aplicativo[k];
    Array.Copy(apps, vetor, k);
    return vetor;
  }
  public Aplicativo[] Pesquisar(string cat) {
    int j = 0;
    foreach (Aplicativo i in Listar()) {
      if (i.Categoria == cat) {
        j++;
      }
    }
    int m = 0;
    Aplicativo[] n = new Aplicativo[j];
    foreach (Aplicativo i in Listar()) {
      if (i.Categoria == cat) {
        n[m++] = i;
      }
    }
    return n;
  }
}

class Aplicativo {
  private int curtidas;
  public string Nome { get; set; }
  public string Categoria { get; set; }
  public double Preco { get; set; }
  public int Curtidas { get { return curtidas; } }
  public void Curtir() {
    curtidas++;
  }
  public override string ToString() {
    return $"App: {Nome} | Categoria: {Categoria} | Valor: {Preco:0.00} R$";
  }
}