using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script15
{
    class calculo
    {
        public int operacoes(int parcela1, int parcela2, string operacao)
        {
            int resultado = -1;
            
            switch (operacao)
            {
                case "adição":
                    resultado = parcela1 + parcela2;
                        break;
                case "multiplicação":
                    resultado = parcela1 * parcela2;
                    break;
                case "subtração":
                    resultado = parcela1 - parcela2;
                    break;
                case "divisão":
                    resultado = parcela1 / parcela2;
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show("Operação inválida");


                    break;


            }

            return resultado;
        
        
        
        }
        
    
    
    
    }
}
