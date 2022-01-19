using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Script47_Episodio_138__Imagens
{
    public partial class Form1 : Form
    {
        //==========================================================================
        string pasta_imagens = "";

        Image cmd_normal;   // Botão normal
        Image cmd_high;     // Quando o mouse passa por cima do botão
        Image cmd_disable;  // Quando o botão está inativo

        List<cl_bola> BOLAS = new List<cl_bola>();

        int largura;
        int altura;

        public Form1()
        {
            InitializeComponent();
            pasta_imagens = Application.StartupPath + @"\Imagens\";
            pic_teste.BackgroundImage = Image.FromFile(pasta_imagens + "Chuva.png");
            
            //carregamento da imagem de fundo:

            picture_alvo.BackColor = Color.Red;

            Rectangle sal = pic_teste.Bounds;
            Rectangle alvu = picture_alvo.Bounds;

            int caoscaos = sal.Height / 2;
            int caos = sal.Width / 2;
            int primeira_x = sal.X - caos;
            int primeira_y = sal.Y - caoscaos;

            picture_alvo.Location = new Point(primeira_x,primeira_y);

            cmd_normal = Image.FromFile(pasta_imagens + "btn_normal.png");
            cmd_high = Image.FromFile(pasta_imagens + "btn_fosco.png");
            cmd_disable = Image.FromFile(pasta_imagens + "btn_opaco+.png");


        }

        //==========================================================================

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_teste.BackColor = Color.Transparent;
            cmd_teste.BackgroundImage = cmd_normal;
            largura = pic_teste.Width;
            altura = pic_teste.Height;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {


            //Rectangle sal = pic_teste.Bounds;
            //Rectangle alvu = picture_alvo.Bounds;


            //int afe = alvu.Width / 2;
            //int afefe = alvu.Height / 2;
            //int segunda_x = alvu.X - afe;
            //int segunda_y = alvu.Y - afefe;

            //picture_alvo.Location = new Point(segunda_x, segunda_y);

            //Ativa ou desativa o cmd_teste:

            if (cmd_teste.Enabled)
            {
                cmd_teste.Enabled = false;
                
            }
            else
            {
                cmd_teste.Enabled = true;
            }
            
            
        }

        private void cmd_teste_MouseEnter(object sender, EventArgs e)
        {
            cmd_teste.BackgroundImage = cmd_high;
        }

        private void cmd_teste_MouseLeave(object sender, EventArgs e)
        {
            cmd_teste.BackgroundImage = cmd_normal;
        }

        private void cmd_teste_Click(object sender, EventArgs e)
        {
            //Criar a folha em branco:

            Bitmap imgback = new Bitmap(pic_teste.Width,pic_teste.Height);

            Graphics desenhador = Graphics.FromImage(imgback);

            //Atribuir uma cor de fundo à imagem:
            desenhador.Clear(Color.White);

            //Desenhar um retângulo na imagem:
            Pen caneta = new Pen(Color.CadetBlue,10);
            Rectangle rec = new Rectangle();
            rec.Width = pic_teste.Width / 2;
            rec.Height = pic_teste.Height / 2;

            rec.X = pic_teste.Location.X + pic_teste.Width / 2 - rec.Width/2;
            rec.Y = pic_teste.Location.Y + pic_teste.Height / 2 - rec.Height/2;

            desenhador.DrawRectangle(caneta, rec);

            Brush pincelote = new SolidBrush(Color.Yellow);

            desenhador.FillRectangle(pincelote, rec);
            
            //Apresentar a imagem:
            pic_teste.BackgroundImage = imgback;

        }

        private void cmd_teste_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void cmd_teste_EnabledChanged(object sender, EventArgs e)
        {
            if(cmd_teste.Enabled)
            {
                cmd_teste.BackgroundImage = cmd_normal;
            }
            else
            {
                cmd_teste.BackgroundImage = cmd_disable;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Criar a folha em branco:

            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);

            Graphics desenhador = Graphics.FromImage(imgback);

            //Atribuir uma cor de fundo à imagem:


            Brush pincelote = new SolidBrush(Color.Yellow);

            List<Pen> canetas = new List<Pen>() {
            new Pen(Color.CadetBlue, 10),
           new Pen(Color.Red, 10),
            new Pen(Color.Green, 10),
            new Pen(Color.LightPink, 10),
            new Pen(Color.Magenta, 10) };

            desenhador.Clear(Color.White);

            Rectangle linha = new Rectangle();
            linha.X = 12;

            linha.Width = 529;
            pic_teste.BackgroundImage = imgback;

            linha.Height = 4;

            int negativo = -1;

            int opan = 1;

            

            foreach (Pen caneta in canetas)
            {
                negativo = negativo + 1;

                linha.Y = 12 + negativo;

                desenhador.DrawLine(caneta, new Point(12,12 + negativo), new Point(12 + pic_teste.Width, 12 + negativo));
                

                if (negativo == 312)
                {
                    pic_teste.BackgroundImage = imgback;
                    opan = opan + 2;
                    MessageBox.Show("Terminou");
                }
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Bitmap imgback = new Bitmap(pic_teste.Width,pic_teste.Height);

            //Graphics desenhista = Graphics.FromImage(imgback);

            //Pen lapis = new Pen(Color.Black,10);


            //Brush pincel = new SolidBrush(Color.Yellow);
            //Brush pincel_venenoso = new LinearGradientBrush(new Point(pic_teste.Location.X + pic_teste.Width / 2, pic_teste.Location.Y + pic_teste.Height / 2), new Point(pic_teste.Location.X + pic_teste.Width / 2 + 50, pic_teste.Location.Y + pic_teste.Height / 2 + 50), Color.DarkGreen, Color.LimeGreen);

            ////Atribuir cor ao fundo da imagem:



            //////Desenhar uma linha horizontal:
            ////desenhista.DrawLine(lapis, new Point(12, 12), new Point(540, 12));

            //////Obliqua:
            ////desenhista.DrawLine(lapis, new Point(20,20), new Point(250,250));

            //////Desenhar Linha Quebrada:

            ////Point[] pontos = { new Point(50,60), new Point(60,70), new Point(80,20), new Point(100, 80), new Point(130, 10), new Point(150, 100), };

            ////desenhista.DrawLines(lapis,pontos);

            //////Desenhar uma circunferência:

            ////desenhista.DrawEllipse(lapis, new Rectangle(pic_teste.Location.X + pic_teste.Width/2 - 50 , pic_teste.Location.Y + pic_teste.Height/2 - 50,100,100));

            ////desenhista.FillRectangle(pincel_venenoso, new Rectangle(pic_teste.Location.X + pic_teste.Width / 2 - 25, pic_teste.Location.Y + pic_teste.Height / 2 - 25,50,50));



            ////string texto = "Enaldo Pererira já contou até o infinito duas vezes. Teve uma vez que ele deu um soco na Terra, e até hoje ela está rodando.";
            //Font letra = new Font("Palatino Linotype",30,FontStyle.Italic,GraphicsUnit.Pixel);

            //Rectangle tangulo = new Rectangle();

            //tangulo.Height = 200;
            //tangulo.Width = 400;
            //tangulo.X = pic_teste.Location.X + pic_teste.Width / 2 - tangulo.Width / 2;
            //tangulo.Y = pic_teste.Location.Y + pic_teste.Height / 2 - tangulo.Height / 2;

            ////StringFormat fátuo = new StringFormat();
            ////fátuo.Alignment = StringAlignment.Center;
            ////fátuo.LineAlignment = StringAlignment.Center;

            ////desenhista.DrawString(texto, letra, pincel_venenoso, tangulo, fátuo);

            //Image bolinha = Image.FromFile(pasta_imagens + "bolinha.png");

            //desenhista.Clear(Color.WhiteSmoke);

            ////Cortar e colar uma porção da Imagem:

            //Rectangle corte = new Rectangle();
            //corte.X = 244;
            //corte.Y = 559;
            //corte.Width = tangulo.Width + 400;
            //corte.Height = tangulo.Height + 400;



            ////desenhista.DrawImage(bola, tangulo,corte,GraphicsUnit.Pixel);

            //desenhista.DrawImage(bolinha, new Rectangle(tangulo.X,tangulo.Y,240,240), new Rectangle(0,0,240,240),GraphicsUnit.Pixel);

            //pic_teste.BackgroundImage = imgback;
            cl_bola b = new cl_bola();
            BOLAS.Add(b);
            tempo.Enabled = true;
            
        }

        private void Desenhar()
        {

            Rectangle tangulo = new Rectangle();

            tangulo.Height = 200;
            tangulo.Width = 400;
            tangulo.X = pic_teste.Location.X + pic_teste.Width / 2 - tangulo.Width / 2;
            tangulo.Y = pic_teste.Location.Y + pic_teste.Height / 2 - tangulo.Height / 2;


            Bitmap imgback = new Bitmap(pic_teste.Width, pic_teste.Height);

            Graphics desenhista = Graphics.FromImage(imgback);

            Image bolinha = Image.FromFile(pasta_imagens + "bolinha.png");

            desenhista.Clear(Color.WhiteSmoke);

            //ciclo que percorre por todas as bolas existentes:

            foreach(cl_bola bola in BOLAS)
            {
                bola.Mover(largura, altura);
                desenhista.DrawImage(bolinha,
                                     new Rectangle(bola.x, bola.y, 140, 140),
                                     new Rectangle(0, 0, 240, 240), GraphicsUnit.Pixel);
            }

            //desenhista.DrawImage(bolinha, new Rectangle(BOLAS[0].x, BOLAS[0].y, 140, 140), new Rectangle(0, 0, 240, 240), GraphicsUnit.Pixel);

            pic_teste.BackgroundImage = imgback;


        }

        private void tempo_Tick(object sender, EventArgs e)
        {

            Desenhar();
        }

        //==========================================================================
    }
}
