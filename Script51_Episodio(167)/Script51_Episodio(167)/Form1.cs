using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace Script51_Episodio_167_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmd_enviar_Click(object sender, EventArgs e)
        {
            //Enviar E-mail via C#:

            SmtpClient cliente = new SmtpClient();
            NetworkCredential credenciais = new NetworkCredential();

            //Definir as configurações do cliente:

            cliente.Host = "smtp.gmail.com";
            cliente.Port = 587;
            cliente.EnableSsl = true;
            cliente.DeliveryMethod = SmtpDeliveryMethod.Network;
            cliente.UseDefaultCredentials = false;

            //Definir as credenciais de acesso ao email:
            credenciais.UserName = "rodrigocordeiro132";
            credenciais.Password = "lukk143143";

            //Define as credenciais no cliente:
            cliente.Credentials = credenciais;

            //Preparar a mensagem para enviar:
            MailMessage mensagem = new MailMessage();
            mensagem.From = new MailAddress("rodrigocordeiro132@gmail.com");
            mensagem.Subject = "Cachorrinho Popozudo e Cabeludesco";
            mensagem.IsBodyHtml = true;
            mensagem.Body = "<strong>CUIDADO: </strong><br><br> A sua conta esta sendo usada por uma aplicação externa";
            mensagem.To.Add("rodrigocordeiro132@gmail.com");

            //Enviar a mensagem:

            cliente.Send(mensagem);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = text_email.Text;

            bool resultado = true;

            //Verificação do endereço de email:

            Regex reg = new Regex(@"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})");

            if (!reg.IsMatch(email))
            {
                resultado = false;
                MessageBox.Show("Erro no Login, verifique a senha ou o email e tente novamente", "Falha no Login", MessageBoxButtons.OK,MessageBoxIcon.Information);
                text_email.Text = "";
                text_email.Focus();
            }

            //Verifica se o email tem mais de um "@":

            int numero_de_ats = 0;

            foreach(char c in email)
            {
                
                if(c == '@')
                {

                    numero_de_ats++;

                    if(numero_de_ats != 1)
                    {
                        resultado = false;
                    }

                }
            }

            if (!resultado)
            {

                MessageBox.Show("Erro no Login, verifique a senha ou o email e tente novamente", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.BackColor = Color.Red;
                text_email.Text = "";
                text_email.Focus();
            }


        }
    }
}
