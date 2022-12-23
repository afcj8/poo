using System;
using System.Collections;

public class Program {
  public static void Main() {
    Aluno a1 = new Aluno {
      Nome = "Junior",
      Matricula = "20211014040033", 
      Nascimento = DateTime.Parse("1998-10-19")
    };
    Aluno a2 = new Aluno {
      Nome = "Aurora",
      Matricula = "20201014040022", 
      Nascimento = DateTime.Parse("2000-05-20")
    };
    Aluno a3 = new Aluno {
      Nome = "Carlos",
      Matricula = "20221014040044", 
      Nascimento = DateTime.Parse("2001-11-14")
    };
    Aluno[] vetor = {a1, a2, a3};
    
    Array.Sort(vetor);
    Console.WriteLine("------ Ordem: alfabética ------\n");
    foreach (Aluno a in vetor)
      Console.WriteLine(a);
    Console.WriteLine("\n------ Ordem: matrícula ------\n");
    Array.Sort(vetor, new AlunoMatriculaComp());
    foreach (Aluno a in vetor)
      Console.WriteLine(a);
    Console.WriteLine("\n------ Ordem: Nascimento ------\n");
    Array.Sort(vetor, new AlunoNascimentoComp());
    foreach (Aluno a in vetor)
      Console.WriteLine(a);
  }
}

class Aluno : IComparable {
  public string Nome { get; set; }
  public string Matricula { get; set; }
  public DateTime Nascimento { get; set; }
  public int CompareTo(object obj) {
    return Nome.CompareTo(((Aluno)obj).Nome);  // Ordenar em ordem alfabética pelo nome
  }
  public override string ToString() {
    return $"Nome: {Nome} | Matricula: {Matricula} | Nascimento: {Nascimento:dd/MM/yyyy}";
  }
}
class AlunoMatriculaComp : IComparer {

  public int Compare(object x, object y) {
    return ((Aluno)x).Matricula.CompareTo(((Aluno)y).Matricula);
  }
}

class AlunoNascimentoComp : IComparer {
  public int Compare(object x, object y) {
    return ((Aluno)x).Nascimento.CompareTo(((Aluno)y).Nascimento);
  }
}