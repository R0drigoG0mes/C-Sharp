using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script47_Episodio_138__Imagens
{
    public partial class cl_bola
    {
        public int x = 50;
        public int y = 50;
        public int velocidade_x = 10;
        public int velocidade_y = 10;

        public void Mover(int largura, int altura)
        {
            x += velocidade_x;
            y += velocidade_y;

            //Detecção de colisões:

            if(x + 140 >= largura)
            {
                velocidade_x = -velocidade_x;
            }

            if(x <= 0)
            {
                velocidade_x = -velocidade_x;
            }

            if(y + 140 >= altura)
            {
                velocidade_y = -velocidade_y;
            }

            if(y <= 0)
            {
                velocidade_y = -velocidade_y;
            }
        }

    }
}
