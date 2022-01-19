using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Script48_Episodio_152__Imagens2
{
    //============================================================================
    public partial class Form1 : Form
    {
        Image imgFrame;
        int largura;
        int altura;
        //========================================================================
        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
            imgFrame = Image.FromFile(Application.StartupPath + @"\Imagens\frame.png");
            largura = this.ClientSize.Width;
            altura = this.ClientSize.Height;
            DesenhaGUI();
        }

        //========================================================================
        private void Form1_Load(object sender, EventArgs e)
        {
          
            

        }

        //========================================================================
        private void DesenhaGUI()
        {
            //Desenhar o fundo da Form1:
            Bitmap imgBack = new Bitmap(largura, altura);

            Graphics desenhador = Graphics.FromImage(imgBack);

            //Desenhar os cantos:

            //Canto Superior Esquerdo:
            desenhador.DrawImage(imgFrame, 
                                 new Rectangle(0, 0, 40, 40), 
                                 new Rectangle(0, 0, 40, 40), 
                                 GraphicsUnit.Pixel);
            
            //Canto Superior Direito:
            desenhador.DrawImage(imgFrame,
                                 new Rectangle(largura - 40, 0, 40, 40),
                                 new Rectangle(160, 0, 40, 40),
                                 GraphicsUnit.Pixel);

            //Canto Inferior Esquerdo:
            desenhador.DrawImage(imgFrame,
                                 new Rectangle(0, altura - 40, 40, 40),
                                 new Rectangle(0, 160, 40, 40),
                                 GraphicsUnit.Pixel);

            //Canto Inferior Direito:
            desenhador.DrawImage(imgFrame,
                                 new Rectangle(largura - 40, altura - 40, 40, 40),
                                 new Rectangle(160, 160, 40, 40),
                                 GraphicsUnit.Pixel);

            //Desenhar as linhas horizontais e verticais:
            
            desenhador.DrawImage(imgFrame,
                     new Rectangle(40,0, largura - 80, 10),
                     new Rectangle(40, 0, 120, 10),
                     GraphicsUnit.Pixel);

            desenhador.DrawImage(imgFrame,
                     new Rectangle(0, 40, 10, altura - 80),
                     new Rectangle(0, 40, 10, 120),
                     GraphicsUnit.Pixel);

            desenhador.DrawImage(imgFrame,
                     new Rectangle(0, 40, 10, altura - 80),
                     new Rectangle(0, 40, 10, 120),
                     GraphicsUnit.Pixel);

            desenhador.DrawImage(imgFrame,
                     new Rectangle(40, altura - 10, largura - 80, 10),
                     new Rectangle(40, 0, 120, 10),
                     GraphicsUnit.Pixel);

            desenhador.DrawImage(imgFrame,
                     new Rectangle(largura - 10, 40, 10, altura - 80),
                     new Rectangle(0, 40, 10, 120),
                     GraphicsUnit.Pixel);

            //Definir a imagem de fundo do Form1:
            this.BackgroundImage = imgBack;

        }

        //========================================================================
        private void Form1_Resize(object sender, EventArgs e)
        {
            largura = this.ClientSize.Width;
            altura = this.ClientSize.Height;
            DesenhaGUI();
        }
    }
    //============================================================================
}
