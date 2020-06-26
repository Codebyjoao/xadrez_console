using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        private int Turno;
        private Cor JogadorAtual;
        public bool Terminada { get; private set; }

        public PartidaDeXadrez()
        {
            Tab = new Tabuleiro(8, 8);
            Turno = 1;
            JogadorAtual = Cor.Branca;
            Terminada = false;
            ColocarPecas();
        }

        public void ExecutaMovimento(Posicao oringem, Posicao destino)
        {
            Peca p = Tab.RetirarPecas(oringem);
            p.IncrementarQtdMovimento();
            Peca PecaCapturada = Tab.RetirarPecas(destino);
            Tab.Colocarpecas(p, destino);
        }

        private void ColocarPecas()
        {
            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('c', 1).ToPosicao()); 
            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('c', 2).ToPosicao());
            Tab.Colocarpecas(new Rei(Tab, Cor.Branca), new PosXadrez('d', 1).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('d', 2).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('e', 1).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('e', 2).ToPosicao());

            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('c', 8).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('c', 7).ToPosicao());
            Tab.Colocarpecas(new Rei(Tab, Cor.Preta), new PosXadrez('d', 8).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('d', 7).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('e', 8).ToPosicao());
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('e', 7).ToPosicao());
        }
    }   
}
