using System;
using tabuleiro;
using xadrez;

namespace xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            /*try
            {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.Colocarpecas(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.Colocarpecas(new Torre(tab, Cor.Preta), new Posicao(1, 9));
                tab.Colocarpecas(new Rei(tab, Cor.Preta), new Posicao(0, 2));


                Tela.ImprimirTabuleiro(tab);
            }
            catch(TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }*/

            PosXadrez pos = new PosXadrez('a',1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());
        }    
    }
}
