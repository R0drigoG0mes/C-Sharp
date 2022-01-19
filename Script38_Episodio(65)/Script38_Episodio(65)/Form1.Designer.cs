
namespace Script38_Episodio_65_
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
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_calcular = new System.Windows.Forms.Button();
            this.text_operacao = new System.Windows.Forms.TextBox();
            this.label_algoritmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_sair
            // 
            this.cmd_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_sair.Location = new System.Drawing.Point(12, 368);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(89, 31);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_calcular
            // 
            this.cmd_calcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_calcular.Location = new System.Drawing.Point(317, 316);
            this.cmd_calcular.Name = "cmd_calcular";
            this.cmd_calcular.Size = new System.Drawing.Size(110, 35);
            this.cmd_calcular.TabIndex = 1;
            this.cmd_calcular.Text = "Calcular";
            this.cmd_calcular.UseVisualStyleBackColor = true;
            this.cmd_calcular.Click += new System.EventHandler(this.cmd_calcular_Click);
            // 
            // text_operacao
            // 
            this.text_operacao.Location = new System.Drawing.Point(12, 61);
            this.text_operacao.MaxLength = 30;
            this.text_operacao.Name = "text_operacao";
            this.text_operacao.Size = new System.Drawing.Size(409, 20);
            this.text_operacao.TabIndex = 0;
            this.text_operacao.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.text_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_operacao_KeyDown);
            // 
            // label_algoritmo
            // 
            this.label_algoritmo.AutoSize = true;
            this.label_algoritmo.Location = new System.Drawing.Point(9, 26);
            this.label_algoritmo.Name = "label_algoritmo";
            this.label_algoritmo.Size = new System.Drawing.Size(104, 13);
            this.label_algoritmo.TabIndex = 3;
            this.label_algoritmo.Text = "Escreva o Algoritmo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label_algoritmo);
            this.Controls.Add(this.text_operacao);
            this.Controls.Add(this.cmd_calcular);
            this.Controls.Add(this.cmd_sair);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_calcular;
        private System.Windows.Forms.TextBox text_operacao;
        private System.Windows.Forms.Label label_algoritmo;
    }
}

