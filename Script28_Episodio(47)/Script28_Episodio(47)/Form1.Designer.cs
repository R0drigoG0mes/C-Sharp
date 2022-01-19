
namespace Script28_Episodio_47_
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
            this.menu_geral = new System.Windows.Forms.MenuStrip();
            this.mnu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnu_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proprietisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmd_falso = new System.Windows.Forms.Button();
            this.mnu_combo_1 = new System.Windows.Forms.ToolStripComboBox();
            this.label_resultado = new System.Windows.Forms.Label();
            this.menu_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_geral
            // 
            this.menu_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_file,
            this.editToolStripMenuItem,
            this.mnu_combo_1});
            this.menu_geral.Location = new System.Drawing.Point(0, 0);
            this.menu_geral.Name = "menu_geral";
            this.menu_geral.Size = new System.Drawing.Size(434, 27);
            this.menu_geral.TabIndex = 0;
            this.menu_geral.Text = "menuStrip1";
            this.menu_geral.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // mnu_file
            // 
            this.mnu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new,
            this.mnu_open,
            this.toolStripSeparator1,
            this.mnu_exit});
            this.mnu_file.Name = "mnu_file";
            this.mnu_file.Size = new System.Drawing.Size(37, 23);
            this.mnu_file.Text = "File";
            // 
            // mnu_new
            // 
            this.mnu_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_new_project,
            this.mnu_new_file});
            this.mnu_new.Name = "mnu_new";
            this.mnu_new.Size = new System.Drawing.Size(180, 22);
            this.mnu_new.Text = "New";
            // 
            // mnu_new_project
            // 
            this.mnu_new_project.Name = "mnu_new_project";
            this.mnu_new_project.Size = new System.Drawing.Size(111, 22);
            this.mnu_new_project.Text = "Project";
            // 
            // mnu_new_file
            // 
            this.mnu_new_file.Name = "mnu_new_file";
            this.mnu_new_file.Size = new System.Drawing.Size(111, 22);
            this.mnu_new_file.Text = "File";
            // 
            // mnu_open
            // 
            this.mnu_open.Name = "mnu_open";
            this.mnu_open.Size = new System.Drawing.Size(180, 22);
            this.mnu_open.Text = "Open";
            this.mnu_open.Click += new System.EventHandler(this.mnu_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // mnu_exit
            // 
            this.mnu_exit.Name = "mnu_exit";
            this.mnu_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnu_exit.Size = new System.Drawing.Size(180, 22);
            this.mnu_exit.Text = "Exit";
            this.mnu_exit.Click += new System.EventHandler(this.mnu_exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.proprietisToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 23);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // proprietisToolStripMenuItem
            // 
            this.proprietisToolStripMenuItem.Name = "proprietisToolStripMenuItem";
            this.proprietisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proprietisToolStripMenuItem.Text = "Proprietis";
            // 
            // cmd_falso
            // 
            this.cmd_falso.Location = new System.Drawing.Point(161, 228);
            this.cmd_falso.Name = "cmd_falso";
            this.cmd_falso.Size = new System.Drawing.Size(75, 23);
            this.cmd_falso.TabIndex = 1;
            this.cmd_falso.Text = "Executar";
            this.cmd_falso.UseVisualStyleBackColor = true;
            this.cmd_falso.Click += new System.EventHandler(this.cmd_falso_Click);
            // 
            // mnu_combo_1
            // 
            this.mnu_combo_1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mnu_combo_1.Name = "mnu_combo_1";
            this.mnu_combo_1.Size = new System.Drawing.Size(121, 23);
            this.mnu_combo_1.SelectedIndexChanged += new System.EventHandler(this.mnu_combo_1_SelectedIndexChanged);
            this.mnu_combo_1.Click += new System.EventHandler(this.mnu_combo_1_Click);
            // 
            // label_resultado
            // 
            this.label_resultado.Location = new System.Drawing.Point(46, 302);
            this.label_resultado.Name = "label_resultado";
            this.label_resultado.Size = new System.Drawing.Size(247, 54);
            this.label_resultado.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.label_resultado);
            this.Controls.Add(this.cmd_falso);
            this.Controls.Add(this.menu_geral);
            this.MainMenuStrip = this.menu_geral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu_geral.ResumeLayout(false);
            this.menu_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_geral;
        private System.Windows.Forms.ToolStripMenuItem mnu_file;
        private System.Windows.Forms.ToolStripMenuItem mnu_new;
        private System.Windows.Forms.ToolStripMenuItem mnu_open;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_project;
        private System.Windows.Forms.ToolStripMenuItem mnu_new_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnu_exit;
        private System.Windows.Forms.Button cmd_falso;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem proprietisToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mnu_combo_1;
        private System.Windows.Forms.Label label_resultado;
    }
}

