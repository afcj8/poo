using System;

public class Program {
  public static void Main() {
    App app1 = new App("Netflix  ", "Entretenimento", 35.59);
    App app2 = new App("Instagram", "Comunicação   ", 2.49);
    App app3 = new App("Nubank   ", "Banco         ", 5.00);
    App app4 = new App("Kabum    ", "Tecnologia    ", 3.49);

    Pilha<App> a = new Pilha<App>();
    a.Push(app1);
    a.Push(app2);
    a.Push(app3);
    a.Push(app4);

    Console.WriteLine("------------ Lista de Apps ------------\n");
    foreach (App i in a.Listar())
      Console.WriteLine(i);

    Console.WriteLine();
    Console.WriteLine($"Nº de elementos: {a.Count}");
    Console.WriteLine();
    Console.WriteLine($"Último elemento: {a.Peek()}");

    a.Pop();  // Remove o último elemento (penúltimo elemento passa a ser o último)

    Console.WriteLine("\n------------ Lista de Apps ------------\n");
    foreach (App i in a.Listar())
      Console.WriteLine(i);

    Console.WriteLine();
    Console.WriteLine($"Nº de elementos: {a.Count}");
    Console.WriteLine();
    Console.WriteLine($"Último elemento: {a.Peek()}");

    a.Clear(); // Remove todos os elementos da lista
    
    Console.WriteLine("\n------------ Lista de Apps ------------\n");
    foreach (App i in a.Listar())
      Console.WriteLine(i);

    Console.WriteLine($"Nº de elementos: {a.Count}");
  }
}

class App {
  private string nome, categoria;
  private double preco;
  public App(string n, string c, double p) {
    if (n != "") nome = n;
    if (c != "") categoria = c;
    if (p > 0) preco = p;
  }
  public void SetNome(string n) {
    if (n != "") nome = n;
  }
  public void SetCategoria(string c) {
    if (c != "") categoria = c;
  }
  public void SetPrco(double p) {
    if (p > 0) preco = p;
  }
  public string GetNome() {
    return nome;
  }
  public string GetCategoria() {
    return categoria;
  }
  public double GetPreco() {
    return preco;
  }
  public override string ToString() {
    return $"{nome} | {categoria} | {preco:0.00}";
  }
}

class Pilha<T> {
  private T[] objs = new T[1];
  private int k;
  public int Count { get { return k; } }  // Retorna o número de elementos da pilha
  public void Clear() {
    k = 0;
  }
  public T[] Listar() {
    T[] vetor = new T[k];
    Array.Copy(objs, vetor, k);
    return vetor;
  }
  public T Peek() {
    T x = objs[k - 1];
    return x;
  }
  public void Push(T obj) {
    if(k == objs.Length)
      Array.Resize(ref objs, 2 * objs.Length);
    objs[k++] = obj;
  }
  public T Pop() {
    if (k > 0) k--;
    return objs[k];
  }
}