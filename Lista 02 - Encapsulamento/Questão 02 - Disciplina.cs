using System;

public class Program {
  public static void Main() {
    Disciplina x = new Disciplina();
    Console.WriteLine("Qual o nome da disciplina?");
    x.SetNome(Console.ReadLine());  // Ler o nome da disciplina
    Console.WriteLine("Informe a nota do 1º Bimestre:");
    x.SetNota1(int.Parse(Console.ReadLine()));  // Ler o valor da primeira nota
    Console.WriteLine("Informe a nota do 2º Bimestre:");
    x.SetNota2(int.Parse(Console.ReadLine()));  // Ler o valor da segunda nota
    Console.WriteLine("Informe a nota do 3º Bimestre:");
    x.SetNota3(int.Parse(Console.ReadLine()));  // Ler o valor da terceira nota
    Console.WriteLine("Informe a nota do 4º Bimestre:");
    x.SetNota4(int.Parse(Console.ReadLine()));  // Ler o valor da quarta nota
    int mp = x.CalcMediaParcial();

    if (mp >= 60) {
      Console.WriteLine($"Média: {mp}, aluno(a) aprovado(a)");
    } else {
      Console.WriteLine($"Média: {mp}, aluno(a) em prova final");
      Console.WriteLine("Informe a nota final:");
      x.SetNotaFinal(int.Parse(Console.ReadLine()));  // Ler o valor da nota final
      int mf = x.CalcMediaFinal();
      if (mf >= 60) {
        Console.WriteLine($"Média: {mf}, aluno(a) aprovado(a)");
      } else {
        Console.WriteLine($"Média: {mf}, aluno(a) reprovado(a)");
      }
    }
  }
}

class Disciplina {
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal;
  public void SetNome(string n) {
    if (n != "") nome = n;
  }
  public string GetNome() {
    return nome;
  }
  public void SetNota1(int nota) {
    if (nota >= 0 && nota<= 100) nota1 = nota;
  }
  public void SetNota2(int nota) {
    if (nota >= 0 && nota <= 100) nota2 = nota;
  }
  public void SetNota3(int nota) {
    if (nota >= 0 && nota <= 100) nota3 = nota;
  }
  public void SetNota4(int nota) {
    if (nota >= 0 && nota <= 100) nota4 = nota;
  }
  public void SetNotaFinal(int nota) {
    if (nota >= 0 && nota <= 100) notaFinal = nota;
  }
  public int GetNota1() {
    return nota1;
  }
  public int GetNota2() {
    return nota2;
  }
  public int GetNota3() {
    return nota3;
  }
  public int GetNota4() {
    return nota4;
  }
  public int GetNotaFinal() {
    return notaFinal;
  }
  public int CalcMediaParcial() {
    int media = (nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4 * 3) / 10;
    return media;
  }
  public int CalcMediaFinal() {
    int d = CalcMediaParcial();
    int mediaFinal = (d + notaFinal) / 2;
    return mediaFinal;
  }
}