using System;

public class program {
  public static void Main(String[] args) {
    String input = Console.ReadLine();
    String[] aposta = input.Split();

    int a1 = int.Parse(aposta[0]);
    int a2 = int.Parse(aposta[1]);
    int a3 = int.Parse(aposta[2]);
    int a4 = int.Parse(aposta[3]);
    int a5 = int.Parse(aposta[4]);
    int a6 = int.Parse(aposta[5]);

    String entrada = Console.ReadLine();
    String[] sorteio = entrada.Split();

    int s1 = int.Parse(sorteio[0]);
    int s2 = int.Parse(sorteio[1]);
    int s3 = int.Parse(sorteio[2]);
    int s4 = int.Parse(sorteio[3]);
    int s5 = int.Parse(sorteio[4]);
    int s6 = int.Parse(sorteio[5]);

    int acertos = 0;

    if (a1 == s1 || a1 == s2 || a1 == s3 || a1 == s4 || a1 == s5 || a1 == s6) {
      acertos++;
    } 
    if (a2 == s1 || a2 == s2 || a2 == s3 || a2 == s4 || a2 == s5 || a2 == s6) {
      acertos++;
    } 
    if (a3 == s1 || a3 == s2 || a3 == s3 || a3 == s4 || a3 == s5 || a3 == s6) {
      acertos++;
    } 
    if (a4 == s1 || a4 == s2 || a4 == s3 || a4 == s4 || a4 == s5 || a4 == s6) {
      acertos++;
    } 
    if (a5 == s1 || a5 == s2 || a5 == s3 || a5 == s4 || a5 == s5 || a5 == s6) {
      acertos++;
    } 
    if (a6 == s1 || a6 == s2 || a6 == s3 || a6 == s4 || a6 == s5 || a6 == s6) {
      acertos++;
    }

    if (acertos < 3) {
      Console.WriteLine("azar");
    } else if (acertos == 3) {
      Console.WriteLine("terno");
    } else if (acertos == 4) {
      Console.WriteLine("quadra");
    } else if (acertos == 5) {
      Console.WriteLine("quina");
    } else if (acertos == 6) {
      Console.WriteLine("sena");
    }
  }
}