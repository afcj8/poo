using System;

public class Program {
  public static void Main() {
    double[] v = new double[100];
    for (int i = 0; i < 100; i++) {
      v[i] = double.Parse(Console.ReadLine());
      if (v[i] <= 10) {
        Console.WriteLine($"A[{i}] = {v[i]:0.0}");
      }
    }
  }
}