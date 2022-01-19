using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script17_Campos
{
    class Teste1
    {
        private string _nome;
        
        public string Nome
        {
            set
            {
                if (Nome == "Rodrigo")
                    System.Windows.Forms.MessageBox.Show("Feioso".ToString());
                else
                    System.Windows.Forms.MessageBox.Show(Nome);

                
                _nome = value;

            }

            get
            {

                return _nome;
            }



        }
    
    
    
    
    }
}
