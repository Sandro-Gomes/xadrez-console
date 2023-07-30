﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tabuleiro;

namespace xadrez_console.xadrez
{
    class Torre : Peca
    {
        public Torre(Tabuleiro tab, Cor cor) : base(tab, cor)
        {


        }
        public override string ToString()
        {
            return "T";
        }
    }
}
