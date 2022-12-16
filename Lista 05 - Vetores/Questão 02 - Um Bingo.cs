using System;

class Program {
  public static void Main() {
    Bingo b = new Bingo();
    Console.Write("Bolas sorteadas: {");
    foreach (int i in b.Sorteados())
      Console.Write($" {i}");
    Console.Write(" }");
  }
}

class Bingo {
  private int[] vetor = new int[10];
  private int k = 0;
  public Bingo() {
    Random x = new Random();
    while (k < 10) {
      int n = x.Next(1, 11);
      if (Array.IndexOf(vetor, n) == -1) {
        vetor[k] = n;
        k++;
      }
    }
    k = 0;
  }
  public int Sortear() {
    if (k == 10) return -1;
    int n = vetor[k];
    k++;
    return n;
  }
  public int[] Sorteados() {
    return vetor;
  }
}