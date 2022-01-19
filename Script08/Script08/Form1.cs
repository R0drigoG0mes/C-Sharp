using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Script08
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        
        
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            
            string nome = textBox1.ToString();
            
            string sobrenome = "Gomes";

            string idade = textBox2.ToString();

            if (nome=="Rodrigo" && idade== "16")
            {
                
                    caixa_texto.Text = "Meu nome é: " + nome + " " + sobrenome + "  \nE tenho: " + idade + " anos de idade.";
                    

            }

            else if (nome == "Antonia" && idade == "48")
            {
                caixa_texto.Text = "Seu nome é: " + nome + " Risomar " + sobrenome + "\nE tem: " + idade + "anos de idade.";
            }

            else if (nome == "Maria" && idade == "20")
            {
                caixa_texto.Text = "Seu nome é: " + nome + " Helena " + sobrenome + " De Oliveira " + "\n E tem:" + idade + "anos de idade.";

            }
           
            
            

             

        }

        private void caixa_texto_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
           
           
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            


        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
