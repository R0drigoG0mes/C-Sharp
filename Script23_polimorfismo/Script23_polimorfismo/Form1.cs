using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script23_polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            rectangulo forma1 = new rectangulo();

            forma1.Largura = 50;
            forma1.Altura = 100;
            forma1.ApresentarSe();
            forma1.Desenhar();
            forma1.Desenhar_outro();

            triangulo forma2 = new triangulo();

            forma2.Largura = 550;
            forma2.Altura = 800;
            forma2.ApresentarSe();
            forma2.Desenhar();
            forma2.Desenhar_outro();

            circunferencia forma3 = new circunferencia();

            forma3.Largura = 200;
            forma3.Altura = 300;
            forma3.ApresentarSe();
            forma3.Desenhar();
            forma3.Desenhar_outro();
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
