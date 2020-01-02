namespace tabuleiro
{
  public class Peca
  {
    public Posicao posicao{get; set;}
    public Cor cor{get; protected set;}
    public int qteMovimentos{get; protected set;}
    public Tabuleiro tab{get; private set;}
    public Peca(Posicao posicao, Tabuleiro tabuleiro,Cor cor)
    {
      this.posicao = posicao;
      this.tab = tabuleiro;
      this.cor = cor;
      qteMovimentos = 0;
    }
  }
}