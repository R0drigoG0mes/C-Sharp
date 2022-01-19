
namespace Script53_Episodio_178_
{
    partial class frmLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.text_utilizador = new System.Windows.Forms.TextBox();
            this.cmd_entrar = new System.Windows.Forms.Button();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.text_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_visualizar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // text_utilizador
            // 
            this.text_utilizador.BackColor = System.Drawing.Color.Lime;
            this.text_utilizador.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_utilizador.ForeColor = System.Drawing.Color.Black;
            this.text_utilizador.Location = new System.Drawing.Point(12, 25);
            this.text_utilizador.MaxLength = 30;
            this.text_utilizador.Name = "text_utilizador";
            this.text_utilizador.Size = new System.Drawing.Size(203, 30);
            this.text_utilizador.TabIndex = 2;
            // 
            // cmd_entrar
            // 
            this.cmd_entrar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd_entrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_entrar.ForeColor = System.Drawing.Color.LimeGreen;
            this.cmd_entrar.Location = new System.Drawing.Point(249, 103);
            this.cmd_entrar.Name = "cmd_entrar";
            this.cmd_entrar.Size = new System.Drawing.Size(70, 26);
            this.cmd_entrar.TabIndex = 3;
            this.cmd_entrar.Text = "Entrar";
            this.cmd_entrar.UseVisualStyleBackColor = false;
            this.cmd_entrar.Click += new System.EventHandler(this.cmd_entrar_Click);
            this.cmd_entrar.MouseEnter += new System.EventHandler(this.cmd_entrar_MouseEnter);
            this.cmd_entrar.MouseLeave += new System.EventHandler(this.cmd_entrar_MouseLeave);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmd_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_cancelar.ForeColor = System.Drawing.Color.LimeGreen;
            this.cmd_cancelar.Location = new System.Drawing.Point(12, 103);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(77, 26);
            this.cmd_cancelar.TabIndex = 4;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.cmd_cancelar_Click);
            this.cmd_cancelar.MouseEnter += new System.EventHandler(this.cmd_cancelar_MouseEnter);
            this.cmd_cancelar.MouseLeave += new System.EventHandler(this.cmd_cancelar_MouseLeave);
            // 
            // text_password
            // 
            this.text_password.BackColor = System.Drawing.Color.Lime;
            this.text_password.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_password.ForeColor = System.Drawing.Color.Black;
            this.text_password.Location = new System.Drawing.Point(93, 61);
            this.text_password.MaxLength = 30;
            this.text_password.Name = "text_password";
            this.text_password.PasswordChar = '*';
            this.text_password.Size = new System.Drawing.Size(203, 30);
            this.text_password.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "Senha:";
            // 
            // check_visualizar
            // 
            this.check_visualizar.AutoSize = true;
            this.check_visualizar.BackColor = System.Drawing.Color.Black;
            this.check_visualizar.ForeColor = System.Drawing.Color.LimeGreen;
            this.check_visualizar.Location = new System.Drawing.Point(302, 77);
            this.check_visualizar.Name = "check_visualizar";
            this.check_visualizar.Size = new System.Drawing.Size(15, 14);
            this.check_visualizar.TabIndex = 7;
            this.check_visualizar.UseVisualStyleBackColor = false;
            this.check_visualizar.CheckedChanged += new System.EventHandler(this.check_visualizar_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(331, 141);
            this.Controls.Add(this.check_visualizar);
            this.Controls.Add(this.text_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.cmd_entrar);
            this.Controls.Add(this.text_utilizador);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_utilizador;
        private System.Windows.Forms.Button cmd_entrar;
        private System.Windows.Forms.Button cmd_cancelar;
        private System.Windows.Forms.TextBox text_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_visualizar;
    }
}