namespace Windows.FormsPessoaFisica
{
    partial class FormListaPessoaFisica
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLocalizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.ToolStrip();
            this.MenuButtonNovo = new System.Windows.Forms.ToolStripButton();
            this.MenuButtonEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFechar = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.menuButton.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtLocalizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 35);
            this.panel1.TabIndex = 16;
            // 
            // txtLocalizar
            // 
            this.txtLocalizar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLocalizar.Location = new System.Drawing.Point(65, 9);
            this.txtLocalizar.Name = "txtLocalizar";
            this.txtLocalizar.Size = new System.Drawing.Size(500, 20);
            this.txtLocalizar.TabIndex = 3;
            this.txtLocalizar.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Localizar";
            // 
            // menuButton
            // 
            this.menuButton.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuButton.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNovo,
            this.MenuButtonEditar,
            this.toolStripSeparator1});
            this.menuButton.Location = new System.Drawing.Point(0, 24);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(784, 27);
            this.menuButton.TabIndex = 15;
            this.menuButton.Text = "toolStrip1";
            // 
            // MenuButtonNovo
            // 
            this.MenuButtonNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonNovo.Image = global::Windows.Properties.Resources.Novo;
            this.MenuButtonNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonNovo.Name = "MenuButtonNovo";
            this.MenuButtonNovo.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonNovo.Text = "Novo";
            this.MenuButtonNovo.Click += new System.EventHandler(this.MenuButtonNovo_Click);
            // 
            // MenuButtonEditar
            // 
            this.MenuButtonEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonEditar.Image = global::Windows.Properties.Resources.Editar;
            this.MenuButtonEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonEditar.Name = "MenuButtonEditar";
            this.MenuButtonEditar.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonEditar.Text = "Editar";
            this.MenuButtonEditar.Click += new System.EventHandler(this.MenuButtonEditar_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(784, 24);
            this.menuPrincipal.TabIndex = 14;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemNovo,
            this.MenuItemEditar,
            this.toolStripMenuItem2,
            this.MenuItemFechar});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // MenuItemNovo
            // 
            this.MenuItemNovo.Image = global::Windows.Properties.Resources.Novo;
            this.MenuItemNovo.Name = "MenuItemNovo";
            this.MenuItemNovo.Size = new System.Drawing.Size(109, 22);
            this.MenuItemNovo.Text = "Novo";
            // 
            // MenuItemEditar
            // 
            this.MenuItemEditar.Image = global::Windows.Properties.Resources.Editar;
            this.MenuItemEditar.Name = "MenuItemEditar";
            this.MenuItemEditar.Size = new System.Drawing.Size(109, 22);
            this.MenuItemEditar.Text = "Editar";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(106, 6);
            // 
            // MenuItemFechar
            // 
            this.MenuItemFechar.Name = "MenuItemFechar";
            this.MenuItemFechar.Size = new System.Drawing.Size(109, 22);
            this.MenuItemFechar.Text = "Fechar";
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 409);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 22);
            this.panel2.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 86);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 323);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Grid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 297);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lista";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Grid
            // 
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grid.Location = new System.Drawing.Point(3, 3);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(770, 291);
            this.Grid.TabIndex = 0;
            // 
            // FormListaPessoaFisica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 431);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.menuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormListaPessoaFisica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pessoa Fisica";
            this.Activated += new System.EventHandler(this.FormListaPessoaFisica_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuButton.ResumeLayout(false);
            this.menuButton.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip menuButton;
        private System.Windows.Forms.ToolStripButton MenuButtonNovo;
        private System.Windows.Forms.ToolStripButton MenuButtonEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuItemEditar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFechar;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView Grid;
    }
}