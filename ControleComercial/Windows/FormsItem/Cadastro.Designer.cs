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
            this.tpGeral = new System.Windows.Forms.TabPage();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbUnidadeMedida = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tpClasse = new System.Windows.Forms.TabPage();
            this.gridClasse = new System.Windows.Forms.DataGridView();
            this.tsClasse = new System.Windows.Forms.ToolStrip();
            this.MenuButtonNovoClasse = new System.Windows.Forms.ToolStripButton();
            this.MenuButtonDeletarClasse = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tpEspecificacao = new System.Windows.Forms.TabPage();
            this.gridEspecificacao = new System.Windows.Forms.DataGridView();
            this.tsEspecificacao = new System.Windows.Forms.ToolStrip();
            this.MenuButtonNovaEspecificacao = new System.Windows.Forms.ToolStripButton();
            this.MenuButtonDeletarEspecificacao = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.label7 = new System.Windows.Forms.Label();
            this.cbFabricante = new System.Windows.Forms.ComboBox();
            this.lblGravar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcDados.SuspendLayout();
            this.tpGeral.SuspendLayout();
            this.tpClasse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClasse)).BeginInit();
            this.tsClasse.SuspendLayout();
            this.tpEspecificacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecificacao)).BeginInit();
            this.tsEspecificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblGravar);
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
            this.groupBox1.Size = new System.Drawing.Size(622, 102);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Principais";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Location = new System.Drawing.Point(96, 45);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(400, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(96, 19);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 1;
            this.txtId.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identificador";
            // 
            // tcDados
            // 
            this.tcDados.Controls.Add(this.tpGeral);
            this.tcDados.Controls.Add(this.tpClasse);
            this.tcDados.Controls.Add(this.tpEspecificacao);
            this.tcDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDados.Location = new System.Drawing.Point(0, 102);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(622, 234);
            this.tcDados.TabIndex = 27;
            // 
            // tpGeral
            // 
            this.tpGeral.Controls.Add(this.label7);
            this.tpGeral.Controls.Add(this.txtPreco);
            this.tpGeral.Controls.Add(this.txtDesconto);
            this.tpGeral.Controls.Add(this.cbFabricante);
            this.tpGeral.Controls.Add(this.txtQuantidade);
            this.tpGeral.Controls.Add(this.label6);
            this.tpGeral.Controls.Add(this.cbUnidadeMedida);
            this.tpGeral.Controls.Add(this.label4);
            this.tpGeral.Controls.Add(this.label5);
            this.tpGeral.Controls.Add(this.label3);
            this.tpGeral.Location = new System.Drawing.Point(4, 22);
            this.tpGeral.Name = "tpGeral";
            this.tpGeral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeral.Size = new System.Drawing.Size(614, 208);
            this.tpGeral.TabIndex = 0;
            this.tpGeral.Text = "Geral";
            this.tpGeral.UseVisualStyleBackColor = true;
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.SystemColors.Window;
            this.txtPreco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPreco.Location = new System.Drawing.Point(92, 87);
            this.txtPreco.MaxLength = 18;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.ReadOnly = true;
            this.txtPreco.Size = new System.Drawing.Size(140, 20);
            this.txtPreco.TabIndex = 70;
            this.txtPreco.Text = "0,00";
            this.txtPreco.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
            // 
            // txtDesconto
            // 
            this.txtDesconto.BackColor = System.Drawing.SystemColors.Window;
            this.txtDesconto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDesconto.Location = new System.Drawing.Point(387, 87);
            this.txtDesconto.MaxLength = 18;
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.ReadOnly = true;
            this.txtDesconto.Size = new System.Drawing.Size(140, 20);
            this.txtDesconto.TabIndex = 69;
            this.txtDesconto.Text = "0,00";
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesconto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDesconto_KeyPress);
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Location = new System.Drawing.Point(387, 60);
            this.txtQuantidade.MaxLength = 18;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(140, 20);
            this.txtQuantidade.TabIndex = 68;
            this.txtQuantidade.Text = "0,000";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 67;
            this.label6.Text = "Unidade Medida";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbUnidadeMedida
            // 
            this.cbUnidadeMedida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUnidadeMedida.FormattingEnabled = true;
            this.cbUnidadeMedida.Location = new System.Drawing.Point(92, 60);
            this.cbUnidadeMedida.Name = "cbUnidadeMedida";
            this.cbUnidadeMedida.Size = new System.Drawing.Size(200, 21);
            this.cbUnidadeMedida.TabIndex = 66;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(317, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Desconto %";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Preço R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade";
            // 
            // tpClasse
            // 
            this.tpClasse.Controls.Add(this.gridClasse);
            this.tpClasse.Controls.Add(this.tsClasse);
            this.tpClasse.Location = new System.Drawing.Point(4, 22);
            this.tpClasse.Name = "tpClasse";
            this.tpClasse.Padding = new System.Windows.Forms.Padding(3);
            this.tpClasse.Size = new System.Drawing.Size(614, 208);
            this.tpClasse.TabIndex = 1;
            this.tpClasse.Text = "Classe";
            this.tpClasse.UseVisualStyleBackColor = true;
            // 
            // gridClasse
            // 
            this.gridClasse.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridClasse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridClasse.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridClasse.Location = new System.Drawing.Point(3, 30);
            this.gridClasse.Name = "gridClasse";
            this.gridClasse.Size = new System.Drawing.Size(608, 175);
            this.gridClasse.TabIndex = 32;
            // 
            // tsClasse
            // 
            this.tsClasse.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsClasse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNovoClasse,
            this.MenuButtonDeletarClasse,
            this.toolStripSeparator1});
            this.tsClasse.Location = new System.Drawing.Point(3, 3);
            this.tsClasse.Name = "tsClasse";
            this.tsClasse.Size = new System.Drawing.Size(608, 27);
            this.tsClasse.TabIndex = 31;
            this.tsClasse.Text = "toolStrip1";
            // 
            // MenuButtonNovoClasse
            // 
            this.MenuButtonNovoClasse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonNovoClasse.Image = global::Windows.Properties.Resources.novo1;
            this.MenuButtonNovoClasse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonNovoClasse.Name = "MenuButtonNovoClasse";
            this.MenuButtonNovoClasse.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonNovoClasse.Text = "Novo";
            this.MenuButtonNovoClasse.Click += new System.EventHandler(this.MenuButtonNovoClasse_Click);
            // 
            // MenuButtonDeletarClasse
            // 
            this.MenuButtonDeletarClasse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonDeletarClasse.Image = global::Windows.Properties.Resources.delete;
            this.MenuButtonDeletarClasse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonDeletarClasse.Name = "MenuButtonDeletarClasse";
            this.MenuButtonDeletarClasse.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonDeletarClasse.Text = "Deletar";
            this.MenuButtonDeletarClasse.Click += new System.EventHandler(this.MenuButtonDeletarClasse_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // tpEspecificacao
            // 
            this.tpEspecificacao.Controls.Add(this.gridEspecificacao);
            this.tpEspecificacao.Controls.Add(this.tsEspecificacao);
            this.tpEspecificacao.Location = new System.Drawing.Point(4, 22);
            this.tpEspecificacao.Name = "tpEspecificacao";
            this.tpEspecificacao.Padding = new System.Windows.Forms.Padding(3);
            this.tpEspecificacao.Size = new System.Drawing.Size(614, 218);
            this.tpEspecificacao.TabIndex = 2;
            this.tpEspecificacao.Text = "Especificação";
            this.tpEspecificacao.UseVisualStyleBackColor = true;
            // 
            // gridEspecificacao
            // 
            this.gridEspecificacao.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridEspecificacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridEspecificacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEspecificacao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEspecificacao.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridEspecificacao.Location = new System.Drawing.Point(3, 30);
            this.gridEspecificacao.Name = "gridEspecificacao";
            this.gridEspecificacao.Size = new System.Drawing.Size(608, 185);
            this.gridEspecificacao.TabIndex = 33;
            // 
            // tsEspecificacao
            // 
            this.tsEspecificacao.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsEspecificacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNovaEspecificacao,
            this.MenuButtonDeletarEspecificacao,
            this.toolStripSeparator2});
            this.tsEspecificacao.Location = new System.Drawing.Point(3, 3);
            this.tsEspecificacao.Name = "tsEspecificacao";
            this.tsEspecificacao.Size = new System.Drawing.Size(608, 27);
            this.tsEspecificacao.TabIndex = 32;
            this.tsEspecificacao.Text = "toolStrip1";
            // 
            // MenuButtonNovaEspecificacao
            // 
            this.MenuButtonNovaEspecificacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonNovaEspecificacao.Image = global::Windows.Properties.Resources.novo1;
            this.MenuButtonNovaEspecificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonNovaEspecificacao.Name = "MenuButtonNovaEspecificacao";
            this.MenuButtonNovaEspecificacao.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonNovaEspecificacao.Text = "Novo";
            this.MenuButtonNovaEspecificacao.Click += new System.EventHandler(this.MenuButtonNovaEspecificacao_Click);
            // 
            // MenuButtonDeletarEspecificacao
            // 
            this.MenuButtonDeletarEspecificacao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MenuButtonDeletarEspecificacao.Image = global::Windows.Properties.Resources.delete;
            this.MenuButtonDeletarEspecificacao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MenuButtonDeletarEspecificacao.Name = "MenuButtonDeletarEspecificacao";
            this.MenuButtonDeletarEspecificacao.Size = new System.Drawing.Size(24, 24);
            this.MenuButtonDeletarEspecificacao.Text = "Deletar";
            this.MenuButtonDeletarEspecificacao.ToolTipText = "Deletar";
            this.MenuButtonDeletarEspecificacao.Click += new System.EventHandler(this.MenuButtonDeletarEspecificacao_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Fabricante";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbFabricante
            // 
            this.cbFabricante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFabricante.FormattingEnabled = true;
            this.cbFabricante.Location = new System.Drawing.Point(92, 33);
            this.cbFabricante.Name = "cbFabricante";
            this.cbFabricante.Size = new System.Drawing.Size(200, 21);
            this.cbFabricante.TabIndex = 71;
            // 
            // lblGravar
            // 
            this.lblGravar.AutoSize = true;
            this.lblGravar.Location = new System.Drawing.Point(236, 8);
            this.lblGravar.Name = "lblGravar";
            this.lblGravar.Size = new System.Drawing.Size(0, 13);
            this.lblGravar.TabIndex = 73;
            this.lblGravar.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcDados.ResumeLayout(false);
            this.tpGeral.ResumeLayout(false);
            this.tpGeral.PerformLayout();
            this.tpClasse.ResumeLayout(false);
            this.tpClasse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClasse)).EndInit();
            this.tsClasse.ResumeLayout(false);
            this.tsClasse.PerformLayout();
            this.tpEspecificacao.ResumeLayout(false);
            this.tpEspecificacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEspecificacao)).EndInit();
            this.tsEspecificacao.ResumeLayout(false);
            this.tsEspecificacao.PerformLayout();
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
        private System.Windows.Forms.TabPage tpGeral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tpClasse;
        private System.Windows.Forms.TabPage tpEspecificacao;
        private System.Windows.Forms.ToolStrip tsClasse;
        private System.Windows.Forms.ToolStripButton MenuButtonNovoClasse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip tsEspecificacao;
        private System.Windows.Forms.ToolStripButton MenuButtonNovaEspecificacao;
        private System.Windows.Forms.ToolStripButton MenuButtonDeletarEspecificacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridView gridClasse;
        private System.Windows.Forms.DataGridView gridEspecificacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUnidadeMedida;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.ToolStripButton MenuButtonDeletarClasse;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbFabricante;
        private System.Windows.Forms.Label lblGravar;
    }
}