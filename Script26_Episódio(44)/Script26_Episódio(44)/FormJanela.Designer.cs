
namespace Script26_Episódio_44_
{
    partial class FormJanela
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
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.label_resultado_final = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_outra = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.Location = new System.Drawing.Point(50, 335);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(96, 40);
            this.cmd_fechar.TabIndex = 1;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = true;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // label_resultado_final
            // 
            this.label_resultado_final.AutoSize = true;
            this.label_resultado_final.Location = new System.Drawing.Point(13, 13);
            this.label_resultado_final.Name = "label_resultado_final";
            this.label_resultado_final.Size = new System.Drawing.Size(35, 13);
            this.label_resultado_final.TabIndex = 2;
            this.label_resultado_final.Text = "label1";
            this.label_resultado_final.Click += new System.EventHandler(this.label_resultado_final_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_outra
            // 
            this.label_outra.AutoSize = true;
            this.label_outra.Location = new System.Drawing.Point(16, 104);
            this.label_outra.Name = "label_outra";
            this.label_outra.Size = new System.Drawing.Size(35, 13);
            this.label_outra.TabIndex = 4;
            this.label_outra.Text = "label1";
            this.label_outra.Click += new System.EventHandler(this.label_outra_Click);
            // 
            // FormJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 411);
            this.Controls.Add(this.label_outra);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label_resultado_final);
            this.Controls.Add(this.cmd_fechar);
            this.Name = "FormJanela";
            this.Text = "FormJanela";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.Label label_resultado_final;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_outra;
    }
}