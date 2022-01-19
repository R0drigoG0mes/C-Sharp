using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script22_Abstração
{
    class CL_cálculo
    {
        private int porcentagem1 = 5;
        private int porcentagem2 = 12;
        private int porcentagem3 = 23;

        public int CalculoFinal(int preço_inicial, int tipo_produto)
        {

            int preco_final = 0;
            
            switch (tipo_produto)
            {
                case 1:

                    preco_final = preço_inicial + (preço_inicial * porcentagem1 / 100);
                    break;
                case 2:

                    preco_final = preço_inicial + (preço_inicial * porcentagem2 / 100);
                    break;
                case 3:

                    preco_final = preço_inicial + (preço_inicial * porcentagem3 / 100);
                    break;


            }
            
            
            
            return preco_final;
        }
    
    
    }
}
