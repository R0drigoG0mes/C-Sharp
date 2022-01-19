
namespace Script42_Episódio_98_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.cmd_fechar = new System.Windows.Forms.Button();
            this.grelha_resultados = new System.Windows.Forms.DataGridView();
            this.label_resultados = new System.Windows.Forms.Label();
            this.cmd_apagar = new System.Windows.Forms.Button();
            this.cmd_editar = new System.Windows.Forms.Button();
            this.cmd_ver_tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grelha_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_fechar
            // 
            this.cmd_fechar.BackColor = System.Drawing.Color.Blue;
            this.cmd_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_fechar.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_fechar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_fechar.Location = new System.Drawing.Point(547, 371);
            this.cmd_fechar.Name = "cmd_fechar";
            this.cmd_fechar.Size = new System.Drawing.Size(84, 37);
            this.cmd_fechar.TabIndex = 0;
            this.cmd_fechar.Text = "Fechar";
            this.cmd_fechar.UseVisualStyleBackColor = false;
            this.cmd_fechar.Click += new System.EventHandler(this.cmd_fechar_Click);
            // 
            // grelha_resultados
            // 
            this.grelha_resultados.AllowUserToAddRows = false;
            this.grelha_resultados.AllowUserToDeleteRows = false;
            this.grelha_resultados.BackgroundColor = System.Drawing.Color.MediumAquamarine;
            this.grelha_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grelha_resultados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grelha_resultados.GridColor = System.Drawing.Color.Blue;
            this.grelha_resultados.Location = new System.Drawing.Point(12, 12);
            this.grelha_resultados.Name = "grelha_resultados";
            this.grelha_resultados.ReadOnly = true;
            this.grelha_resultados.RowHeadersVisible = false;
            this.grelha_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grelha_resultados.Size = new System.Drawing.Size(610, 353);
            this.grelha_resultados.TabIndex = 1;
            this.grelha_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grelha_resultados_CellClick);
            // 
            // label_resultados
            // 
            this.label_resultados.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_resultados.ForeColor = System.Drawing.Color.Lime;
            this.label_resultados.Location = new System.Drawing.Point(13, 371);
            this.label_resultados.Name = "label_resultados";
            this.label_resultados.Size = new System.Drawing.Size(275, 31);
            this.label_resultados.TabIndex = 2;
            this.label_resultados.Click += new System.EventHandler(this.label_resultados_Click);
            // 
            // cmd_apagar
            // 
            this.cmd_apagar.BackColor = System.Drawing.Color.Blue;
            this.cmd_apagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_apagar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_apagar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_apagar.Location = new System.Drawing.Point(294, 371);
            this.cmd_apagar.Name = "cmd_apagar";
            this.cmd_apagar.Size = new System.Drawing.Size(77, 28);
            this.cmd_apagar.TabIndex = 3;
            this.cmd_apagar.Text = "Apagar";
            this.cmd_apagar.UseVisualStyleBackColor = false;
            this.cmd_apagar.Click += new System.EventHandler(this.cmd_apagar_Click);
            // 
            // cmd_editar
            // 
            this.cmd_editar.BackColor = System.Drawing.Color.Blue;
            this.cmd_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_editar.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_editar.ForeColor = System.Drawing.Color.Lime;
            this.cmd_editar.Location = new System.Drawing.Point(377, 371);
            this.cmd_editar.Name = "cmd_editar";
            this.cmd_editar.Size = new System.Drawing.Size(77, 28);
            this.cmd_editar.TabIndex = 4;
            this.cmd_editar.Text = "Editar";
            this.cmd_editar.UseVisualStyleBackColor = false;
            this.cmd_editar.Click += new System.EventHandler(this.cmd_editar_Click);
            // 
            // cmd_ver_tudo
            // 
            this.cmd_ver_tudo.BackColor = System.Drawing.Color.Blue;
            this.cmd_ver_tudo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmd_ver_tudo.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_ver_tudo.ForeColor = System.Drawing.Color.Lime;
            this.cmd_ver_tudo.Location = new System.Drawing.Point(460, 371);
            this.cmd_ver_tudo.Name = "cmd_ver_tudo";
            this.cmd_ver_tudo.Size = new System.Drawing.Size(81, 37);
            this.cmd_ver_tudo.TabIndex = 5;
            this.cmd_ver_tudo.Text = "Ver Tudo";
            this.cmd_ver_tudo.UseVisualStyleBackColor = false;
            this.cmd_ver_tudo.Click += new System.EventHandler(this.cmd_ver_tudo_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.ControlBox = false;
            this.Controls.Add(this.cmd_ver_tudo);
            this.Controls.Add(this.cmd_editar);
            this.Controls.Add(this.cmd_apagar);
            this.Controls.Add(this.label_resultados);
            this.Controls.Add(this.grelha_resultados);
            this.Controls.Add(this.cmd_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta e Manipulação";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grelha_resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_fechar;
        private System.Windows.Forms.DataGridView grelha_resultados;
        private System.Windows.Forms.Label label_resultados;
        private System.Windows.Forms.Button cmd_apagar;
        private System.Windows.Forms.Button cmd_editar;
        private System.Windows.Forms.Button cmd_ver_tudo;
    }
}