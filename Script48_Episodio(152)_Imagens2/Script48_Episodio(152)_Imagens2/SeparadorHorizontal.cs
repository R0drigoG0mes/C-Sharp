using System;
using System.Drawing;
using System.Windows.Forms;

namespace Script48_Episodio_152__Imagens2
{
    //===============================================================================
    public partial class SeparadorHorizontal : UserControl
    {
        private byte _alphaEscuro = 100;
        private byte _alphaClaro = 200;
        private Color _corEscura = Color.Black;
        private Color _corClara = Color.White;

        //===============================================================================
        //Implementar as propriedades:

        public byte AlphaEscuro
        {
            get
            {
                return _alphaEscuro;
            }
            set
            {
                _alphaEscuro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }

        //===============================================================================
        public byte AlphaClaro
        {
            get
            {
                return _alphaClaro;
            }
            set
            {
                _alphaClaro = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
        }

        //===============================================================================
        public Color CorEscura
        {

            get
            {
                return _corEscura;
            }
            set
            {
                _corEscura = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }

        }

        //===============================================================================
        public Color CorClara 
        {

            get
            {
                return _corClara;
            }
            set
            {
                _corClara = value;
                SeparadorHorizontal_Resize(this, EventArgs.Empty);
            }
                    
        }

        //===========================================================================
        public SeparadorHorizontal()
        {
            InitializeComponent();

            //Características Genéricas:
            this.BackColor = Color.Transparent;
            this.BackgroundImageLayout = ImageLayout.None;
            SeparadorHorizontal_Resize(this, EventArgs.Empty);
        }

        //===========================================================================
        private void SeparadorHorizontal_Load(object sender, EventArgs e)
        {
         


        }

        //===============================================================================
        private void SeparadorHorizontal_Resize(object sender, EventArgs e)
        {
            //Desenhar as linhas (aspecto visual do controle):

            this.Height = 4;

            Bitmap imgBack = new Bitmap(this.Width, this.Height);

            Graphics desenhador = Graphics.FromImage(imgBack);

            Pen _CorClara = new Pen(Color.FromArgb(_alphaClaro,_corClara), 2);
            Pen _CorEscura = new Pen(Color.FromArgb(_alphaEscuro,_corEscura), 2);

            Point[] pontos_1 = {new Point(),new Point() };

            //Desenhar as linhas:

            //Escuro:
            desenhador.DrawLine(_CorEscura, new Point(1, 1), new Point(this.Width - 3, 1));
            desenhador.DrawLine(_CorEscura, new Point(1,1), new Point(1,2));
            
            //Claro:
            desenhador.DrawLine(_CorClara, new Point(2,2), new Point(this.Width - 2, 2));
            desenhador.DrawLine(_CorClara, new Point(this.Width - 2,1), new Point(this.Width - 2, 2));

            this.BackgroundImage = imgBack;
        }
    }
    //===============================================================================
}
