
namespace Script49_Episodio_155__Impressão
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.documento = new System.Drawing.Printing.PrintDocument();
            this.lista = new System.Windows.Forms.ListBox();
            this.caixa_setup = new System.Windows.Forms.PrintDialog();
            this.Visualizar = new System.Windows.Forms.PrintPreviewControl();
            this.pagina_seguinte = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.caixa_visualizacao = new System.Windows.Forms.PrintPreviewDialog();
            this.progresso = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(516, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // documento
            // 
            this.documento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.documento_PrintPage);
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(516, 12);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(83, 69);
            this.lista.TabIndex = 1;
            // 
            // caixa_setup
            // 
            this.caixa_setup.UseEXDialog = true;
            // 
            // Visualizar
            // 
            this.Visualizar.Location = new System.Drawing.Point(12, 12);
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.Size = new System.Drawing.Size(488, 387);
            this.Visualizar.TabIndex = 2;
            // 
            // pagina_seguinte
            // 
            this.pagina_seguinte.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pagina_seguinte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pagina_seguinte.ForeColor = System.Drawing.Color.White;
            this.pagina_seguinte.Location = new System.Drawing.Point(506, 236);
            this.pagina_seguinte.Name = "pagina_seguinte";
            this.pagina_seguinte.Size = new System.Drawing.Size(47, 22);
            this.pagina_seguinte.TabIndex = 3;
            this.pagina_seguinte.Text = "-->";
            this.pagina_seguinte.UseVisualStyleBackColor = false;
            this.pagina_seguinte.Click += new System.EventHandler(this.pagina_seguinte_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(506, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "<--";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(506, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pág.";
            // 
            // caixa_visualizacao
            // 
            this.caixa_visualizacao.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.caixa_visualizacao.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.caixa_visualizacao.ClientSize = new System.Drawing.Size(400, 300);
            this.caixa_visualizacao.Enabled = true;
            this.caixa_visualizacao.Icon = ((System.Drawing.Icon)(resources.GetObject("caixa_visualizacao.Icon")));
            this.caixa_visualizacao.Name = "caixa_visualizacao";
            this.caixa_visualizacao.Visible = false;
            // 
            // progresso
            // 
            this.progresso.Location = new System.Drawing.Point(176, 390);
            this.progresso.Name = "progresso";
            this.progresso.Size = new System.Drawing.Size(237, 23);
            this.progresso.TabIndex = 6;
            this.progresso.Click += new System.EventHandler(this.progresso_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 425);
            this.Controls.Add(this.progresso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pagina_seguinte);
            this.Controls.Add(this.Visualizar);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument documento;
        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.PrintDialog caixa_setup;
        private System.Windows.Forms.PrintPreviewControl Visualizar;
        private System.Windows.Forms.Button pagina_seguinte;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog caixa_visualizacao;
        private System.Windows.Forms.ProgressBar progresso;
    }
}

