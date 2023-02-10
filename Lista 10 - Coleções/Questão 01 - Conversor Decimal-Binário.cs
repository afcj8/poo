using System;
using System.Collections.Generic;

public class Program {
  public static void Main() {
    Console.Write("Informe o número a ser convertido: ");
    int n = int.Parse(Console.ReadLine());
    Conversor x = new Conversor(n);
    Console.WriteLine();
    Console.WriteLine(x.ToString());
  }
}

class Conversor {
  private int num;
  private Stack<int> pilha = new Stack<int>();
  public Conversor(int num) {
    if (num >= 0) this.num = num;
  }
  public void SetNum(int num) {
    if (num >= 0) this.num = num;
  }
  public int GetNum() {
    return this.num;
  }
  public string Binario() {
    string s = "";
    int x;
    while (num != 0) {
      x = num % 2;
      pilha.Push(x);
      num = num / 2;
    }
    while (pilha.Count > 0) {
      s = s + pilha.Pop();
    }
    return s;
  }
  public override string ToString() {
    return $"({num})10 = ({Binario()})2";
  }
}