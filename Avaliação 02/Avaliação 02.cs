using System;
using System.Collections;

// Programa para testar 

public class Program {
  public static void Main() {
    Jogador j1 = new Jogador("Marcos", 7, 5);
    Jogador j2 = new Jogador("Danilo", 5, 3);
    Jogador j3 = new Jogador("Rafael", 9, 7);
    Jogador j4 = new Jogador("Gérson", 8, 2);
    Jogador j5 = new Jogador("Carlos", 6, 4);
    Equipe x = new Equipe("Brasil");
    x.Inserir(j1);
    x.Inserir(j2);
    x.Inserir(j3);
    x.Inserir(j4);
    x.Inserir(j5);
    Console.WriteLine("------ Listagem em ordem alfabética ------\n");
    foreach (Jogador i in x.Listar())
      Console.WriteLine(i);
    Console.WriteLine("\n-------- Listagem em ordem de gols --------\n");
    foreach (Jogador a in x.Artilheiros())
      Console.WriteLine(a);
    Console.WriteLine("\n------- Listagem em ordem de camisa -------\n");
    foreach (Jogador a in x.Camisas())
      Console.WriteLine(a);
  }
}

// Classe Equipe

class Equipe {
  public string pais;
  private int k;
  private Jogador[] jogos = new Jogador[25];
  public void Inserir(Jogador j) {
    if (k < 25)
      jogos[k++] = j;      
  }
  public Jogador[] Listar() {
    Jogador[] vetor = new Jogador[k];
    Array.Copy(jogos, vetor, k);
    Array.Sort(vetor);
    return vetor;
  }
  public Jogador[] Artilheiros() {
    int n = 3;
    if (k < 3) n = k;
    Jogador[] vetor = new Jogador[n];
    Array.Copy(jogos, vetor, n);
    Array.Sort(vetor, new JogadorGolsComp());
    return vetor;
  }
  public Jogador[] Camisas() {
    Jogador[] vetor = new Jogador[k];
    Array.Copy(jogos, vetor, k);
    Array.Sort(vetor, new JogadorCamisaComp());
    return vetor;
  }
  public Equipe(string pais) {
    this.pais = pais;
  }
  public override string ToString() {
    return $"País: {pais} | Qtd de jogador(es): {k}";
  }
}

// Classe Jogador

class Jogador : IComparable {
  private string nome;
  private int camisa, numGols;
  public Jogador(string nome, int camisa, int numGols) {
    this.nome = nome;
    this.camisa = camisa;
    this.numGols = numGols;
  }
  public string Nome { 
    get { return nome; }
    set { nome = value; }
  }
  public int Camisa {
    get { return camisa; }
    set { camisa = value; }
  }
  public int NumGols {
    get { return numGols; }
    set { numGols = value; }
  }
  
  public int CompareTo(object obj) {
    return nome.CompareTo(((Jogador)obj).nome);
  }
  public override string ToString() {
    return $"Nome: {nome} | Camisa: {camisa} | Nº de gols: {numGols}";
  }
}

// IComparer

class JogadorGolsComp : IComparer {
  public int Compare(object x, object y) {
    return -((Jogador)x).NumGols.CompareTo(((Jogador)y).NumGols);
  }
}

class JogadorCamisaComp : IComparer {
  public int Compare(object x, object y) {
    return ((Jogador)x).Camisa.CompareTo(((Jogador)y).Camisa);
  }
}