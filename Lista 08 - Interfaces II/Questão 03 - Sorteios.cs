using System;

public class Program {
  public static void Main() {
    Console.WriteLine("=============================");
    Console.WriteLine("------ Escolha um jogo ------");
    Console.WriteLine("1 - Bingo");
    Console.WriteLine("2 - Mega");
    Console.WriteLine("=============================");
    Console.WriteLine();
    Console.Write("Selecione uma opção: ");
    int op = int.Parse(Console.ReadLine());
    ISorteio jogo;
    if (op == 1) {
      Console.Write("Informe a quantidade de bolas do Bingo: ");
      int n = int.Parse(Console.ReadLine());
      jogo = new Bingo(n);
      Console.Write("{ ");
      for (int i = 0; i < n; i++) {
        Console.Write($"{jogo.Proximo()} ");
      }
      Console.WriteLine("}");
    }
    if (op == 2) {
      jogo = new Mega();
      Console.Write("{ ");
      for (int i = 0; i < 6; i++) {
        Console.Write($"{jogo.Proximo()} ");
      }
      Console.WriteLine("}");
    }
  }
} 

interface ISorteio {
  int Proximo();
  int[] Sorteados();
}

class Bingo : ISorteio {
  private int numBolas = 1;
  private int[] vetor;
  private int k;
  public Bingo(int numBolas) {
    if (numBolas > 0) this.numBolas = numBolas;
    vetor = new int[numBolas];
    k = 0;
  }
  public int Proximo() {
    Random x = new Random();
    int n = x.Next(1, numBolas + 1);  // Retorna um inteiro aleatório dentro do intervalo especifícado
    int pos = Array.IndexOf(vetor, n);  // Busca no array vetor o objeto n especifícado e retorna -1 caso não encontre 
    while (pos != -1) {
      n = x.Next(1, numBolas + 1);  
      pos = Array.IndexOf(vetor, n);
    }
    vetor[k++] = n;
    return n;
  }
  public int[] Sorteados() {
    int[] temp = new int[k];
    Array.Copy(vetor, temp, k);
    return temp;
  }
}

class Mega : ISorteio {
  private int[] vetor = new int[6];
  private int k;
  public int Proximo() {
    Random x = new Random();
    int n = x.Next(1, 61);  // Retorna um inteiro aleatório dentro do intervalo especifícado
    int pos = Array.IndexOf(vetor, n);  // Busca no array vetor o objeto n especifícado e retorna -1 caso não encontre 
    while (pos != -1) {
      n = x.Next(1, 61);
      pos = Array.IndexOf(vetor, n);
    }
    vetor[k++] = n;
    return n;
  }
  public int[] Sorteados() {
    int[] temp = new int[k];
    Array.Copy(vetor, temp, k);
    return temp;
  }
}