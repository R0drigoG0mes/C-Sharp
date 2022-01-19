
namespace Script09_Matemática
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.label_resultado = new System.Windows.Forms.Label();
            this.text_parcela_1 = new System.Windows.Forms.TextBox();
            this.text_parcela_2 = new System.Windows.Forms.TextBox();
            this.btn_2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.ForeColor = System.Drawing.Color.Black;
            this.btn_1.Location = new System.Drawing.Point(12, 152);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(90, 28);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Somar";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.BackColor = System.Drawing.Color.SpringGreen;
            this.label_resultado.ForeColor = System.Drawing.Color.Black;
            this.label_resultado.Location = new System.Drawing.Point(12, 103);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(374, 23);
            this.label_resultado.TabIndex = 1;
            this.label_resultado.Text = "Resultado";
            // 
            // text_parcela_1
            // 
            this.text_parcela_1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.text_parcela_1.Location = new System.Drawing.Point(12, 12);
            this.text_parcela_1.Name = "text_parcela_1";
            this.text_parcela_1.Size = new System.Drawing.Size(217, 20);
            this.text_parcela_1.TabIndex = 2;
            // 
            // text_parcela_2
            // 
            this.text_parcela_2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.text_parcela_2.Location = new System.Drawing.Point(12, 60);
            this.text_parcela_2.Name = "text_parcela_2";
            this.text_parcela_2.Size = new System.Drawing.Size(217, 20);
            this.text_parcela_2.TabIndex = 3;
            this.text_parcela_2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(312, 312);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(110, 37);
            this.btn_2.TabIndex = 4;
            this.btn_2.Text = "Finalizar";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.text_parcela_2);
            this.Controls.Add(this.text_parcela_1);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.btn_1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Somas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label_resultado;
        private System.Windows.Forms.TextBox text_parcela_1;
        private System.Windows.Forms.TextBox text_parcela_2;
        private System.Windows.Forms.Button btn_2;
    }
}

