using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Script53_Episodio_178_
{
    public partial class frmLogin : Form
    {
        //dados do utilizador:

        string utilizador = "Pão com Linguiça";
        string password = "1234";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            //Verificar se o login é correto:

            if(text_password.Text == "" || text_utilizador.Text == "")
            {
                return;
            }

            bool entrar = true;

            //Testar método MD5:
            string codigo = CriarMD5(text_password.Text);

            //Verifica se houve erros de digitação:
            if (text_utilizador.Text != utilizador || codigo != CriarMD5(password))
            {
                MessageBox.Show("Ocorreu um erro, verifique se os " + Environment.NewLine +"dados do login estão corretos.", "Falha No Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                entrar = false;
            }


            //Se o login esta correto, abre o menu principal:
            if (entrar)
            {
                this.Hide();
                frmMenu f = new frmMenu();
                f.ShowDialog();
            }
        }

        private void cmd_entrar_MouseEnter(object sender, EventArgs e)
        {
            cmd_entrar.ForeColor = Color.Lime;
        }

        private void cmd_cancelar_MouseEnter(object sender, EventArgs e)
        {
            cmd_cancelar.ForeColor = Color.Lime;
        }

        private void cmd_entrar_MouseLeave(object sender, EventArgs e)
        {
            cmd_entrar.ForeColor = Color.LimeGreen;
        }

        private void cmd_cancelar_MouseLeave(object sender, EventArgs e)
        {
            cmd_cancelar.ForeColor = Color.LimeGreen;
        }

        private void check_visualizar_CheckedChanged(object sender, EventArgs e)
        {
            //Visualiza ou esconde o texto da password:

            if (check_visualizar.Checked)
            {
                //Mostrar a password:
                text_password.PasswordChar = '\0';
            }
            else
            {
                text_password.PasswordChar = '*';
            }
        }

        private string CriarMD5(string senha)
        {
            //Encriptar com o algoritmo MD5 a senha fornecida:

            MD5 criador = MD5.Create();

            byte[] inputs = Encoding.ASCII.GetBytes(senha);
            byte[] hash = criador.ComputeHash(inputs);

            StringBuilder final = new StringBuilder();

            for(int i=0; i < hash.Length; i++)
            {
                final.Append(hash[i].ToString("X2"));
            }

            return final.ToString();
        }
    }
}
