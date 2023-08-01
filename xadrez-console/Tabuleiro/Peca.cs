using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuleiro
{
    abstract class Peca
    {
        public Posicao Posicao { get; set; }
        public Cor Cor { get; protected set; }
        public int qteMovimentos { get; protected set; }
        public Tabuleiro Tab { get; set; }

        public Peca(Tabuleiro tab, Cor cor)
        {
            Posicao = null;
            Cor = cor;
            Tab = tab;
            qteMovimentos = 0;
        }

        public void incrementarQteMovimentos()
        {
            qteMovimentos++;
        }

        public abstract bool[,] MovimentosPossiveis();

        public bool ExisteMovimentosPossiveis()
        {
            bool[,] mat = MovimentosPossiveis();
            for(int i = 0; i < Tab.Linhas; i++)
            {
                for(int j = 0; j<Tab.Colunas; j++)
                {
                    if (mat[i, j])
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool podeMoverPara(Posicao pos)
        {
            return MovimentosPossiveis()[pos.Linha, pos.Coluna];
        }
    }
}
