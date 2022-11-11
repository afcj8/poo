using System;

public class Program {
  public static void Main() {
    Conversor c = new Conversor();
    Console.WriteLine("Digite um número em decimal:");
    c.SetNum(int.Parse(Console.ReadLine()));  // Ler o valor em decimal
    Console.WriteLine($"Equivalente em Binário: {c.Binario()}\n");
    Console.WriteLine(c.ToString());
  }
}

class Conversor {
  private int num;
  public Conversor() { }
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
    int x = num;
    while (x != 0) {
      s = x % 2 + s;
      x = x / 2;
    }
    return s;
  }
  public override string ToString() {
    return $"({num})10 = ({Binario()})2";
  }
}