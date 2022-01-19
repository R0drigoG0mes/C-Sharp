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

namespace Script32_Episodio_52_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valor = 100;
            
            StreamWriter ficheiro = new StreamWriter(@"C:\teste\\file.txt", true, Encoding.Default);
            ficheiro.WriteLine(textBox1.Text);

            textBox1.Text = "";
            textBox1.Focus();
            
            ficheiro.Dispose(); 
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader ficheiro = new StreamReader(@"C:/teste/file.txt", Encoding.Default);

            while (ficheiro.EndOfStream == false)
            {
                lista.Items.Add(ficheiro.ReadLine());
            }
            
            
            ficheiro.Dispose();
        
        }
    }
}
