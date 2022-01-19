using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Script23_Herança
{
    abstract class veiculo
    {
        public string cor { get; set; }
        public string marca { get; set; }

        abstract public void Acelerar();

        public virtual void parar()
        {
            System.Windows.Forms.MessageBox.Show("Pareeeeeieiieie");
        }
        
    
    
    }
}
