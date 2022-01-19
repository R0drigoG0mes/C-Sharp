using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script20_EstaticClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            normal objeto = new normal();
            objeto.Nome = "João Ribeiro";
            objeto.ApresentarNome();

            normal objeto2 = new normal();
            objeto2.Nome = "Caracacacarcarcarcaracr";
            objeto2.ApresentarNome();

            estatica.nome = "Cacau";
            estatica.ApresentarNome();




        }
    }
}
