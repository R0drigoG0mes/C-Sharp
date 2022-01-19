using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script22_Abstração
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            CL_cálculo calculadora = new CL_cálculo();
            
            int preco_inicial = Convert.ToInt16(caixa_preço.Text);

            int tipo_produto = 0;
            
            

            
            if (rd1.Checked)
            {
                tipo_produto = 1;
            }
            else if (rd2.Checked)
            {
                tipo_produto = 2;
            }

            else if (rd3.Checked)
            {
                tipo_produto = 3;
            }

            MessageBox.Show("Preço Final: " + calculadora.CalculoFinal(preco_inicial, tipo_produto));



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
