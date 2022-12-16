using System;

public class Program {
  public static void Main() {
    object x = 10;
    object y = "C#";
    object z = 8.1;
    object w = "Python";
    Colecao c = new Colecao(4);
    c.Inserir(x);
    c.Inserir(y);
    c.Inserir(z);
    c.Inserir(w);
    foreach(object i in c.Listar())
      Console.WriteLine(i);
    Console.WriteLine();
    Console.Write($"Número de elementos inseridos: {c.NumItens()}");
  }
}

class Colecao {
  private object[] itens = new object[1];
  private int max, k = 0;
  public Colecao(int max) {
    this.max = max;
    itens = new object[max];
  }
  public void Inserir(object item) {
    if (k == itens.Length) {
      Array.Resize(ref itens, 2 * itens.Length);
    }
    itens[k++] = item;
  }
  public object[] Listar() {
    object[] r = new object[k];
    Array.Copy(itens, r, k);
    return r;
  }
  public int NumItens() {
    return k;
  }
}