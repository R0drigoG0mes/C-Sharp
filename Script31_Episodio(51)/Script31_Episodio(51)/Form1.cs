using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script31_Episodio_51_
{
    public partial class Form1 : Form
    {
        Color cor = Color.Black;

        //-----------------------------------------------
        public Form1()
        {
            InitializeComponent();
        }

        //-----------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = caixa.BackColor.Name;


        }

        //-----------------------------------------------

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar1.Value.ToString();
            ApresentarCor();
        }

        //-----------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //-----------------------------------------------

        private void ApresentarCor()
        {
            cor = Color.FromArgb(trackBar3.Value, 
                                 trackBar2.Value,
                                 trackBar1.Value);
            
            caixa.BackColor = cor;
        }

        //-----------------------------------------------

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar3.Value.ToString();
            ApresentarCor();
        }

        //-----------------------------------------------

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            ApresentarCor();
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Text = caixa.BackColor.Name;
        }

        //-----------------------------------------------
    }
}
