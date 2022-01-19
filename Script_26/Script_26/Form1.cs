using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void label_a_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Clicou");
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label_a.Text = textBox1.Text;
        }

        private void label_a_MouseEnter(object sender, EventArgs e)
        {
            label_a.BackColor = Color.Blue;
        }

        private void label_a_MouseLeave(object sender, EventArgs e)
        {
            label_a.BackColor = Color.Aqua;
        }

        private void label_a_MouseDown(object sender, MouseEventArgs e)
        {
            label_a.BackColor = Color.Red;
        }

        private void label_a_MouseUp(object sender, MouseEventArgs e)
        {
            label_a.BackColor = Color.AliceBlue;
        }
    }
}
