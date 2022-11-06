using System;

public class Program {
  public static void Main() {
    Disciplina x = new Disciplina();
    Console.WriteLine("Informe o nome da Disciplina:");
    x.nome = Console.ReadLine();  // Ler o nome da disciplina
    Console.WriteLine("Informe a nota do 1º Bimestre:");
    x.nota1 = int.Parse(Console.ReadLine());  // Ler o valor da primeira nota
    Console.WriteLine("Informe a nota do 2º Bimestre:");
    x.nota2 = int.Parse(Console.ReadLine());  // Ler o valor da segunda nota
    Console.WriteLine("Informe a nota do 3º Bimestre:");
    x.nota3 = int.Parse(Console.ReadLine());  // Ler o valor da terceira nota
    Console.WriteLine("Informe a nota do 4º Bimestre:");
    x.nota4 = int.Parse(Console.ReadLine());  // Ler o valor da quarta nota
    double mp = x.MediaParcial();
    if (mp >= 60) {
      Console.WriteLine($"Média: {mp}, aluno(a) aprovado(a)");
    } else {
      Console.WriteLine($"Média: {mp}, aluno(a) em prova final");
      Console.WriteLine("Informe a nota final:");
      x.notaFinal = int.Parse(Console.ReadLine());  // Ler o valor da nota final
      int mf = x.MediaFinal();
      if (mf >= 60) {
        Console.WriteLine($"Média: {mf}, aluno(a) aprovado(a)");
      } else {
        Console.WriteLine($"Média: {mf}, aluno(a) reprovado(a)");
      }
    }
  }
}

class Disciplina {
  public string nome;
  public int nota1, nota2, nota3, nota4, notaFinal;
  public int MediaParcial() {
    int media = (nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4 * 3) / 10;
    return media;
  }
  public int MediaFinal() {
    int d = MediaParcial();
    int mediaFinal = (d + notaFinal) / 2;
    return mediaFinal;
  }
}