using System;
using System.Collections;

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

    app1.Curtir();
    app1.Curtir();
    app1.Curtir();

    app2.Curtir();
    app2.Curtir();

    app3.Curtir();

    Console.WriteLine($"\n------ {x.Nome} -----\n");
    x.Inserir(app1);
    x.Inserir(app2);
    x.Inserir(app3);
    
    Console.WriteLine("------ Lista de APP(s) -----");
    Array.Sort(x.Listar());
    foreach (Aplicativo i in x.Listar())
      Console.WriteLine(i);

    Console.WriteLine("\nInforme a categoria que deseja pesquisar:");
    string c = Console.ReadLine();
    Console.WriteLine($"\n------ Lista de categoria(s) -----");
    foreach (Aplicativo i in x.Pesquisar(c))
      Console.WriteLine(i);

    Console.WriteLine("\n----- Quantidade de APP(s) -----");
    Console.WriteLine(x.Qtd);

    Console.WriteLine($"\n------ Lista por preço -----");
    foreach (Aplicativo i in x.ListarPreco())
      Console.WriteLine(i);

    Console.WriteLine($"\n------ Lista por curtidas -----");
    foreach (Aplicativo i in x.ListarCurtidas())
      Console.WriteLine(i);
  }
}

class Loja {
  public Aplicativo[] apps = new Aplicativo[1];
  private int k = 0, qtd = 0;
  public string Nome { get; set; }
  public int Qtd { get { return qtd; } }
  public void Inserir(Aplicativo app) {
    if (k == apps.Length)
      Array.Resize(ref apps, 2 * apps.Length);
    apps[k] = app;
    k++;
    qtd++;
  }
  public void Excluir(Aplicativo app) {
    for (int i = 0; i < apps.Length; i++) {
      if (apps[i] == app) {
        apps[i] = null;
      }
    }
  }
  public Aplicativo[] Listar() {
    int j = 0;
    foreach (Aplicativo i in apps)
      if (i != null)
        j++;

    Aplicativo[] a = new Aplicativo[j];
    int l = 0;
    foreach (Aplicativo i in apps)
      if (i != null) {
        a[l] = i;
        l++;
      }
    Array.Sort(a);
    return a;
  }
  public Aplicativo[] Pesquisar(string cat) {
    int j = 0;
    foreach (Aplicativo i in Listar())
      if (i.Categoria == cat)
        j++;

    Aplicativo[] a = new Aplicativo[j];
    int m = 0;
    foreach (Aplicativo i in Listar())
      if (i.Categoria == cat) {
        a[m] = i;
        m++;
      }
    return a;
  }
  public Aplicativo[] ListarPreco() {
    PrecoComp x = new PrecoComp();
    Aplicativo[] a = new Aplicativo[qtd];
    Array.Copy(Listar(), a, qtd);
    Array.Sort(a, x);
    return a;
  }
  public Aplicativo[] ListarCurtidas() {
    CurtidasComp x = new CurtidasComp();
    Aplicativo[] a = new Aplicativo[qtd];
    Array.Copy(Listar(), a, qtd);
    Array.Sort(a, x);
    return a;
  }
}

class Aplicativo : IComparable {
  private int curtidas;
  public string Nome { get; set; }
  public string Categoria { get; set; }
  public double Preco { get; set; }
  public int Curtidas { get { return curtidas; } }
  public void Curtir() {
    curtidas = curtidas + 1;
  }
  public int CompareTo(object obj) {
    return Nome.CompareTo(((Aplicativo)obj).Nome);
  }
  public override string ToString() {
    return $"Nome: {Nome} | Categoria: {Categoria} | Preço: {Preco} | Curtidas: {curtidas}";
  }
}

class PrecoComp : IComparer {
  public int Compare(object x, object y) {
    return ((Aplicativo)x).Preco.CompareTo(((Aplicativo)y).Preco);
  }
}

class CurtidasComp : IComparer {
  public int Compare(object x, object y) {
    return -((Aplicativo)x).Curtidas.CompareTo(((Aplicativo)y).Curtidas);
  }
}