using System;
using System.Collections.Generic;

public class Program {
  public static void Main() {
    Pais p1 = new Pais("China ", 8, 7, 6);
    Pais p2 = new Pais("México", 7, 6, 2);
    Pais p3 = new Pais("Brasil", 9, 8, 5);
    Pais p4 = new Pais("Japão ", 6, 5, 8);

    QuadroMedalhas qm = new QuadroMedalhas();
    qm.Inserir(p1);
    qm.Inserir(p2);
    qm.Inserir(p3);
    qm.Inserir(p4);

    Console.WriteLine("--------------- Classificação ---------------\n");
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
          return this.nome.CompareTo(x.nome);
        } else {
          return -this.bronze.CompareTo(x.bronze);
        }
      } else {
        return -this.prata.CompareTo(x.prata);
      }
    } else {
      return -this.ouro.CompareTo(x.ouro);
    }
  }
  public override string ToString() {
    return $"Nome: {nome} | Ouro: {ouro} | Prata: {prata} | Bronze: {bronze}";
  }
}

class QuadroMedalhas {
  private List<Pais> paises = new List<Pais>();
  public void Inserir(Pais p) {
    paises.Add(p);
  }
  public List<Pais> Listar() {
    paises.Sort();
    return paises;
  }
}