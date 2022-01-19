
namespace Script_26_Vários_Formulários
{
    partial class frm1
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
            this.cmd2 = new System.Windows.Forms.Button();
            this.cmd1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd2
            // 
            this.cmd2.Location = new System.Drawing.Point(120, 327);
            this.cmd2.Name = "cmd2";
            this.cmd2.Size = new System.Drawing.Size(99, 38);
            this.cmd2.TabIndex = 0;
            this.cmd2.Text = "Botãozin";
            this.cmd2.UseVisualStyleBackColor = true;
            // 
            // cmd1
            // 
            this.cmd1.Location = new System.Drawing.Point(107, 137);
            this.cmd1.Name = "cmd1";
            this.cmd1.Size = new System.Drawing.Size(125, 70);
            this.cmd1.TabIndex = 1;
            this.cmd1.Text = "Botãozão";
            this.cmd1.UseVisualStyleBackColor = true;
            this.cmd1.Click += new System.EventHandler(this.cmd1_Click);
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.cmd1);
            this.Controls.Add(this.cmd2);
            this.Name = "frm1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd2;
        private System.Windows.Forms.Button cmd1;
    }
}

