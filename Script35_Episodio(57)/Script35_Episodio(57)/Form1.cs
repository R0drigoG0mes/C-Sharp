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

namespace Script35_Episodio_57_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] lista_arquivos = Directory.GetFiles(@"C:\teste", "*.txt");

            foreach(string item in lista_arquivos)
            {
                File.Move(item, @"C:\teste\temp\" + Path.GetFileName(item));
            }


            string[] arquivos = Directory.GetFiles(@"C:\testão");

            foreach (string item in arquivos)
            {
                listBox1.Items.Add(Path.GetFileNameWithoutExtension(item));


            }

            

            MessageBox.Show("Terminado");
        
        
        }
    }
}
