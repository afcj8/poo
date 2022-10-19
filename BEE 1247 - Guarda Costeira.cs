using System;

public class program {
  public static void Main(String[] args) {
    string s = Console.ReadLine();

    while (string.IsNullOrEmpty(s) == false) {
      String[] v = s.Split();
      int d = int.Parse(v[0]);
      int vf = int.Parse(v[1]);
      int vg = int.Parse(v[2]);

      double tf = 12.0 / vf;
      double tg = Math.Sqrt(12 * 12 + d * d) / vg;

      if (tg <= tf) Console.WriteLine("S");
      else Console.WriteLine("N");

      s = Console.ReadLine();
    }
  }
}


// Em C#, IsNullOrEmpty() é um método de string. É usado para verificar se a string especificada é nula ou uma string vazia.