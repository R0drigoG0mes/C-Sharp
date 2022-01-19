
namespace Script22_Abstração
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
            this.rd1 = new System.Windows.Forms.RadioButton();
            this.rd2 = new System.Windows.Forms.RadioButton();
            this.rd3 = new System.Windows.Forms.RadioButton();
            this.caixa_preço = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_executar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd1
            // 
            this.rd1.AutoSize = true;
            this.rd1.Checked = true;
            this.rd1.Location = new System.Drawing.Point(157, 63);
            this.rd1.Name = "rd1";
            this.rd1.Size = new System.Drawing.Size(91, 17);
            this.rd1.TabIndex = 0;
            this.rd1.TabStop = true;
            this.rd1.Text = "Copo de Leite";
            this.rd1.UseVisualStyleBackColor = true;
            // 
            // rd2
            // 
            this.rd2.AutoSize = true;
            this.rd2.Location = new System.Drawing.Point(157, 87);
            this.rd2.Name = "rd2";
            this.rd2.Size = new System.Drawing.Size(60, 17);
            this.rd2.TabIndex = 1;
            this.rd2.Text = "Martelo";
            this.rd2.UseVisualStyleBackColor = true;
            this.rd2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rd3
            // 
            this.rd3.Location = new System.Drawing.Point(157, 114);
            this.rd3.Name = "rd3";
            this.rd3.Size = new System.Drawing.Size(93, 38);
            this.rd3.TabIndex = 2;
            this.rd3.Text = "Perfume";
            this.rd3.UseVisualStyleBackColor = true;
            // 
            // caixa_preço
            // 
            this.caixa_preço.Location = new System.Drawing.Point(157, 192);
            this.caixa_preço.Name = "caixa_preço";
            this.caixa_preço.Size = new System.Drawing.Size(59, 20);
            this.caixa_preço.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(138, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Adicione um Valor :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(157, 239);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(93, 27);
            this.btn_executar.TabIndex = 5;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 41);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.caixa_preço);
            this.Controls.Add(this.rd3);
            this.Controls.Add(this.rd2);
            this.Controls.Add(this.rd1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd1;
        private System.Windows.Forms.RadioButton rd2;
        private System.Windows.Forms.RadioButton rd3;
        private System.Windows.Forms.TextBox caixa_preço;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Button button1;
    }
}

