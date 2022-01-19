
namespace Script53_Episodio_173_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textDecimal1 = new Script53_Episodio_173_.TextDecimal();
            this.SuspendLayout();
            // 
            // textDecimal1
            // 
            this.textDecimal1.Location = new System.Drawing.Point(189, 138);
            this.textDecimal1.Name = "textDecimal1";
            this.textDecimal1.NumeroCasasDecimais = 2;
            this.textDecimal1.PermitirDecimais = true;
            this.textDecimal1.SeparadorDecimal = Script53_Episodio_173_.TextDecimal.EnumSeparador.Vírgula;
            this.textDecimal1.Size = new System.Drawing.Size(100, 20);
            this.textDecimal1.TabIndex = 0;
            this.textDecimal1.ValorDefeito = 0D;
            this.textDecimal1.ValorMáximo = 100D;
            this.textDecimal1.ValorMínimo = 0D;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.textDecimal1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextDecimal textDecimal1;
    }
}

