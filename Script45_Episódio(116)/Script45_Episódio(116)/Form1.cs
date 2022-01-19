using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script45_Episódio_116_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_GestorBD gestor = new cl_GestorBD();

            //Define as instruções das tabelas:

            List<string> instrucoes = new List<string>() 
            {
                


            };



            gestor.CriarBaseDados(@"C:\Users\User\Documents\Rodrigo\SQL Ce\base", instrucoes,true);






        }
    }
}
