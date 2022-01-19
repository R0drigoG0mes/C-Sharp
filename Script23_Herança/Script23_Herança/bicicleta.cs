using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script23_Herança
{
    class bicicleta:veiculo
    {
        public void pedalar()
        {
            while (true)
            {
                System.Windows.Forms.MessageBox.Show("Pedalando");


            
            }
        
        }

        public override void Acelerar()
        {
            System.Windows.Forms.MessageBox.Show("A bicicleta pedalou com o robinho");
        }

        public override void parar()
        {
            System.Windows.Forms.MessageBox.Show("a bissi parou manaananb");
                
        }



    }
}
