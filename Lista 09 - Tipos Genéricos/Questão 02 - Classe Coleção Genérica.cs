using System;
using System.Collections;
using System.Globalization;
using System.Threading;

public class Program {
  public static void Main() {
    Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
    Aluno a1 = new Aluno{Nome = "Junior", Matricula = "20211014040033", Nascimento = DateTime.Parse("19-10-1998")};
    Aluno a2 = new Aluno{Nome = "Aurora", Matricula = "20221514040029", Nascimento = DateTime.Parse("05-05-2019")};
    Aluno a3 = new Aluno{Nome = "Neymar", Matricula = "20204506040075", Nascimento = DateTime.Parse("22-06-1992")};

    Colecao <Aluno> c = new Colecao<Aluno>();

    c.Add(a1);
    c.Add(a2);
    c.Add(a3);

    Console.WriteLine("\n---------- Lista de Alunos ----------\n");
    foreach (Aluno i in c.Listar())
      Console.WriteLine(i);
    Console.WriteLine();
    Console.WriteLine($"Nº de elementos: {c.Count}");

    c.Remove(a2);  // Excluí o objeto a2 da coleção

    Console.WriteLine("\n---------- Lista de Alunos ----------\n");
    foreach (Aluno i in c.Listar())
      Console.WriteLine(i);

    Console.WriteLine();
    Console.WriteLine($"Nº de elementos: {c.Count}");

    c.Sort();
    Console.WriteLine("\n---------- Ordem alfabética ---------\n");
    foreach (Aluno i in c.Listar())
      Console.WriteLine(i);
  }
}

class Aluno : IComparable, IEnumerable {
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public DateTime Nascimento { get; set; }
  public int CompareTo(object obj) {
    return Nome.CompareTo(((Aluno)obj).Nome);
  }
  public override string ToString() {
    return $"{Nome} | {Matricula} | {Nascimento:dd/MM/yyyy}";
  }
  public IEnumerator GetEnumerator() {
    return GetEnumerator();
  }
}

class Colecao <T> where T : IComparable, IEnumerable {
  private T[] objs = new T[1];
  private int k;
  public int Count { get {return k; } }
  public T[] Listar() {
    T[] vetor = new T[k];
    Array.Copy(objs, vetor, k);
    return vetor;
  }
  public void Add(T obj) {
    if(k == objs.Length)
      Array.Resize(ref objs, 1 + objs.Length);
    objs[k++] = obj;
  }
  public void Remove(T obj) {
    int index = -1;
    for (int i = 0; i < k; i++) {
      if (objs[i].Equals(obj)) {
        index = i;
      }    
    }
    for (int i = index; i < objs.Length - 1; i++) {
      objs[i] = objs[i + 1];
    }
    k--;
  }
  public void Sort() {
    Array.Sort(objs);
  }
  public IEnumerator GetEnumerator() {
    T[] aux = new T[k];
    Array.Copy(objs, aux, k);
    return aux.GetEnumerator();
  }
}