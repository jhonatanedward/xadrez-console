namespace tabuleiro
{
  public abstract class Peca
  {
    public Posicao posicao{get; set;}
    public Cor cor{get; protected set;}
    public int qteMovimentos{get; protected set;}
    public Tabuleiro tab{get; private set;}
    public Peca(Tabuleiro tabuleiro,Cor cor)
    {
      this.posicao = null;
      this.tab = tabuleiro;
      this.cor = cor;
      qteMovimentos = 0;
    }
    public void incrementarQteMovimentos()
    {
      qteMovimentos++;
    }
    public bool existeMovimentosPossiveis()
    {
      bool[,] mat = movimentosPosiveis();
      for(int i = 0; i < tab.linhas; i++)
      {
        for(int j = 0; j < tab.colunas; j++){
          if(mat[i,j] == true)
          {
            return true;
          }
        }
      }
      return false;
    }
    public bool podeMoverPara(Posicao pos)
    {
      return movimentosPosiveis()[pos.linha, pos.coluna];
    }
    public abstract bool[,] movimentosPosiveis();
  }
}