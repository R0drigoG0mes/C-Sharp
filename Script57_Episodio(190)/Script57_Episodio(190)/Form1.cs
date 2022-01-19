using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script57_Episodio_190_
{
    public partial class Form1 : Form
    {
        string codigo = "1234abcd";
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            //Verificação do código introduzido:

            if(text_codigo.Text == codigo)
            {
                MessageBox.Show("Correto");
            }
            else
            {
                MessageBox.Show("Errado");
            }

        }
    }
}
