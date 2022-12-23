using System;

public class Program {
  public static void Main() {
    Pais p1 = new Pais("Brasil", 10, 10, 8);
    Pais p2 = new Pais("EUA", 6, 8, 3);
    Pais p3 = new Pais("China", 6, 5, 3);
    Pais p4 = new Pais("Inglaterra", 8, 5, 6);
    QuadroMedalhas qm = new QuadroMedalhas();
    qm.Inserir(p1);
    qm.Inserir(p2);
    qm.Inserir(p3);
    qm.Inserir(p4);
    Array.Sort(qm.Listar());
    Array.Reverse(qm.Listar());
    
    foreach (Pais i in qm.Listar())
      Console.WriteLine(i);
  }
}

class Pais : IComparable {
  private string nome;
  private int ouro, prata, bronze;
  public Pais(string n, int o, int p, int b) {
    nome = n;
    ouro = o;
    prata = p;
    bronze = b;
  }
  public int CompareTo(object obj) {
    Pais x = (Pais) obj;
    if ((this.ouro.CompareTo(x.ouro)) == 0) {
      if ((this.prata.CompareTo(x.prata)) == 0) {
        if ((this.bronze.CompareTo(x.bronze)) == 0) {
          if ((this.nome.CompareTo(x.nome)) == 1) {
            return -1;
          } else {
            return 1;
          }
        } else {
          return this.bronze.CompareTo(x.bronze);
        }
      } else {
        return this.prata.CompareTo(x.prata);
      }  
    } else {
      return this.ouro.CompareTo(x.ouro);
    }
  }
  public override string ToString() {
    return $"Nome: {nome} | Ouro: {ouro} | Prata: {prata} | Bronze: {bronze}";
  }
}

class QuadroMedalhas {
  private Pais[] paises = new Pais[1];
  private int k;
  public void Inserir(Pais p) {
    if(k==paises.Length) {
      Array.Resize(ref paises, 1 + paises.Length);
    }
    paises[k++] = p;
  }
  public Pais[] Listar() {
    return paises;
  }
}