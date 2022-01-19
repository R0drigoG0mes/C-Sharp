
namespace Script_26_Vários_Formulários
{
    partial class frmUm
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
            this.cmdFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdFechar
            // 
            this.cmdFechar.Location = new System.Drawing.Point(150, 170);
            this.cmdFechar.Name = "cmdFechar";
            this.cmdFechar.Size = new System.Drawing.Size(125, 70);
            this.cmdFechar.TabIndex = 2;
            this.cmdFechar.Text = "Fechar";
            this.cmdFechar.UseVisualStyleBackColor = true;
            this.cmdFechar.Click += new System.EventHandler(this.cmdFechar_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 411);
            this.Controls.Add(this.cmdFechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdFechar;
    }
}