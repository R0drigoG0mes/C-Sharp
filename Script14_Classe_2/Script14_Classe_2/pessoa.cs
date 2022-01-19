using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script14_Classe_2
{
    class pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;

        public void IdentificarSe()
        {

            string nomeinteiro = nome + " " + sobrenome;
             System.Windows.Forms.MessageBox.Show(nomeinteiro);
            


        }
    
    
    }
}
