
namespace Script42_Episódio_98_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.label_título = new System.Windows.Forms.Label();
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.cmd_sair = new System.Windows.Forms.Button();
            this.cmd_adicionar = new System.Windows.Forms.Button();
            this.cmd_ver_tudo = new System.Windows.Forms.Button();
            this.label_versao = new System.Windows.Forms.Label();
            this.cmd_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_título
            // 
            this.label_título.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_título.ForeColor = System.Drawing.Color.Lime;
            this.label_título.Location = new System.Drawing.Point(55, 9);
            this.label_título.Name = "label_título";
            this.label_título.Size = new System.Drawing.Size(325, 66);
            this.label_título.TabIndex = 0;
            this.label_título.Text = "Contatos";
            this.label_título.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_título.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.Blue;
            this.cmd_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_pesquisar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_pesquisar.Location = new System.Drawing.Point(119, 194);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(197, 50);
            this.cmd_pesquisar.TabIndex = 1;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.cmd_pesquisar_Click);
            // 
            // cmd_sair
            // 
            this.cmd_sair.BackColor = System.Drawing.Color.MediumBlue;
            this.cmd_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_sair.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_sair.ForeColor = System.Drawing.Color.Lime;
            this.cmd_sair.Location = new System.Drawing.Point(119, 310);
            this.cmd_sair.Name = "cmd_sair";
            this.cmd_sair.Size = new System.Drawing.Size(197, 50);
            this.cmd_sair.TabIndex = 2;
            this.cmd_sair.Text = "Sair";
            this.cmd_sair.UseVisualStyleBackColor = false;
            this.cmd_sair.Click += new System.EventHandler(this.cmd_sair_Click);
            // 
            // cmd_adicionar
            // 
            this.cmd_adicionar.BackColor = System.Drawing.Color.Blue;
            this.cmd_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_adicionar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_adicionar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_adicionar.Location = new System.Drawing.Point(119, 136);
            this.cmd_adicionar.Name = "cmd_adicionar";
            this.cmd_adicionar.Size = new System.Drawing.Size(197, 50);
            this.cmd_adicionar.TabIndex = 3;
            this.cmd_adicionar.Text = "Adicionar";
            this.cmd_adicionar.UseVisualStyleBackColor = false;
            this.cmd_adicionar.Click += new System.EventHandler(this.cmd_adicionar_Click);
            // 
            // cmd_ver_tudo
            // 
            this.cmd_ver_tudo.BackColor = System.Drawing.Color.Blue;
            this.cmd_ver_tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_ver_tudo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ver_tudo.ForeColor = System.Drawing.Color.Lime;
            this.cmd_ver_tudo.Location = new System.Drawing.Point(119, 78);
            this.cmd_ver_tudo.Name = "cmd_ver_tudo";
            this.cmd_ver_tudo.Size = new System.Drawing.Size(197, 50);
            this.cmd_ver_tudo.TabIndex = 4;
            this.cmd_ver_tudo.Text = "Vizualizar Tudo";
            this.cmd_ver_tudo.UseVisualStyleBackColor = false;
            this.cmd_ver_tudo.Click += new System.EventHandler(this.cmd_ver_tudo_Click);
            // 
            // label_versao
            // 
            this.label_versao.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_versao.ForeColor = System.Drawing.Color.ForestGreen;
            this.label_versao.Location = new System.Drawing.Point(119, 379);
            this.label_versao.Name = "label_versao";
            this.label_versao.Size = new System.Drawing.Size(197, 23);
            this.label_versao.TabIndex = 5;
            this.label_versao.Text = "Agenda SQL";
            this.label_versao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label_versao.Click += new System.EventHandler(this.label_versao_Click);
            // 
            // cmd_reset
            // 
            this.cmd_reset.BackColor = System.Drawing.Color.Blue;
            this.cmd_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_reset.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_reset.ForeColor = System.Drawing.Color.Lime;
            this.cmd_reset.Location = new System.Drawing.Point(119, 252);
            this.cmd_reset.Name = "cmd_reset";
            this.cmd_reset.Size = new System.Drawing.Size(197, 50);
            this.cmd_reset.TabIndex = 6;
            this.cmd_reset.Text = "Deletar Contatos";
            this.cmd_reset.UseVisualStyleBackColor = false;
            this.cmd_reset.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_reset);
            this.Controls.Add(this.label_versao);
            this.Controls.Add(this.cmd_ver_tudo);
            this.Controls.Add(this.cmd_adicionar);
            this.Controls.Add(this.cmd_sair);
            this.Controls.Add(this.cmd_pesquisar);
            this.Controls.Add(this.label_título);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "AGENDA";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_título;
        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Button cmd_sair;
        private System.Windows.Forms.Button cmd_adicionar;
        private System.Windows.Forms.Button cmd_ver_tudo;
        private System.Windows.Forms.Label label_versao;
        private System.Windows.Forms.Button cmd_reset;
    }
}

