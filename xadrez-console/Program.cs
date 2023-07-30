using System;
using tabuleiro;
using xadrez_console.xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.ColocarPeca(new Torre(tab, Cor.Amarela), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(tab, Cor.Amarela), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(tab, Cor.Amarela), new Posicao(0, 9));

                Tela.imprimirTabuleiro(tab);

               
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
