
namespace Script_26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.label_a = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.Location = new System.Drawing.Point(257, 332);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(115, 67);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Iniciar";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // label_a
            // 
            this.label_a.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_a.Location = new System.Drawing.Point(99, 59);
            this.label_a.Name = "label_a";
            this.label_a.Size = new System.Drawing.Size(173, 61);
            this.label_a.TabIndex = 1;
            this.label_a.Click += new System.EventHandler(this.label_a_Click);
            this.label_a.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label_a_MouseDown);
            this.label_a.MouseEnter += new System.EventHandler(this.label_a_MouseEnter);
            this.label_a.MouseLeave += new System.EventHandler(this.label_a_MouseLeave);
            this.label_a.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label_a_MouseUp);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Image = ((System.Drawing.Image)(resources.GetObject("btn_2.Image")));
            this.btn_2.Location = new System.Drawing.Point(12, 332);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(109, 67);
            this.btn_2.TabIndex = 2;
            this.btn_2.Text = "Finalizar";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 192);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(173, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(384, 411);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.label_a);
            this.Controls.Add(this.btn1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label label_a;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

