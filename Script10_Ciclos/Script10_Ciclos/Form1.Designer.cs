
namespace Script10_Ciclos
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.lista = new System.Windows.Forms.ListBox();
            this.btn_fim = new System.Windows.Forms.Button();
            this.lista1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(323, 318);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(99, 31);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(12, 15);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(292, 277);
            this.lista.TabIndex = 1;
            this.lista.SelectedIndexChanged += new System.EventHandler(this.lista_SelectedIndexChanged);
            // 
            // btn_fim
            // 
            this.btn_fim.Location = new System.Drawing.Point(12, 318);
            this.btn_fim.Name = "btn_fim";
            this.btn_fim.Size = new System.Drawing.Size(90, 31);
            this.btn_fim.TabIndex = 2;
            this.btn_fim.Text = "Finalizar";
            this.btn_fim.UseVisualStyleBackColor = true;
            this.btn_fim.Click += new System.EventHandler(this.btn_fim_Click);
            // 
            // lista1
            // 
            this.lista1.FormattingEnabled = true;
            this.lista1.Location = new System.Drawing.Point(310, 17);
            this.lista1.Name = "lista1";
            this.lista1.Size = new System.Drawing.Size(120, 277);
            this.lista1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.lista1);
            this.Controls.Add(this.btn_fim);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btn_fim;
        private System.Windows.Forms.ListBox lista1;
    }
}

