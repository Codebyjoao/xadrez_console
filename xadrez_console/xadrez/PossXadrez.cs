using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class PosXadrez
    {
        public char Coluna { get; set; }

        public int Linha { get; set; }

        public PosXadrez(char coluna, int linha)
        {
            Coluna = coluna;
            Linha = linha;

        }

        public Posicao ToPosicao()
        {
            return new Posicao(8 - Linha, Coluna - 'a');
        }

        public override string ToString()
        {
            return "" + Coluna + Linha;
        }
    }

}
