using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PartidaDeXadrez
    {
        public Tabuleiro Tab { get; private set; }
        public int Turno { get; private set; }
        public Cor JogadorAtual { get; private set; }
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

        public void RealizaJogada(Posicao oringem, Posicao destino)
        {
            ExecutaMovimento(oringem, destino);
            Turno++;
            MudaJogador();
        }

        public void MudaJogador()
        {
            if(JogadorAtual == Cor.Branca)
            {
                JogadorAtual = Cor.Preta;
            }
            else
            {
                JogadorAtual = Cor.Branca;
            }
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

        public void ValidarPosicaoDeOrigem(Posicao pos)
        {
            if(Tab.Peca(pos)== null)
            {
                throw new TabuleiroException("Não existe peça na posição de origem escolhida");
            }
            if (JogadorAtual != Tab.Peca(pos).Cor)
            {
                throw new TabuleiroException("A peça de origem escolhida não é sua!");
            }
            if (!Tab.Peca(pos).ExisteMovimentosPossiveis())
            {
                throw new TabuleiroException("Não há movimentos possiveis para peça de origem escolhida!");
            }
        }


        public void ValidarPosicaoDeDestino(Posicao origem, Posicao destino)
        {
            if (!Tab.Peca(origem).PodeMoverPara(destino))
            {
                throw new TabuleiroException("Posição de destino invalida");
            }
        } 
    }   
}
