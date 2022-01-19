using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Script33_Episodio_54_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter ficheiro = new StreamWriter(@"C:/teste/dados.txt", false, Encoding.Default);

            // alfa numérica
            ficheiro.WriteLine("Olá Mundo");

            // int
            int valor = 150;
            ficheiro.WriteLine(valor);

            // boleano
            bool resultado = false;
            ficheiro.WriteLine(resultado);

            // data
            ficheiro.WriteLine(DateTime.Now);

            // cor
            Color cor = Color.FromArgb(255,255,0);
            ficheiro.WriteLine(cor.ToArgb());
            
            ficheiro.Dispose();


            
        
        
        }

        private void cmd_ler_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:/teste/dados.txt", Encoding.Default); ;

            // String
            string a = ficheiro.ReadLine();

            // Int
            int b = int.Parse(ficheiro.ReadLine());
            //int b = Convert.ToInt16(ficheiro.ReadLine());

            // Boleano
            bool c = bool.Parse(ficheiro.ReadLine());

            // Data
            DateTime d = DateTime.Parse(ficheiro.ReadLine());

            // Cor
            Color cor = Color.FromArgb(int.Parse(ficheiro.ReadLine()));

            pictureBox1.BackColor = cor;

            
            ficheiro.Dispose();
        
        }
    }
}
