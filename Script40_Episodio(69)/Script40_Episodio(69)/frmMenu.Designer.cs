
namespace Script40_Episodio_69_
{
    partial class frmMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmd_inserir_editar = new System.Windows.Forms.Button();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.label_versão = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "AGENDA TELEFÔNICA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmd_inserir_editar
            // 
            this.cmd_inserir_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_inserir_editar.Location = new System.Drawing.Point(190, 70);
            this.cmd_inserir_editar.Name = "cmd_inserir_editar";
            this.cmd_inserir_editar.Size = new System.Drawing.Size(105, 41);
            this.cmd_inserir_editar.TabIndex = 1;
            this.cmd_inserir_editar.Text = "Inserir/Editar";
            this.cmd_inserir_editar.UseVisualStyleBackColor = true;
            this.cmd_inserir_editar.Click += new System.EventHandler(this.cmd_inserir_editar_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar.Location = new System.Drawing.Point(190, 135);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(105, 41);
            this.cmd_pesquisar.TabIndex = 2;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = true;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_sair.Location = new System.Drawing.Point(190, 200);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(105, 41);
            this.cmd_sair.TabIndex = 3;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = true;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // label_versão
            // 
            this.label_versão.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versão.Location = new System.Drawing.Point(37, 427);
            this.label_versão.Name = "label_versão";
            this.label_versão.Size = new System.Drawing.Size(410, 23);
            this.label_versão.TabIndex = 4;
            this.label_versão.Text = "Versão do Programa";
            this.label_versão.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label_versão);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.cmd_inserir_editar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmd_inserir_editar;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Label label_versão;
    }
}

