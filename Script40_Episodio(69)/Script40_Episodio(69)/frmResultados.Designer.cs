
namespace Script40_Episodio_69_
{
    partial class frmResultados
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
            this.cmd_nova_pesquisa = new System.Windows.Forms.Button();
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.lista_final = new System.Windows.Forms.ListBox();
            this.label_número_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_nova_pesquisa
            // 
            this.cmd_nova_pesquisa.Location = new System.Drawing.Point(12, 227);
            this.cmd_nova_pesquisa.Name = "cmd_nova_pesquisa";
            this.cmd_nova_pesquisa.Size = new System.Drawing.Size(102, 31);
            this.cmd_nova_pesquisa.TabIndex = 0;
            this.cmd_nova_pesquisa.Text = "Nova Pesquisa...";
            this.cmd_nova_pesquisa.UseVisualStyleBackColor = true;
            this.cmd_nova_pesquisa.Click += new System.EventHandler(this.cmd_nova_pesquisa_Click);
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(437, 287);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(75, 31);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // lista_final
            // 
            this.lista_final.FormattingEnabled = true;
            this.lista_final.Location = new System.Drawing.Point(12, 29);
            this.lista_final.Name = "lista_final";
            this.lista_final.Size = new System.Drawing.Size(500, 186);
            this.lista_final.TabIndex = 2;
            // 
            // label_número_registros
            // 
            this.label_número_registros.Location = new System.Drawing.Point(372, 227);
            this.label_número_registros.Name = "label_número_registros";
            this.label_número_registros.Size = new System.Drawing.Size(140, 31);
            this.label_número_registros.TabIndex = 8;
            this.label_número_registros.Text = "Total de Registros:";
            this.label_número_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_número_registros.Click += new System.EventHandler(this.label_número_registros_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 330);
            this.ControlBox = false;
            this.Controls.Add(this.label_número_registros);
            this.Controls.Add(this.lista_final);
            this.Controls.Add(this.cmd_fechar);
            this.Controls.Add(this.cmd_nova_pesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todos os Resultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_nova_pesquisa;
        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.ListBox lista_final;
        private System.Windows.Forms.Label label_número_registros;
    }
}