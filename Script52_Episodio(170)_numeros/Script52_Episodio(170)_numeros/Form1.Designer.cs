
namespace Script52_Episodio_170__numeros
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
            this.text1 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.label_resultados = new System.Windows.Forms.Label();
            this.cmd_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text1
            // 
            this.text1.BackColor = System.Drawing.Color.Indigo;
            this.text1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.ForeColor = System.Drawing.Color.Yellow;
            this.text1.Location = new System.Drawing.Point(160, 275);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(170, 23);
            this.text1.TabIndex = 0;
            // 
            // text2
            // 
            this.text2.BackColor = System.Drawing.Color.Indigo;
            this.text2.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.ForeColor = System.Drawing.Color.Yellow;
            this.text2.Location = new System.Drawing.Point(160, 301);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(170, 23);
            this.text2.TabIndex = 1;
            // 
            // label_resultados
            // 
            this.label_resultados.BackColor = System.Drawing.Color.Indigo;
            this.label_resultados.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados.ForeColor = System.Drawing.Color.Yellow;
            this.label_resultados.Location = new System.Drawing.Point(54, 90);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(376, 167);
            this.label_resultados.TabIndex = 2;
            this.label_resultados.Text = "Resultado";
            this.label_resultados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmd_executar
            // 
            this.cmd_executar.BackColor = System.Drawing.Color.Indigo;
            this.cmd_executar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_executar.ForeColor = System.Drawing.Color.Yellow;
            this.cmd_executar.Location = new System.Drawing.Point(397, 376);
            this.cmd_executar.Name = "cmd_executar";
            this.cmd_executar.Size = new System.Drawing.Size(75, 23);
            this.cmd_executar.TabIndex = 3;
            this.cmd_executar.Text = "EXECUTAR";
            this.cmd_executar.UseVisualStyleBackColor = false;
            this.cmd_executar.Click += new System.EventHandler(this.cmd_executar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.cmd_executar);
            this.Controls.Add(this.label_resultados);
            this.Controls.Add(this.text2);
            this.Controls.Add(this.text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button cmd_executar;
    }
}

