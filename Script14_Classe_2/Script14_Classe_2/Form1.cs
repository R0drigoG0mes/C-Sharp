using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script14_Classe_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();
            p1.nome = "Rodrigo";
            p1.sobrenome = "Gomes";
            p1.IdentificarSe();
            
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
