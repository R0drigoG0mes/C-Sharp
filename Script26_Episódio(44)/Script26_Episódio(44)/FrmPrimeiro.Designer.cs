
namespace Script26_Episódio_44_
{
    partial class FrmPrimeiro
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
            this.cmd_um = new System.Windows.Forms.Button();
            this.cmd_dois = new System.Windows.Forms.Button();
            this.cmd_finalizar = new System.Windows.Forms.Button();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_um
            // 
            this.cmd_um.Location = new System.Drawing.Point(29, 82);
            this.cmd_um.Name = "cmd_um";
            this.cmd_um.Size = new System.Drawing.Size(96, 40);
            this.cmd_um.TabIndex = 0;
            this.cmd_um.Text = "button1";
            this.cmd_um.UseVisualStyleBackColor = true;
            this.cmd_um.Click += new System.EventHandler(this.cmd_um_Click);
            // 
            // cmd_dois
            // 
            this.cmd_dois.Location = new System.Drawing.Point(242, 82);
            this.cmd_dois.Name = "cmd_dois";
            this.cmd_dois.Size = new System.Drawing.Size(86, 39);
            this.cmd_dois.TabIndex = 1;
            this.cmd_dois.Text = "button2";
            this.cmd_dois.UseVisualStyleBackColor = true;
            this.cmd_dois.Click += new System.EventHandler(this.btn2_Click);
            // 
            // cmd_finalizar
            // 
            this.cmd_finalizar.Location = new System.Drawing.Point(174, 186);
            this.cmd_finalizar.Name = "cmd_finalizar";
            this.cmd_finalizar.Size = new System.Drawing.Size(86, 39);
            this.cmd_finalizar.TabIndex = 2;
            this.cmd_finalizar.Text = "Finalizar";
            this.cmd_finalizar.UseVisualStyleBackColor = true;
            this.cmd_finalizar.Click += new System.EventHandler(this.cmd_finalizar_Click);
            // 
            // text_nome
            // 
            this.text_nome.Location = new System.Drawing.Point(12, 44);
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(315, 20);
            this.text_nome.TabIndex = 3;
            this.text_nome.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // FrmPrimeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.cmd_finalizar);
            this.Controls.Add(this.cmd_dois);
            this.Controls.Add(this.cmd_um);
            this.Name = "FrmPrimeiro";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrimeiro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_um;
        private System.Windows.Forms.Button cmd_dois;
        private System.Windows.Forms.Button cmd_finalizar;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.Label label1;
    }
}

