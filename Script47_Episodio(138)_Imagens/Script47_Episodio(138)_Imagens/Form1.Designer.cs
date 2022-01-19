
namespace Script47_Episodio_138__Imagens
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
            this.pic_teste = new System.Windows.Forms.PictureBox();
            this.cmd_teste = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.picture_alvo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tempo = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_teste
            // 
            this.pic_teste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_teste.Location = new System.Drawing.Point(1, 12);
            this.pic_teste.Name = "pic_teste";
            this.pic_teste.Size = new System.Drawing.Size(550, 300);
            this.pic_teste.TabIndex = 0;
            this.pic_teste.TabStop = false;
            // 
            // cmd_teste
            // 
            this.cmd_teste.BackColor = System.Drawing.Color.Transparent;
            this.cmd_teste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmd_teste.Location = new System.Drawing.Point(459, 354);
            this.cmd_teste.Name = "cmd_teste";
            this.cmd_teste.Size = new System.Drawing.Size(82, 31);
            this.cmd_teste.TabIndex = 3;
            this.cmd_teste.TabStop = false;
            this.cmd_teste.EnabledChanged += new System.EventHandler(this.cmd_teste_EnabledChanged);
            this.cmd_teste.Click += new System.EventHandler(this.cmd_teste_Click);
            this.cmd_teste.MouseEnter += new System.EventHandler(this.cmd_teste_MouseEnter);
            this.cmd_teste.MouseLeave += new System.EventHandler(this.cmd_teste_MouseLeave);
            this.cmd_teste.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cmd_teste_MouseUp);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // picture_alvo
            // 
            this.picture_alvo.Location = new System.Drawing.Point(63, 362);
            this.picture_alvo.Name = "picture_alvo";
            this.picture_alvo.Size = new System.Drawing.Size(75, 23);
            this.picture_alvo.TabIndex = 2;
            this.picture_alvo.Text = "button2";
            this.picture_alvo.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(250, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(357, 344);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tempo
            // 
            this.tempo.Tick += new System.EventHandler(this.tempo_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(553, 397);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmd_teste);
            this.Controls.Add(this.picture_alvo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pic_teste);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_teste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmd_teste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_teste;
        private System.Windows.Forms.PictureBox cmd_teste;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button picture_alvo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer tempo;
    }
}

