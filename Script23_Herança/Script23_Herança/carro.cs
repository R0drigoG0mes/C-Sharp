using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script23_Herança
{
    class carro : veiculo
    {
        public void Ligar_Motor()
        {

        }

        public override void Acelerar()
        {
            System.Windows.Forms.MessageBox.Show("O carro acelerou");
        }




    }
}
