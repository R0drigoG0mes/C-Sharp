using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script26_Episódio_44_
{
    public partial class FormJanela : Form
    {
        
        
        public FormJanela()
        {
            InitializeComponent();

            

            label_resultado_final.Text = geral.nome;
        }

        private void cmd_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label_outra.Text = geral.nome;
        }

        private void label_resultado_final_Click(object sender, EventArgs e)
        {

        }

        private void label_outra_Click(object sender, EventArgs e)
        {

        }
    }
}
