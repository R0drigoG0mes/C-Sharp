
namespace Script27_Episódio_46_
{
    partial class Frm1
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
            this.cmd_avançar = new System.Windows.Forms.Button();
            this.label_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_avançar
            // 
            this.cmd_avançar.Location = new System.Drawing.Point(338, 363);
            this.cmd_avançar.Name = "cmd_avançar";
            this.cmd_avançar.Size = new System.Drawing.Size(84, 36);
            this.cmd_avançar.TabIndex = 0;
            this.cmd_avançar.Text = "Executar";
            this.cmd_avançar.UseVisualStyleBackColor = true;
            this.cmd_avançar.Click += new System.EventHandler(this.cmd_avançar_Click);
            // 
            // label_texto
            // 
            this.label_texto.Location = new System.Drawing.Point(13, 13);
            this.label_texto.Name = "label_texto";
            this.label_texto.Size = new System.Drawing.Size(409, 60);
            this.label_texto.TabIndex = 1;
            this.label_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label_texto);
            this.Controls.Add(this.cmd_avançar);
            this.Name = "Frm1";
            this.Text = "FRM_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_avançar;
        private System.Windows.Forms.Label label_texto;
    }
}

