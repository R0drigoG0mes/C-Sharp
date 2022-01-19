
namespace Script42_Episódio_98_
{
    partial class frmPesquisa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisa));
            this.cmd_pesquisar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_pesquisa = new System.Windows.Forms.TextBox();
            this.cmd_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_pesquisar
            // 
            this.cmd_pesquisar.BackColor = System.Drawing.Color.Blue;
            this.cmd_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_pesquisar.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_pesquisar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_pesquisar.Location = new System.Drawing.Point(193, 75);
            this.cmd_pesquisar.Name = "cmd_pesquisar";
            this.cmd_pesquisar.Size = new System.Drawing.Size(81, 29);
            this.cmd_pesquisar.TabIndex = 0;
            this.cmd_pesquisar.Text = "Pesquisar";
            this.cmd_pesquisar.UseVisualStyleBackColor = false;
            this.cmd_pesquisar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "PESQUISAR";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_pesquisa
            // 
            this.text_pesquisa.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_pesquisa.ForeColor = System.Drawing.Color.Blue;
            this.text_pesquisa.Location = new System.Drawing.Point(11, 35);
            this.text_pesquisa.MaxLength = 30;
            this.text_pesquisa.Name = "text_pesquisa";
            this.text_pesquisa.Size = new System.Drawing.Size(263, 26);
            this.text_pesquisa.TabIndex = 2;
            this.text_pesquisa.TextChanged += new System.EventHandler(this.text_pesquisa_TextChanged);
            // 
            // cmd_cancelar
            // 
            this.cmd_cancelar.BackColor = System.Drawing.Color.Blue;
            this.cmd_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_cancelar.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_cancelar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_cancelar.Location = new System.Drawing.Point(11, 75);
            this.cmd_cancelar.Name = "cmd_cancelar";
            this.cmd_cancelar.Size = new System.Drawing.Size(81, 24);
            this.cmd_cancelar.TabIndex = 3;
            this.cmd_cancelar.Text = "Cancelar";
            this.cmd_cancelar.UseVisualStyleBackColor = false;
            this.cmd_cancelar.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_cancelar);
            this.Controls.Add(this.text_pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmd_pesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPesquisa";
            this.Load += new System.EventHandler(this.frmPesquisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_pesquisar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_pesquisa;
        private System.Windows.Forms.Button cmd_cancelar;
    }
}