using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script18_construtores
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
            Teste pessoa = new Teste("Rodrigo", 16);

            System.Windows.Forms.MessageBox.Show(pessoa.ToString(), "Você é uma pessoa", MessageBoxButtons.YesNo);
            
            


        }
    }
}
