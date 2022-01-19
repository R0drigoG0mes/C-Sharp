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

namespace Script36_Episodio_59_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // MessageBox

            //Informações Simples:
            //MessageBox.Show("Olá Mundo");

            //Mensagem com Título, Botão e Ícone:
            //MessageBox.Show("Texto da Mensagem", 
            //                "Título da Mensagem",
            //                MessageBoxButtons.OKCancel, 
            //                MessageBoxIcon.Information);

            //Caixa de Diálogo com Resultados:
            if (MessageBox.Show("Deseja sair?",
                             "Encerrar",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question)== DialogResult.No)
            {

                return;  
            
            }

            else
            {

                Application.Exit();

            }




        
        
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "Escolha o Arquivo";
            caixa.InitialDirectory = @"C:\";
            caixa.Filter = "Arquivos de Texto | *.txt | Imagens | *.jpg";
            
            
            if(caixa.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.BackgroundImage = Image.FromFile(caixa.FileName);

        
        
        
        
        
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SaveFileDialog caixa = new SaveFileDialog();
            caixa.Title = "Salvar Arquivo";
            caixa.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            caixa.Filter = "Arquivos (.txt)|*.txt|Imagens|*jpg ";
            
            if (caixa.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            string local = caixa.FileName;

            StreamWriter arquivo = new StreamWriter(local, false, Encoding.Default);
            arquivo.WriteLine(local);
            arquivo.Dispose();




        
        
        
        
        
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog caixa = new FolderBrowserDialog();
            caixa.SelectedPath = @"C:\";

            if(caixa.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            MessageBox.Show("A caixa escolhida foi " + caixa.SelectedPath);








        }

        private void button5_Click(object sender, EventArgs e)
        {
            ColorDialog caixa = new ColorDialog();
            caixa.Color = pictureBox1.BackColor;

            if (caixa.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            pictureBox1.BackColor = caixa.Color;

        
        
        
        
        
        
        
        }
    }
}
