﻿
namespace Script21_ConstantesEstruturas
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.caixa_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Font = new System.Drawing.Font("Papyrus", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_executar.ForeColor = System.Drawing.Color.Blue;
            this.btn_executar.Location = new System.Drawing.Point(139, 297);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(135, 52);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "EXECUTAR";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // caixa_texto
            // 
            this.caixa_texto.Location = new System.Drawing.Point(13, 13);
            this.caixa_texto.Name = "caixa_texto";
            this.caixa_texto.Size = new System.Drawing.Size(409, 281);
            this.caixa_texto.TabIndex = 1;
            this.caixa_texto.Text = "Texto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 361);
            this.Controls.Add(this.caixa_texto);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label caixa_texto;
    }
}

