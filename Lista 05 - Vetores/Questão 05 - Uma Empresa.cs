using System;

public class Program {
  public static void Main() {
    Cliente c1 = new Cliente("Junior", "88156478124", 250.00);
    Cliente c2 = new Cliente("Aurora", "54612345897", 750.00);
    c1.SetSocio(c2);  // c1 e c2 são sócios
    Console.WriteLine(c1.GetLimite());
    Console.WriteLine(c2.GetLimite());

    Empresa e = new Empresa();
    e.Inserir(c1);
    e.Inserir(c2);
    foreach (Cliente i in e.Listar())
      Console.WriteLine(i);
  }
}

class Empresa {
  private Cliente[] clientes = new Cliente[1];
  private int k = 0;
  public void Inserir(Cliente c) {
    if (k == clientes.Length) {
      Array.Resize(ref clientes, 1 + clientes.Length);
    }
    clientes[k++] = c;
  }
  public Cliente[] Listar() {
    Cliente[] vetor = new Cliente[k];
    Array.Copy(clientes, vetor, k);
    return vetor;
  }
}

class Cliente {
  private string nome = "Antônio", cpf = "xxxxxxxxxxx";
  private double limite = 1;
  private Cliente socio;
  public Cliente(string nome, string cpf, double limite) {
    this.nome = nome;
    this.cpf = cpf;
    this.limite = limite;
  }
  public void SetSocio(Cliente c) {
    this.limite = this.limite + c.GetLimite();
    this.socio = c;
    c.socio = this;
    socio.limite = limite;
  }
  public double GetLimite() {
    return limite;
  }
  public override string ToString() {
    return $"Nome: {nome} | CPF: {cpf} | Limite: {limite:0.00} R$";
  }
}