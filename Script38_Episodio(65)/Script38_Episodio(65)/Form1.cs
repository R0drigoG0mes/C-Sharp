using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script38_Episodio_65_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmd_sair_Click(object sender, EventArgs e)
        {
            
            //Fecha a operação
            Application.Exit();
        }

        private void cmd_calcular_Click(object sender, EventArgs e)
        {
            //Executa o cálculo da operação
            int parcela1;
            int parcela2;
            string tipo_operação;
            int resultado = -111111111;

            string algoritmo = text_operacao.Text;

            string sinais = "+-*/";

            int index = 0;
            foreach(char c in algoritmo)
            {
                foreach (char s in sinais)
                {
                    if (c == s)
                    {
                        //Define os três elementos da operação
                        //Parcela 1
                        parcela1 = int.Parse(algoritmo.Substring(0, index));

                        //Sinal
                        tipo_operação = c.ToString();

                        //Parcela 2
                        parcela2 = int.Parse(algoritmo.Substring(index + 1));

                        //Analisa o tipo de operação que será realizada
                        switch (tipo_operação)
                        {
                            case "+":
                                //Adiçaõ
                                resultado = parcela1 + parcela2;
                                break;
                            case "-":
                                //Subtração
                                resultado = parcela1 - parcela2;
                                break;
                            case "*":
                                //Multiplicação
                                resultado = parcela1 * parcela2;
                                break;
                            case "/":
                                //Divisão
                                resultado = parcela1 / parcela2;
                                break;
                        
                        
                        
                        
                        }
                        break;
                    
                    }
                
                }


                //Analise Resultado
                if (resultado != -111111111) 
                {

                    break;
                
                }
                index++;
            
            }

            //Apresenta o Resultado
            if (resultado != -111111111)
            { MessageBox.Show(resultado.ToString()); }
            else
            {
                MessageBox.Show("Erro Inesperado");
            }

            //Limpa o Algoritmo
            text_operacao.Text = "";
            text_operacao.Focus();

        }

        private void text_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            //Ao clicar realiza o cálculo
            //Exceto se o texto estiver em branco

            //Verifica se tem texto:

            if (text_operacao.Text == "")
            {
                return;
            }

            //Analisa se a tecla Return foi pressionada:
            
            if (e.KeyCode == Keys.Return)
            {
                cmd_calcular_Click(cmd_calcular, EventArgs.Empty);
            
            }
            else if (e.KeyCode == Keys.Escape)
            {
                text_operacao.Text = "";
                text_operacao.Focus();
            }


        
        
        
        
        }
    }
}
