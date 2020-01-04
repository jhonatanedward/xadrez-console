using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
                PartidaDeXadrez partida= new PartidaDeXadrez();
                while(!partida.terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPosiveis();
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab, posicoesPosiveis);
                    Console.Write("Destino: ");
                    Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                    partida.executaMovimento(origem, destino);
                }
                Console.ReadKey();
            }catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
