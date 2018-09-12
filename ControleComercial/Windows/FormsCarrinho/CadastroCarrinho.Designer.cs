namespace Windows.FormsCarrinho
{
    partial class CadastroCarrinho
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.Corpo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.gbFormaPgto = new System.Windows.Forms.GroupBox();
            this.gridFormaPgto = new System.Windows.Forms.DataGridView();
            this.btnFormaPgto = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gbVendedor = new System.Windows.Forms.GroupBox();
            this.lblVendedorNome = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVendedor = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.lblClienteCpfCnpj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteCNPJ = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbProdutos = new System.Windows.Forms.GroupBox();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.btnLocalizarCarrinho = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Rodape = new System.Windows.Forms.Panel();
            this.btnNovoCarrinho = new System.Windows.Forms.Button();
            this.txtIdCarrinho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCarrinho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.btnClienteCPF = new System.Windows.Forms.Button();
            this.Corpo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.gbFormaPgto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).BeginInit();
            this.panel7.SuspendLayout();
            this.gbVendedor.SuspendLayout();
            this.panel6.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.Rodape.SuspendLayout();
            this.Cabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Produto";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(318, 62);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizar.TabIndex = 1;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // Corpo
            // 
            this.Corpo.Controls.Add(this.panel5);
            this.Corpo.Controls.Add(this.panel4);
            this.Corpo.Controls.Add(this.panel1);
            this.Corpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo.Location = new System.Drawing.Point(0, 52);
            this.Corpo.Name = "Corpo";
            this.Corpo.Size = new System.Drawing.Size(1235, 492);
            this.Corpo.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtQuantidade);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.textBox1);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.btnLocalizar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 372);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(457, 120);
            this.panel5.TabIndex = 3;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Location = new System.Drawing.Point(12, 25);
            this.txtQuantidade.MaxLength = 18;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(160, 20);
            this.txtQuantidade.TabIndex = 60;
            this.txtQuantidade.Text = "1,234";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 372);
            this.panel4.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.gbFormaPgto);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 144);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(457, 180);
            this.panel8.TabIndex = 5;
            // 
            // gbFormaPgto
            // 
            this.gbFormaPgto.Controls.Add(this.gridFormaPgto);
            this.gbFormaPgto.Controls.Add(this.btnFormaPgto);
            this.gbFormaPgto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFormaPgto.Location = new System.Drawing.Point(0, 0);
            this.gbFormaPgto.Name = "gbFormaPgto";
            this.gbFormaPgto.Size = new System.Drawing.Size(457, 180);
            this.gbFormaPgto.TabIndex = 0;
            this.gbFormaPgto.TabStop = false;
            this.gbFormaPgto.Text = "Forma de Pagamento";
            // 
            // gridFormaPgto
            // 
            this.gridFormaPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormaPgto.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridFormaPgto.Location = new System.Drawing.Point(3, 16);
            this.gridFormaPgto.Name = "gridFormaPgto";
            this.gridFormaPgto.Size = new System.Drawing.Size(451, 125);
            this.gridFormaPgto.TabIndex = 6;
            // 
            // btnFormaPgto
            // 
            this.btnFormaPgto.Location = new System.Drawing.Point(374, 147);
            this.btnFormaPgto.Name = "btnFormaPgto";
            this.btnFormaPgto.Size = new System.Drawing.Size(75, 23);
            this.btnFormaPgto.TabIndex = 5;
            this.btnFormaPgto.Text = "Forma Pgto";
            this.btnFormaPgto.UseVisualStyleBackColor = true;
            this.btnFormaPgto.Click += new System.EventHandler(this.btnFormaPgto_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.gbVendedor);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 72);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(457, 72);
            this.panel7.TabIndex = 4;
            // 
            // gbVendedor
            // 
            this.gbVendedor.Controls.Add(this.lblVendedorNome);
            this.gbVendedor.Controls.Add(this.label10);
            this.gbVendedor.Controls.Add(this.btnVendedor);
            this.gbVendedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVendedor.Location = new System.Drawing.Point(0, 0);
            this.gbVendedor.Name = "gbVendedor";
            this.gbVendedor.Size = new System.Drawing.Size(457, 72);
            this.gbVendedor.TabIndex = 0;
            this.gbVendedor.TabStop = false;
            this.gbVendedor.Text = "Vendedor";
            // 
            // lblVendedorNome
            // 
            this.lblVendedorNome.Location = new System.Drawing.Point(9, 34);
            this.lblVendedorNome.Name = "lblVendedorNome";
            this.lblVendedorNome.Size = new System.Drawing.Size(200, 13);
            this.lblVendedorNome.TabIndex = 14;
            this.lblVendedorNome.Text = "-";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Nome";
            // 
            // btnVendedor
            // 
            this.btnVendedor.Location = new System.Drawing.Point(374, 29);
            this.btnVendedor.Name = "btnVendedor";
            this.btnVendedor.Size = new System.Drawing.Size(75, 23);
            this.btnVendedor.TabIndex = 4;
            this.btnVendedor.Text = "Vendedor";
            this.btnVendedor.UseVisualStyleBackColor = true;
            this.btnVendedor.Click += new System.EventHandler(this.btnVendedor_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.gbCliente);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(457, 72);
            this.panel6.TabIndex = 3;
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnClienteCPF);
            this.gbCliente.Controls.Add(this.lblClienteNome);
            this.gbCliente.Controls.Add(this.lblClienteCpfCnpj);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnClienteCNPJ);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbCliente.Location = new System.Drawing.Point(0, 0);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(457, 72);
            this.gbCliente.TabIndex = 4;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.Location = new System.Drawing.Point(9, 34);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(200, 13);
            this.lblClienteNome.TabIndex = 12;
            this.lblClienteNome.Text = "-";
            // 
            // lblClienteCpfCnpj
            // 
            this.lblClienteCpfCnpj.Location = new System.Drawing.Point(215, 34);
            this.lblClienteCpfCnpj.Name = "lblClienteCpfCnpj";
            this.lblClienteCpfCnpj.Size = new System.Drawing.Size(141, 13);
            this.lblClienteCpfCnpj.TabIndex = 11;
            this.lblClienteCpfCnpj.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cpf / Cnpj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome";
            // 
            // btnClienteCNPJ
            // 
            this.btnClienteCNPJ.Location = new System.Drawing.Point(369, 43);
            this.btnClienteCNPJ.Name = "btnClienteCNPJ";
            this.btnClienteCNPJ.Size = new System.Drawing.Size(80, 23);
            this.btnClienteCNPJ.TabIndex = 6;
            this.btnClienteCNPJ.Text = "Cliente CNPJ";
            this.btnClienteCNPJ.UseVisualStyleBackColor = true;
            this.btnClienteCNPJ.Click += new System.EventHandler(this.btnClienteCNPJ_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbProdutos);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(457, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 492);
            this.panel1.TabIndex = 1;
            // 
            // gbProdutos
            // 
            this.gbProdutos.Controls.Add(this.GridProdutos);
            this.gbProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbProdutos.Location = new System.Drawing.Point(0, 0);
            this.gbProdutos.Name = "gbProdutos";
            this.gbProdutos.Size = new System.Drawing.Size(778, 492);
            this.gbProdutos.TabIndex = 0;
            this.gbProdutos.TabStop = false;
            this.gbProdutos.Text = "Produtos";
            // 
            // GridProdutos
            // 
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(3, 16);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(772, 473);
            this.GridProdutos.TabIndex = 1;
            // 
            // btnLocalizarCarrinho
            // 
            this.btnLocalizarCarrinho.Enabled = false;
            this.btnLocalizarCarrinho.Location = new System.Drawing.Point(255, 6);
            this.btnLocalizarCarrinho.Name = "btnLocalizarCarrinho";
            this.btnLocalizarCarrinho.Size = new System.Drawing.Size(75, 82);
            this.btnLocalizarCarrinho.TabIndex = 5;
            this.btnLocalizarCarrinho.Text = "Localizar";
            this.btnLocalizarCarrinho.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(174, 6);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 82);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Location = new System.Drawing.Point(93, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 82);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Rodape
            // 
            this.Rodape.Controls.Add(this.btnLocalizarCarrinho);
            this.Rodape.Controls.Add(this.btnGravar);
            this.Rodape.Controls.Add(this.btnCancelar);
            this.Rodape.Controls.Add(this.btnNovoCarrinho);
            this.Rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rodape.Location = new System.Drawing.Point(0, 544);
            this.Rodape.Name = "Rodape";
            this.Rodape.Size = new System.Drawing.Size(1235, 100);
            this.Rodape.TabIndex = 4;
            // 
            // btnNovoCarrinho
            // 
            this.btnNovoCarrinho.Location = new System.Drawing.Point(12, 6);
            this.btnNovoCarrinho.Name = "btnNovoCarrinho";
            this.btnNovoCarrinho.Size = new System.Drawing.Size(75, 82);
            this.btnNovoCarrinho.TabIndex = 2;
            this.btnNovoCarrinho.Text = "Novo";
            this.btnNovoCarrinho.UseVisualStyleBackColor = true;
            this.btnNovoCarrinho.Click += new System.EventHandler(this.btnNovoCarrinho_Click);
            // 
            // txtIdCarrinho
            // 
            this.txtIdCarrinho.Enabled = false;
            this.txtIdCarrinho.Location = new System.Drawing.Point(12, 24);
            this.txtIdCarrinho.Name = "txtIdCarrinho";
            this.txtIdCarrinho.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarrinho.TabIndex = 8;
            this.txtIdCarrinho.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Carrinho";
            // 
            // txtDataCarrinho
            // 
            this.txtDataCarrinho.Enabled = false;
            this.txtDataCarrinho.Location = new System.Drawing.Point(118, 24);
            this.txtDataCarrinho.Name = "txtDataCarrinho";
            this.txtDataCarrinho.Size = new System.Drawing.Size(120, 20);
            this.txtDataCarrinho.TabIndex = 10;
            this.txtDataCarrinho.Text = "00/00/0000 00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data";
            // 
            // Cabecalho
            // 
            this.Cabecalho.Controls.Add(this.txtDataCarrinho);
            this.Cabecalho.Controls.Add(this.label5);
            this.Cabecalho.Controls.Add(this.txtIdCarrinho);
            this.Cabecalho.Controls.Add(this.label4);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(1235, 52);
            this.Cabecalho.TabIndex = 3;
            // 
            // btnClienteCPF
            // 
            this.btnClienteCPF.Location = new System.Drawing.Point(369, 14);
            this.btnClienteCPF.Name = "btnClienteCPF";
            this.btnClienteCPF.Size = new System.Drawing.Size(80, 23);
            this.btnClienteCPF.TabIndex = 13;
            this.btnClienteCPF.Text = "Cliente CPF";
            this.btnClienteCPF.UseVisualStyleBackColor = true;
            this.btnClienteCPF.Click += new System.EventHandler(this.btnClienteCPF_Click);
            // 
            // CadastroCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 644);
            this.Controls.Add(this.Corpo);
            this.Controls.Add(this.Rodape);
            this.Controls.Add(this.Cabecalho);
            this.Name = "CadastroCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCarrinho";
            this.Corpo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.gbFormaPgto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).EndInit();
            this.panel7.ResumeLayout(false);
            this.gbVendedor.ResumeLayout(false);
            this.gbVendedor.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbProdutos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.Rodape.ResumeLayout(false);
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel Corpo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLocalizarCarrinho;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel Rodape;
        private System.Windows.Forms.Button btnNovoCarrinho;
        private System.Windows.Forms.TextBox txtIdCarrinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnClienteCNPJ;
        private System.Windows.Forms.GroupBox gbProdutos;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClienteCpfCnpj;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.GroupBox gbVendedor;
        private System.Windows.Forms.Label lblVendedorNome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVendedor;
        private System.Windows.Forms.GroupBox gbFormaPgto;
        private System.Windows.Forms.DataGridView gridFormaPgto;
        private System.Windows.Forms.Button btnFormaPgto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Button btnClienteCPF;
    }
}