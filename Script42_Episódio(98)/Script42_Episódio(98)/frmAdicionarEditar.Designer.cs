
namespace Script42_Episódio_98_
{
    partial class frmAdicionarEditar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarEditar));
            this.cmd_salvar = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label_nome = new System.Windows.Forms.Label();
            this.text_nome = new System.Windows.Forms.TextBox();
            this.text_numero = new System.Windows.Forms.TextBox();
            this.label_numero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_salvar
            // 
            this.cmd_salvar.BackColor = System.Drawing.Color.Blue;
            this.cmd_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_salvar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_salvar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_salvar.Location = new System.Drawing.Point(213, 223);
            this.cmd_salvar.Name = "cmd_salvar";
            this.cmd_salvar.Size = new System.Drawing.Size(83, 26);
            this.cmd_salvar.TabIndex = 0;
            this.cmd_salvar.Text = "Salvar";
            this.cmd_salvar.UseVisualStyleBackColor = false;
            this.cmd_salvar.Click += new System.EventHandler(this.cmd_salvar_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Blue;
            this.cmd_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_fechar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_fechar.Location = new System.Drawing.Point(12, 223);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(83, 26);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Sair";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nome.ForeColor = System.Drawing.Color.Lime;
            this.label_nome.Location = new System.Drawing.Point(34, 28);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(48, 18);
            this.label_nome.TabIndex = 2;
            this.label_nome.Text = "Nome:";
            this.label_nome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // text_nome
            // 
            this.text_nome.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_nome.ForeColor = System.Drawing.Color.Blue;
            this.text_nome.Location = new System.Drawing.Point(34, 44);
            this.text_nome.MaxLength = 50;
            this.text_nome.Name = "text_nome";
            this.text_nome.Size = new System.Drawing.Size(240, 23);
            this.text_nome.TabIndex = 3;
            // 
            // text_numero
            // 
            this.text_numero.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_numero.ForeColor = System.Drawing.Color.Blue;
            this.text_numero.Location = new System.Drawing.Point(34, 101);
            this.text_numero.MaxLength = 15;
            this.text_numero.Name = "text_numero";
            this.text_numero.Size = new System.Drawing.Size(133, 23);
            this.text_numero.TabIndex = 5;
            // 
            // label_numero
            // 
            this.label_numero.AutoSize = true;
            this.label_numero.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numero.ForeColor = System.Drawing.Color.Lime;
            this.label_numero.Location = new System.Drawing.Point(34, 85);
            this.label_numero.Name = "label_numero";
            this.label_numero.Size = new System.Drawing.Size(70, 15);
            this.label_numero.TabIndex = 4;
            this.label_numero.Text = "Telefone:";
            this.label_numero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmAdicionarEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(308, 261);
            this.ControlBox = false;
            this.Controls.Add(this.text_numero);
            this.Controls.Add(this.label_numero);
            this.Controls.Add(this.text_nome);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_salvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdicionarEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar e Editar";
            this.Load += new System.EventHandler(this.frmAdicionarEditar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_salvar;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.TextBox text_nome;
        private System.Windows.Forms.TextBox text_numero;
        private System.Windows.Forms.Label label_numero;
    }
}