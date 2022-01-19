using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace Script49_Episodio_155__Impressão
{
    //==========================================================================
    public partial class Form1 : Form
    {
        int pagina = 0;
        int largura;
        int altura;

        Font letra;
        SolidBrush cor;
        int y = 50;
        int numero_frases = 1;

        int paginas_criadas;

        //======================================================================
        public Form1()
        {
            InitializeComponent();
        }

        //======================================================================
        private void button1_Click(object sender, EventArgs e)
        {
            //Da instrução para iniciar a impressão:


            largura = documento.DefaultPageSettings.PaperSize.Width;
            altura = documento.DefaultPageSettings.PaperSize.Height;

            letra = new Font("Consolas", 30, FontStyle.Regular, GraphicsUnit.Pixel);
            cor = new SolidBrush(Color.FromArgb(180, 200, 0));

            documento.DefaultPageSettings.Landscape = true;

            y = 100;

            caixa_visualizacao.Document = documento;
            caixa_visualizacao.ShowDialog();

        }

        //======================================================================
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //======================================================================
        private void documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            string frase = "esta frase serve para testes.";
            SizeF dimensao = e.Graphics.MeasureString(frase, letra);

            e.Graphics.DrawString(frase, letra, cor, new Point (25, y));
            y += Convert.ToInt16(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(25, y));
            y += Convert.ToInt16(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(25, y));
            y += Convert.ToInt16(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(25, y));
            y += Convert.ToInt16(dimensao.Height) + 5;
            e.Graphics.DrawString(frase, letra, cor, new Point(25, y));

            e.Graphics.DrawLine(new Pen(Color.Red, 2), 
                                new Point(Convert.ToInt16(dimensao.Width) + 100, 100), 
                                new Point(100 + Convert.ToInt16(dimensao.Width),y + Convert.ToInt16(dimensao.Height)));


        }

        //======================================================================
        private void pagina_seguinte_Click(object sender, EventArgs e)
        {
            //Avança na página que será apresentada:
            if (pagina == paginas_criadas) return;
            pagina++;
            Visualizar.StartPage = pagina;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Volta na página que será apresentada:
            if (pagina == 0) return;
            pagina--;
            Visualizar.StartPage = pagina;

        }

        private void progresso_Click(object sender, EventArgs e)
        {
            
        }
    }
    //==========================================================================
}
