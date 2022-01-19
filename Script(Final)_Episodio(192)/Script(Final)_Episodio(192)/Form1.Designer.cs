
namespace Script_Final__Episodio_192_
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_carregar = new System.Windows.Forms.Button();
            this.pic_imagem = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_sair
            // 
            this.cmd_sair.Location = new System.Drawing.Point(397, 376);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(75, 23);
            this.cmd_sair.TabIndex = 0;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_carregar
            // 
            this.cmd_carregar.Location = new System.Drawing.Point(12, 376);
            this.cmd_carregar.Name = "cmd_carregar";
            this.cmd_carregar.Size = new System.Drawing.Size(84, 23);
            this.cmd_carregar.TabIndex = 1;
            this.cmd_carregar.Text = "Exportar...";
            this.toolTip1.SetToolTip(this.cmd_carregar, "Exportar uma imagem");
            this.cmd_carregar.UseVisualStyleBackColor = true;
            this.cmd_carregar.Click += new System.EventHandler(this.cmd_carregar_Click);
            // 
            // pic_imagem
            // 
            this.pic_imagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_imagem.Location = new System.Drawing.Point(12, 12);
            this.pic_imagem.Name = "pic_imagem";
            this.pic_imagem.Size = new System.Drawing.Size(385, 289);
            this.pic_imagem.TabIndex = 2;
            this.pic_imagem.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.pic_imagem);
            this.Controls.Add(this.cmd_carregar);
            this.Controls.Add(this.cmd_sair);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pic_imagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_carregar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pic_imagem;
    }
}

