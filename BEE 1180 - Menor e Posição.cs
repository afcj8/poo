using System;

public class Program {
  public static void Main() {
    int n = int.Parse(Console.ReadLine());  // Ler o valor do tamanho do vetor
    string[] x = Console.ReadLine().Split();
    int[] v = new int[n];
    for (int i = 0; i < n; i++) {
      v[i] = int.Parse(x[i]);  // Ler todos os valores do vetor na mesma linha
    }
    int menor = v[0];
    int indice = 0;
    for (int i = 1; i < n; i++) {
      if (v[i] < menor) {
        menor = v[i];
        indice = i;
      }
    }
    Console.WriteLine($"Menor valor: {menor}");
    Console.WriteLine($"Posicao: {indice}");
  }
}