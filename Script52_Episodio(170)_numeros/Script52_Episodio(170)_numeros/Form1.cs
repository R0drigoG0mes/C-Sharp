using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script52_Episodio_170__numeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_executar_Click(object sender, EventArgs e)
        {

            double valor1 = 1.5786;
            double valor2 = 1.39469876;

            double resultados = valor1 + valor2;

            

            label_resultados.Text = resultados.ToString("0.000000");

        }
    }
}
