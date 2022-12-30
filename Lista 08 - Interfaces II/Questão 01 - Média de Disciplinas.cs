using System;

public class Program {
  public static void Main() {
    // ---------- Disciplina anual ----------
    IDisciplina d1 = new DisciplinaAnual("POO", 46, 50, 60, 45, 76);
    Console.WriteLine("-- Disicplina anual --");
    Console.WriteLine($"Média parcial: {d1.CalcMediaParcial()}");
    int media = d1.CalcMediaParcial();
    if (media < 60) {
      Console.WriteLine($"Média Final  : {d1.CalcMediaFinal()}");
    }
    // ---------- Disciplina semestral ----------
    IDisciplina d2 = new DisciplinaSemestral("IHC", 52, 65, 80);
    Console.WriteLine("-- Disicplina semestral --");
    Console.WriteLine($"Média parcial: {d2.CalcMediaParcial()}");
    int med = d2.CalcMediaParcial();
    if (med < 60) {
      Console.WriteLine($"Média final  : {d2.CalcMediaFinal()}");
    }
  }
}

interface IDisciplina {
  string GetNome();
  int CalcMediaParcial();
  int CalcMediaFinal();
}

class DisciplinaAnual : IDisciplina {
  private string nome;
  private int nota1, nota2, nota3, nota4, notaFinal;
  public DisciplinaAnual(string nome, int nota1, int nota2, int nota3, int nota4, int notaFinal) {
    if (nome != "") this.nome = nome;
    if (nota1 >= 0 && nota1 <= 100) this.nota1 = nota1;
    if (nota2 >= 0 && nota2 <= 100) this.nota2 = nota2;
    if (nota3 >= 0 && nota3 <= 100) this.nota3 = nota3;
    if (nota4 >= 0 && nota4 <= 100) this.nota4 = nota4;
    if (notaFinal >= 0 && notaFinal <= 100) this.notaFinal = notaFinal;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetNota1(int nota1) {
    if (nota1 >= 0 && nota1 <= 100) this.nota1 = nota1;
  }
  public void SetNota2(int nota2) {
    if (nota2 >= 0 && nota2 <= 100) this.nota2 = nota2;
  }
  public void SetNota3(int nota3) {
    if (nota3 >= 0 && nota3 <= 100) this.nota3 = nota3;
  }
  public void SetNota4(int nota4) {
    if (nota4 >= 0 && nota4 <= 100) this.nota4 = nota4;
  }
  public void SetNotaFinal(int notaFinal) {
    if (notaFinal >= 0 && notaFinal <= 100) this.notaFinal = notaFinal;
  }
  public string GetNome() {
    return nome;
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
    return (nota1 * 2 + nota2 * 2 + nota3 * 3 + nota4 * 3) / 10;
  }
  public int CalcMediaFinal() {
    int d = CalcMediaParcial();
    int mf = (d + notaFinal) / 2;
    return mf;
  }
}

class DisciplinaSemestral : IDisciplina {
  private string nome;
  private int nota1, nota2, notaFinal;
  public DisciplinaSemestral(string nome, int nota1, int nota2, int notaFinal) {
    if (nome != "") this.nome = nome;
    if (nota1 >= 0 && nota1 <= 100) this.nota1 = nota1;
    if (nota2 >= 0 && nota2 <= 100) this.nota2 = nota2;
    if (notaFinal >= 0 && notaFinal <= 100) this.notaFinal = notaFinal;
  }
  public void SetNome(string nome) {
    if (nome != "") this.nome = nome;
  }
  public void SetNota1(int nota1) {
    if (nota1 >= 0 && nota1 <= 100) this.nota1 = nota1;
  }
  public void SetNota2(int nota2) {
    if (nota2 >= 0 && nota2 <= 100) this.nota2 = nota2;
  }
  public void SetNotaFinal(int notaFinal) {
    if (notaFinal >= 0 && notaFinal <= 100) this.notaFinal = notaFinal;
  }
  public string GetNome() {
    return nome;
  }
  public int GetNota1() {
    return nota1;
  }
  public int GetNota2() {
    return nota2;
  }
  public int GetNotaFinal() {
    return notaFinal;
  }
  public int CalcMediaParcial() {
    return (nota1 * 2 + nota2 * 3) / 5;
  }
  public int CalcMediaFinal() {
    int d = CalcMediaParcial();
    int mf = (d + notaFinal) / 2;
    return mf;
  }
}