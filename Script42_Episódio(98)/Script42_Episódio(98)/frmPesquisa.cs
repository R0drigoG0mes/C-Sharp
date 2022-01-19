using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script42_Episódio_98_
{
    public partial class frmPesquisa : Form
    {
        public string texto_pesquisa { get; set; }
        public bool cancelado { get; set; }

        //==================================================================
        public frmPesquisa()
        {
            InitializeComponent();
        }
        //==================================================================

        //==================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //Executa a pesquisa, mas somente se tiver texto na textBox:

            if(text_pesquisa.Text == "")
            {
                cancelado = true;
            }

            else
            {
                texto_pesquisa = text_pesquisa.Text;
            }

            this.Close();
        }
        //==================================================================

        //==================================================================
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //==================================================================

        //==================================================================
        private void button2_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }
        //==================================================================

        //==================================================================
        private void frmPesquisa_Load(object sender, EventArgs e)
        {

        }
        //==================================================================

        //==================================================================
        private void text_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }
        //==================================================================
    }
    //++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
}
