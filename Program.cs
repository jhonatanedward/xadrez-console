﻿using System;
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
                    try{                        
                        Console.Clear();
                        Tela.imprimirPartida(partida);
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPosiveis = partida.tab.peca(origem).movimentosPosiveis();

                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPosiveis);
                        Console.WriteLine();
                        Console.Write("Destino: ");

                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();                        
                        partida.validarPosicaoDeDestino(origem, destino);
                        partida.realizaJogada(origem, destino);
                    }catch(Exception e){
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }
                }
                Console.ReadKey();
            }catch(TabuleiroException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}
