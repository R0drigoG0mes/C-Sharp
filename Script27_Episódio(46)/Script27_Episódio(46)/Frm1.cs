using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script27_Episódio_46_
{
    public partial class Frm1 : Form
    {

        string nome = null;
        
        public Frm1()
        {
            InitializeComponent();
        }

        private void cmd_avançar_Click(object sender, EventArgs e)
        {
            if (label_texto.Text!= "")
            {
                nome = label_texto.Text;
            }
            
            Frm2 formulário = new Frm2(nome);
            formulário.ShowDialog();
            
            if (formulário.nome!=null)
            {
                label_texto.Text = formulário.nome;

            }
            
            

          
        }
    }
}
