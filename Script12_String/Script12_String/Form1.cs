using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script12_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string frase = "CaRaMbA rAtInEoU bUgOu";

            int lapada = 0;

            while (lapada <= 20000)
            {
                lista.Items.Add(frase);
                lista.Items.Add(frase.ToLower());
                lista.Items.Add(frase.ToUpper());
                lista.Items.Add(lapada);
                lapada++;
            }
            
        
        
        
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
