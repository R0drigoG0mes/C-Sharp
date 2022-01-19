using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script09_Matemática
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {

            int parcela1 = int.Parse(text_parcela_1.Text);
            int parcela2 = int.Parse(text_parcela_2.Text);

            int resultado = parcela1 + parcela2;
            label_resultado.Text = "O resultado é esse: " + resultado.ToString();
        
        
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
             Application.Exit();
        }
    }
}
