using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script56_Episodio_182_
{
    public partial class Form2 : Form
    {
        Form frm;

        public Form2(Form frmativa)
        {
            InitializeComponent();

            frm = frmativa;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm.Controls["label1"].Text = "Aí seu cocô";
        }
    }
}
