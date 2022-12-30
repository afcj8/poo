using System;

public class Program {
  public static void Main() {
    Console.WriteLine("--- PA ---");
    ISequencia y = new PA(3, 2);
    Console.Write("{ ");
    Console.Write($"{y.Iniciar()} ");
    for (int i = 0; i < 10; i++) {
      Console.Write($"{y.Proximo()} ");
    }
    Console.Write("}");
    Console.WriteLine("\n--- Fibonacci ---");
    ISequencia x = new Fibonacci(0, 1);
    Console.Write("{ ");
    Console.Write($"{x.Iniciar()} ");
    for (int j = 0; j < 10; j++) {
      Console.Write($"{x.Proximo()} ");
    }
    Console.Write("}");
  }
}

interface ISequencia {
  int Iniciar();
  int Proximo();
}

class Fibonacci : ISequencia {
  private int primeiroElemento = 0;
  private int segundoElemento = 1;
  public Fibonacci(int p, int s) {
    this.primeiroElemento = p;
    this.segundoElemento = s;
  }
  public int Iniciar() {
    return primeiroElemento;
  }
  public int Proximo() {
    int aux = segundoElemento;
    segundoElemento += primeiroElemento;
    primeiroElemento = aux;
    return aux;
  }
}

class PA : ISequencia {
  private int primeiroElemento, razao;
  public PA(int p, int r) {
    this.primeiroElemento = p;
    this.razao = r;
  }
  public int Iniciar() {
    return primeiroElemento;
  }
  public int Proximo() {
    primeiroElemento += razao;
    return primeiroElemento;
  }
}