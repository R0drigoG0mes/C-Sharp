
namespace Script51_Episodio_167_
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
            this.cmd_enviar = new System.Windows.Forms.Button();
            this.text_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_enviar
            // 
            this.cmd_enviar.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_enviar.ForeColor = System.Drawing.Color.Red;
            this.cmd_enviar.Location = new System.Drawing.Point(12, 288);
            this.cmd_enviar.Name = "cmd_enviar";
            this.cmd_enviar.Size = new System.Drawing.Size(460, 61);
            this.cmd_enviar.TabIndex = 0;
            this.cmd_enviar.Text = "ENVIAR MENSAGEM";
            this.cmd_enviar.UseVisualStyleBackColor = true;
            this.cmd_enviar.Click += new System.EventHandler(this.cmd_enviar_Click);
            // 
            // text_email
            // 
            this.text_email.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.text_email.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_email.ForeColor = System.Drawing.Color.Yellow;
            this.text_email.Location = new System.Drawing.Point(12, 123);
            this.text_email.Name = "text_email";
            this.text_email.Size = new System.Drawing.Size(460, 23);
            this.text_email.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(9, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Email:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 132);
            this.button1.TabIndex = 3;
            this.button1.Text = "VERIFICAR MENSAGEM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.text_email);
            this.Controls.Add(this.cmd_enviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_enviar;
        private System.Windows.Forms.TextBox text_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

