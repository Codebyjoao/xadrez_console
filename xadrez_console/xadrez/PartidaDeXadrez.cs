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
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('c', 1).ToPosicao()); 
            Tab.Colocarpecas(new Torre(Tab, Cor.Preta), new PosXadrez('b', 3).ToPosicao());
            Tab.Colocarpecas(new Rei(Tab, Cor.Preta), new PosXadrez('a', 2).ToPosicao());

            Tab.Colocarpecas(new Torre(Tab, Cor.Branca), new PosXadrez('d', 5).ToPosicao());
        }
    }   
}
