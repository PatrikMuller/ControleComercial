namespace Windows.FormsItem
{
    partial class Cadastro
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gridFormaPgto = new System.Windows.Forms.DataGridView();
            this.menuFormaPagamento = new System.Windows.Forms.ToolStrip();
            this.MenuButtonNovoClasse = new System.Windows.Forms.ToolStripButton();
            this.MenuButtonEditarClasse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.MenuButtonNovaEspecificacao = new System.Windows.Forms.ToolStripButton();
            this.MenuButtonEditarEspecificacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcDados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).BeginInit();
            this.menuFormaPagamento.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 36);
            this.panel1.TabIndex = 25;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(96, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(14, 3);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 17;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(622, 98);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(93, 50);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(200, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(93, 24);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // tcDados
            // 
            this.tcDados.Controls.Add(this.tabPage1);
            this.tcDados.Controls.Add(this.tabPage2);
            this.tcDados.Controls.Add(this.tabPage3);
            this.tcDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDados.Location = new System.Drawing.Point(0, 98);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(622, 238);
            this.tcDados.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtDesconto);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtPreco);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txtQuantidade);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(614, 212);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDesconto
            // 
            this.txtDesconto.Location = new System.Drawing.Point(89, 43);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(140, 20);
            this.txtDesconto.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Desconto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(365, 17);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(140, 20);
            this.txtPreco.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preço";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(89, 17);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(140, 20);
            this.txtQuantidade.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gridFormaPgto);
            this.tabPage2.Controls.Add(this.menuFormaPagamento);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(614, 212);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Classe";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gridFormaPgto
            // 
            this.gridFormaPgto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridFormaPgto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFormaPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormaPgto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFormaPgto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFormaPgto.Location = new System.Drawing.Point(3, 30);
            this.gridFormaPgto.Name = "gridFormaPgto";
            this.gridFormaPgto.Size = new System.Drawing.Size(608, 179);
            this.gridFormaPgto.TabIndex = 32;
            // 
            // menuFormaPagamento
            // 
            this.menuFormaPagamento.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFormaPagamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNovoClasse,
            this.MenuButtonEditarClasse,
            this.toolStripSeparator1});
            this.menuFormaPagamento.Location = new System.Drawing.Point(3, 3);
            this.menuFormaPagamento.Name = "menuFormaPagamento";
            this.menuFormaPagamento.Size = new System.Drawing.Size(608, 27);
            this.menuFormaPagamento.TabIndex = 31;
            this.menuFormaPagamento.Text = "toolStrip1";
            // 
            // MenuButtonNovoClasse
            // 
            this.MenuButtonNovoClasse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonNovoClasse.Image = global::Windows.Properties.Resources.Novo;
            this.MenuButtonNovoClasse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonNovoClasse.Name = "MenuButtonNovoClasse";
            this.MenuButtonNovoClasse.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonNovoClasse.Text = "Novo";
            this.MenuButtonNovoClasse.Click += new System.EventHandler(this.MenuButtonNovoClasse_Click);
            // 
            // MenuButtonEditarClasse
            // 
            this.MenuButtonEditarClasse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonEditarClasse.Image = global::Windows.Properties.Resources.Editar;
            this.MenuButtonEditarClasse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonEditarClasse.Name = "MenuButtonEditarClasse";
            this.MenuButtonEditarClasse.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonEditarClasse.Text = "Editar";
            this.MenuButtonEditarClasse.Click += new System.EventHandler(this.MenuButtonEditarClasse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView1);
            this.tabPage3.Controls.Add(this.toolStrip1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(614, 212);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Especificação";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(3, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(608, 179);
            this.dataGridView1.TabIndex = 33;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNovaEspecificacao,
            this.MenuButtonEditarEspecificacao,
            this.toolStripSeparator2});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(608, 27);
            this.toolStrip1.TabIndex = 32;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // MenuButtonNovaEspecificacao
            // 
            this.MenuButtonNovaEspecificacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonNovaEspecificacao.Image = global::Windows.Properties.Resources.Novo;
            this.MenuButtonNovaEspecificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonNovaEspecificacao.Name = "MenuButtonNovaEspecificacao";
            this.MenuButtonNovaEspecificacao.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonNovaEspecificacao.Text = "Novo";
            this.MenuButtonNovaEspecificacao.Click += new System.EventHandler(this.MenuButtonNovaEspecificacao_Click);
            // 
            // MenuButtonEditarEspecificacao
            // 
            this.MenuButtonEditarEspecificacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonEditarEspecificacao.Image = global::Windows.Properties.Resources.Editar;
            this.MenuButtonEditarEspecificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonEditarEspecificacao.Name = "MenuButtonEditarEspecificacao";
            this.MenuButtonEditarEspecificacao.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonEditarEspecificacao.Text = "Editar";
            this.MenuButtonEditarEspecificacao.Click += new System.EventHandler(this.MenuButtonEditarEspecificacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 372);
            this.Controls.Add(this.tcDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Item";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcDados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).EndInit();
            this.menuFormaPagamento.ResumeLayout(false);
            this.menuFormaPagamento.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStrip menuFormaPagamento;
        private System.Windows.Forms.ToolStripButton MenuButtonNovoClasse;
        private System.Windows.Forms.ToolStripButton MenuButtonEditarClasse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton MenuButtonNovaEspecificacao;
        private System.Windows.Forms.ToolStripButton MenuButtonEditarEspecificacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView gridFormaPgto;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}