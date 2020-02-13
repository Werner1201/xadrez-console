using System;
using tabuleiro;

namespace xadrez_console
{
    class Tela
    {
        public static void ImprimirTabuleiro(Tabuleiro tab)
        {
            for (int i = 0; i < tab.Linhas; i++)
            {
                for (int j = 0; j < tab.Colunas; j++)
                {
                    Peca p = tab.peca(i, j);
                    if(p == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write($"{p} ");
                    }
                   
                }
                Console.WriteLine();
            }
        }

    }
}
