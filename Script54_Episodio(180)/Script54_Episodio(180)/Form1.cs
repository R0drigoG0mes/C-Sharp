using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script54_Episodio_180_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random gerador = new Random();

            lista.Items.Clear();

            for (int m = 0; m < 20; m++)
            {

                lista.Items.Add(CriarCodigo());

            }
        }
        
        private string CriarCodigo(int numeroCaracteres = 30)
        {
            StringBuilder str = new StringBuilder();

            string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            caracteres = caracteres + caracteres.ToLower();


            for(int vezes = 0; vezes<numeroCaracteres; vezes++)
            {
                Random rnd = new Random(vezes);



                int x = rnd.Next(caracteres.Length);
                str.Append(caracteres[x]);

            }
            
            
            
            //Devolve str:
            return str.ToString();


        }
    
    
    
    }
}
