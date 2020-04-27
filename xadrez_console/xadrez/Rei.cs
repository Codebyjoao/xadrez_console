﻿using System;
using System.Collections.Generic;
using System.Text;
using tabuleiro;

namespace xadrez
{
    class Rei : Peca
    {
        public Rei(Tabuleiro tab, Cor cor): base(cor,tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
