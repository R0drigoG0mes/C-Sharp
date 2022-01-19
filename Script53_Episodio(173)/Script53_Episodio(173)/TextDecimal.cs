using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Script53_Episodio_173_
{
    class TextDecimal : TextBox
    //=================================================================================================
    {
        //=============================================================================================
        //Enumeração da vírgula e do ponto:
        public enum EnumSeparador
        {
          Vírgula,Ponto  
        }

        //=============================================================================================

        //(Campos) propriedades:

        private double _minvalor = 0;
        private double _maxvalor = 100;
        private bool _permitirDecimais = true;
        private int _numeroCasasDecimais = 2;
        private double _valorDefeito = 0;
        private EnumSeparador _separador = EnumSeparador.Vírgula;
        //=============================================================================================

        #region Operalização Campos

        //=============================================================================================
        //Valor Mínimo:
        public double ValorMínimo
        {
            get { return _minvalor; }
            set { _minvalor = value; }
        }

        //=============================================================================================
        //Valor Máximo:
        public double ValorMáximo
        {
            get { return _maxvalor; }
            set { _maxvalor = value; }
        }

        //=============================================================================================
        //Permitir Decimais:
        public bool PermitirDecimais
        {
            get { return _permitirDecimais; }
            set { _permitirDecimais = value; }
        }

        //=============================================================================================
        //Número de Casas Decimais:
        public int NumeroCasasDecimais
        {
            get { return _numeroCasasDecimais; }
            set { _numeroCasasDecimais = value; }
        }

        //=============================================================================================
        //Valor por Defeito:
        public double ValorDefeito
        {
            get { return _valorDefeito; }
            set { _valorDefeito = value; }
        }

        //=============================================================================================
        //Tipo de Separador Decimal:

        public EnumSeparador SeparadorDecimal
        {
            get { return _separador; }
            set { _separador = value; }
        }

        #endregion

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    
        public TextDecimal()
        {
            //Eventos do controle, caixa de texto com números decimais:

            this.KeyPress += TextDecimal_KeyPress;
            this.LostFocus += TextDecimal_LostFocus;
            this.TextChanged += TextDecimal_TextChanged;
        }

        private void TextDecimal_TextChanged(object sender, EventArgs e)
        {

            //Executar verificações quando um texto é alterado:
            if (this.Focused) return;
            if (this.Text == "") return;

            //Verificar se o valor atribuído à caixa está dentro do limite:
            try
            {
                double valor = double.Parse(this.Text);
                //Verifica se o valor é interior ao minimo:

                //verifica se o valor é inferior ao mínimo:
                if (valor < _minvalor)
                {
                    valor = _minvalor;
                    this.Text = valor.ToString();
                    TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }

                //Verifica se o valor é superior ao máximo:

                if(valor > _maxvalor)
                {
                    valor = _maxvalor;
                    this.Text = valor.ToString();
                    TextDecimal_LostFocus(this, EventArgs.Empty);
                    return;
                }

            }

            catch
            {

                this.Text = ValorDefeito.ToString();
                TextDecimal_LostFocus(this, EventArgs.Empty);


            }
            
        }

        private void TextDecimal_LostFocus(object sender, EventArgs e)
        {
            //Executar operações quando a caixa parde o focus; 
            if (this.Text == "") return;

            #region Verificar qual é o Separador

            char separador = ',';

            if (_separador == EnumSeparador.Ponto) separador = '.';

            #endregion

            #region Substitui o separador, caso ele exista e seja diferente do selhecionado: 

            if(separador == ',')
            {
                this.Text = this.Text.Replace('.', ',');
            }
            else
            {
                this.Text = this.Text.Replace(',', '.');
            }

            #endregion

            #region Se o valor Inserido for apenas um separador:

            if(this.Text == separador.ToString())
            {
                if (_permitirDecimais)
                    this.Text = ValorDefeito.ToString();
            }

            #endregion

            #region No caso de ter casas decimais, verifica se estão corretas:

            if(_permitirDecimais && this.Text.Contains(separador))
            {
                //Se o número de casas decimais não é válido...
                string[] valores = this.Text.Split(separador);

                if(valores[1].Length < _numeroCasasDecimais)
                {

                    int emFalta = _numeroCasasDecimais - valores[1].Length;
                    valores[1] = valores[1] + new string('0', emFalta);
                    this.Text = valores[0] + separador + valores[1];

                }

                //Se o número de casas decimais é superior ao definido:

                if(valores[1].Length > _numeroCasasDecimais)
                {
                    double resultado = Math.Round(double.Parse(this.Text), _numeroCasasDecimais);
                    this.Text = resultado.ToString();
                }


            }

            #endregion

            #region Se a string começar com sinal negativo, mas contém logo em seguida o separador

            if (this.Text.Contains('-'))
            {

                int loc = this.Text.IndexOf('-');
                if(loc != 0)
                {
                    this.Text = "0";
                }

            }

            #endregion

            double valor = double.Parse(this.Text);
            this.Text = valor.ToString();

            #region Verifica se o valor mínimo e máximo foram considerados

            if(valor < _minvalor)
            {
                this.Text = _minvalor.ToString();
                TextDecimal_LostFocus(this, EventArgs.Empty);
            }
            if(valor > _maxvalor)
            {
                this.Text = _maxvalor.ToString();
                TextDecimal_LostFocus(this, EventArgs.Empty);
            }

            #endregion


        }

        private void TextDecimal_KeyPress(object sender, KeyPressEventArgs e)
        {
            # region Executar operações quando o utilizador pressiona teclas:

            int[] codigoTeclas;

            if (_permitirDecimais)
            {
                codigoTeclas = new int [] { 44, 45, 46, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8};
            }
            else
            {
                codigoTeclas = new int[] {45, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 8 };
            }

            #endregion

            #region Verifica se o caractere é válido

            if (!codigoTeclas.Contains(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            #endregion

            #region Verifica o Separador

            if (_permitirDecimais)
            {
                char valido = ',';
                char invalido = '.';

                if(_separador == EnumSeparador.Ponto)
                {
                    valido = '.';
                    invalido = ',';
                }

                //Verifica se pode ser inserido o separador:
                if (e.KeyChar == valido || e.KeyChar == invalido)
                {
                    if (this.Text.Contains(valido))
                    {
                        e.Handled = true;
                        return;
                    } 

                    //Verifica se é necessário substituir o separador:

                    if(e.KeyChar == invalido)
                    {
                        e.KeyChar = valido;
                    }


                }

            }

            #endregion

            #region Verificar se ja tem sinal negativo

            if(this.Text.Contains('-') && e.KeyChar == '-')
            {
                e.Handled = true;
                return;
            }

            #endregion

            #region Verifica se esta tentando colocar um sinal negativo após um separador

            char charValido = _separador == EnumSeparador.Vírgula ? ',' : '.';

            if (this.Text.Contains(charValido))
            {
                if (this.Text.IndexOf(charValido) < this.SelectionStart && e.KeyChar == '-')
                {
                    e.Handled = true;
                    return;
                }
            }

            #endregion

        }
    }
    //=================================================================================================
}
