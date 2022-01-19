using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script55_Episodio181
{
    public partial class Form1 : Form
    {
        cl_Utilizador u1;
        cl_Utilizador u2;
        cl_Utilizador u3;

        cl_Utilizador user = new cl_Utilizador();

        public Form1()
        {
            InitializeComponent();

            //Definir os utilizadores:
            u1 = new cl_Utilizador();
            u1.permissoes = "1111";
            u1.password = "pass1";
            u1.utilizador = "user1";
           
            /*++++++++++++++++++++++*/

            u2 = new cl_Utilizador();
            u2.permissoes = "1100";
            u2.password = "pass2";
            u2.utilizador = "user2";

            /*++++++++++++++++++++++*/

            u3 = new cl_Utilizador();
            u3.permissoes = "0011";
            u3.password = "pass3";
            u3.utilizador = "user3";

            //Define o utilizador ativo:
            user = u1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Program.VerificarPermissao(user, 0))
            {
                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!Program.VerificarPermissao(user, 0))
            {
                return;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (!Program.VerificarPermissao(user, 0))
            {
                return;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (!Program.VerificarPermissao(user, 0))
            {
                return;
            }

        }
    }
}
