using System;

public class Program {
  public static void Main() {
    PlayList pl = new PlayList("Pagode", "Curtir no fds");
    Musica m1 = new Musica("Thiaguinho", "Falta você", "Tardezinha");
    Musica m2 = new Musica("Péricles", "Melhor eu ir", "Em sua direção");
    pl.Inserir(m1);
    pl.Inserir(m2);

    Console.WriteLine(pl.ToString());
      
    foreach (Musica m in pl.Listar())
      Console.WriteLine(m);
  }
}

class PlayList {
  private string nome, descricao;
  private int k = 0;
  public Musica[] musicas = new Musica[10];
  public PlayList(string nome, string descricao) {
    this.nome = nome;
    this.descricao = descricao;
  }
  public void Inserir(Musica m) {
    if (k == musicas.Length) {
      Array.Resize(ref musicas, 2 * musicas.Length);
    }
    musicas[k++] = m;
  }
  public Musica[] Listar() {
    Musica[] mus = new Musica[k];
    Array.Copy(musicas, mus, k);
    return mus;
  }
  public override string ToString() {
    return $"Nome: {nome} | Descrição: {descricao}";
  }
}

class Musica {
  public string artista, titulo, album;
  public Musica(string artista, string titulo, string album) {
    this.artista = artista;
    this.titulo = titulo;
    this.album = album;
  }
  public override string ToString() {
    return $"Título: {titulo} | Artista: {artista} | Albúm: {album}";
  }
}