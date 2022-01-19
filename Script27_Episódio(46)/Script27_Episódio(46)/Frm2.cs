using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script27_Episódio_46_
{
    public partial class Frm2 : Form
    {

        public string nome { get; set; } 
        public Frm2(string nome)
        {
            InitializeComponent();
            //this.nome = nome;
            text_nome.Text = nome;
        }

        private void Frm2_Load(object sender, EventArgs e)
        {

        }

        private void cmd_ok_Click(object sender, EventArgs e)
        {
            if (text_nome.Text=="")
            {
                nome = null;
            }
            else
            
            nome = text_nome.Text;
            this.Close();
        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            nome = null;
            this.Close();
        }
    }
}
