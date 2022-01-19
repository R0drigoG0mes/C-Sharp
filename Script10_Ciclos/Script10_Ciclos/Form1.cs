using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script10_Ciclos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            int aument = 0;

            while (aument <= 20)
            {
                lista.Items.Add("Gaulesss rebaixado");
                
                aument++;
                lista.Items.Add("está nesse: " + aument);
            
            }


            for (int aument2 = 0; aument2 <= 18; aument2++) 
            {
                
                lista.Items.Add("uiuiu");
                lista.Items.Add("capa de corno");
                lista.Items.Add("Está nesse: " + aument2);
            
            }

            string frase = "a frase é essa aqui C#";

            foreach (char a in frase)
            {
                lista1.Items.Add(a);

            }
                            
        
        
        
        
        
        
        }

        private void btn_fim_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
