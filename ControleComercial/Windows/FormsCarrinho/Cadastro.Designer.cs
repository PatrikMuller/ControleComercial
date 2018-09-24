namespace Windows.FormsCarrinho
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
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.gbCarrinho = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOperador = new System.Windows.Forms.TextBox();
            this.txtDataCarrinho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdCarrinho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Rodape = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnNovoCarrinho = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbFormaPgto = new System.Windows.Forms.GroupBox();
            this.gridFormaPgto = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFormaPgto = new System.Windows.Forms.Button();
            this.gbLocalizarProduto = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.btnClienteCPF = new System.Windows.Forms.Button();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.lblClienteCpfCnpj = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClienteCNPJ = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbListaProduto = new System.Windows.Forms.GroupBox();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.Cabecalho.SuspendLayout();
            this.gbCarrinho.SuspendLayout();
            this.Rodape.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbFormaPgto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).BeginInit();
            this.panel2.SuspendLayout();
            this.gbLocalizarProduto.SuspendLayout();
            this.gbCliente.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbListaProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // Cabecalho
            // 
            this.Cabecalho.Controls.Add(this.gbCarrinho);
            this.Cabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.Cabecalho.Location = new System.Drawing.Point(0, 0);
            this.Cabecalho.Name = "Cabecalho";
            this.Cabecalho.Size = new System.Drawing.Size(1284, 80);
            this.Cabecalho.TabIndex = 4;
            // 
            // gbCarrinho
            // 
            this.gbCarrinho.Controls.Add(this.label7);
            this.gbCarrinho.Controls.Add(this.txtOperador);
            this.gbCarrinho.Controls.Add(this.txtDataCarrinho);
            this.gbCarrinho.Controls.Add(this.label5);
            this.gbCarrinho.Controls.Add(this.txtIdCarrinho);
            this.gbCarrinho.Controls.Add(this.label4);
            this.gbCarrinho.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCarrinho.Location = new System.Drawing.Point(0, 0);
            this.gbCarrinho.Name = "gbCarrinho";
            this.gbCarrinho.Size = new System.Drawing.Size(1284, 80);
            this.gbCarrinho.TabIndex = 13;
            this.gbCarrinho.TabStop = false;
            this.gbCarrinho.Text = "Carrinho";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Operador";
            // 
            // txtOperador
            // 
            this.txtOperador.Enabled = false;
            this.txtOperador.Location = new System.Drawing.Point(244, 33);
            this.txtOperador.Name = "txtOperador";
            this.txtOperador.Size = new System.Drawing.Size(120, 20);
            this.txtOperador.TabIndex = 17;
            this.txtOperador.Text = "operador";
            // 
            // txtDataCarrinho
            // 
            this.txtDataCarrinho.Enabled = false;
            this.txtDataCarrinho.Location = new System.Drawing.Point(118, 33);
            this.txtDataCarrinho.Name = "txtDataCarrinho";
            this.txtDataCarrinho.Size = new System.Drawing.Size(120, 20);
            this.txtDataCarrinho.TabIndex = 16;
            this.txtDataCarrinho.Text = "00/00/0000 00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Abertura";
            // 
            // txtIdCarrinho
            // 
            this.txtIdCarrinho.Enabled = false;
            this.txtIdCarrinho.Location = new System.Drawing.Point(12, 33);
            this.txtIdCarrinho.Name = "txtIdCarrinho";
            this.txtIdCarrinho.Size = new System.Drawing.Size(100, 20);
            this.txtIdCarrinho.TabIndex = 14;
            this.txtIdCarrinho.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Id";
            // 
            // Rodape
            // 
            this.Rodape.Controls.Add(this.label10);
            this.Rodape.Controls.Add(this.lblTotal);
            this.Rodape.Controls.Add(this.btnGravar);
            this.Rodape.Controls.Add(this.btnCancelar);
            this.Rodape.Controls.Add(this.btnNovoCarrinho);
            this.Rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rodape.Location = new System.Drawing.Point(0, 541);
            this.Rodape.Name = "Rodape";
            this.Rodape.Size = new System.Drawing.Size(1284, 100);
            this.Rodape.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(982, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 25);
            this.label10.TabIndex = 6;
            this.label10.Text = "Total:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(1060, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 25);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "R$ 000.000.000,00";
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(93, 6);
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
            this.btnCancelar.Location = new System.Drawing.Point(174, 6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 82);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.gbFormaPgto);
            this.panel1.Controls.Add(this.gbLocalizarProduto);
            this.panel1.Controls.Add(this.gbCliente);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 461);
            this.panel1.TabIndex = 6;
            // 
            // gbFormaPgto
            // 
            this.gbFormaPgto.Controls.Add(this.gridFormaPgto);
            this.gbFormaPgto.Controls.Add(this.panel2);
            this.gbFormaPgto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFormaPgto.Location = new System.Drawing.Point(0, 80);
            this.gbFormaPgto.Name = "gbFormaPgto";
            this.gbFormaPgto.Size = new System.Drawing.Size(460, 301);
            this.gbFormaPgto.TabIndex = 3;
            this.gbFormaPgto.TabStop = false;
            this.gbFormaPgto.Text = "Forma de Pagamento";
            // 
            // gridFormaPgto
            // 
            this.gridFormaPgto.BackgroundColor = System.Drawing.SystemColors.Window;
            this.gridFormaPgto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gridFormaPgto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFormaPgto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFormaPgto.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.gridFormaPgto.Location = new System.Drawing.Point(3, 16);
            this.gridFormaPgto.Name = "gridFormaPgto";
            this.gridFormaPgto.Size = new System.Drawing.Size(454, 242);
            this.gridFormaPgto.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFormaPgto);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 40);
            this.panel2.TabIndex = 7;
            // 
            // btnFormaPgto
            // 
            this.btnFormaPgto.Location = new System.Drawing.Point(366, 3);
            this.btnFormaPgto.Name = "btnFormaPgto";
            this.btnFormaPgto.Size = new System.Drawing.Size(80, 23);
            this.btnFormaPgto.TabIndex = 5;
            this.btnFormaPgto.Text = "Forma Pgto";
            this.btnFormaPgto.UseVisualStyleBackColor = true;
            this.btnFormaPgto.Click += new System.EventHandler(this.btnFormaPgto_Click);
            // 
            // gbLocalizarProduto
            // 
            this.gbLocalizarProduto.Controls.Add(this.txtQuantidade);
            this.gbLocalizarProduto.Controls.Add(this.label3);
            this.gbLocalizarProduto.Controls.Add(this.textBox1);
            this.gbLocalizarProduto.Controls.Add(this.label2);
            this.gbLocalizarProduto.Controls.Add(this.btnLocalizar);
            this.gbLocalizarProduto.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbLocalizarProduto.Location = new System.Drawing.Point(0, 381);
            this.gbLocalizarProduto.Name = "gbLocalizarProduto";
            this.gbLocalizarProduto.Size = new System.Drawing.Size(460, 80);
            this.gbLocalizarProduto.TabIndex = 2;
            this.gbLocalizarProduto.TabStop = false;
            this.gbLocalizarProduto.Text = "Localizar";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtQuantidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQuantidade.Location = new System.Drawing.Point(12, 37);
            this.txtQuantidade.MaxLength = 18;
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.ReadOnly = true;
            this.txtQuantidade.Size = new System.Drawing.Size(140, 20);
            this.txtQuantidade.TabIndex = 65;
            this.txtQuantidade.Text = "0,000";
            this.txtQuantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "Quantidade";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(158, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 62;
            this.label2.Text = "Produto";
            // 
            // btnLocalizar
            // 
            this.btnLocalizar.Location = new System.Drawing.Point(369, 35);
            this.btnLocalizar.Name = "btnLocalizar";
            this.btnLocalizar.Size = new System.Drawing.Size(80, 23);
            this.btnLocalizar.TabIndex = 61;
            this.btnLocalizar.Text = "Localizar";
            this.btnLocalizar.UseVisualStyleBackColor = true;
            this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
            // 
            // gbCliente
            // 
            this.gbCliente.Controls.Add(this.btnClienteCPF);
            this.gbCliente.Controls.Add(this.lblClienteNome);
            this.gbCliente.Controls.Add(this.lblClienteCpfCnpj);
            this.gbCliente.Controls.Add(this.label6);
            this.gbCliente.Controls.Add(this.label1);
            this.gbCliente.Controls.Add(this.btnClienteCNPJ);
            this.gbCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbCliente.Location = new System.Drawing.Point(0, 0);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(460, 80);
            this.gbCliente.TabIndex = 0;
            this.gbCliente.TabStop = false;
            this.gbCliente.Text = "Cliente";
            // 
            // btnClienteCPF
            // 
            this.btnClienteCPF.Location = new System.Drawing.Point(369, 16);
            this.btnClienteCPF.Name = "btnClienteCPF";
            this.btnClienteCPF.Size = new System.Drawing.Size(80, 23);
            this.btnClienteCPF.TabIndex = 19;
            this.btnClienteCPF.Text = "Cliente CPF";
            this.btnClienteCPF.UseVisualStyleBackColor = true;
            this.btnClienteCPF.Click += new System.EventHandler(this.btnClienteCPF_Click);
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.Location = new System.Drawing.Point(9, 36);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(200, 13);
            this.lblClienteNome.TabIndex = 18;
            this.lblClienteNome.Text = "0000000000000000";
            // 
            // lblClienteCpfCnpj
            // 
            this.lblClienteCpfCnpj.Location = new System.Drawing.Point(215, 36);
            this.lblClienteCpfCnpj.Name = "lblClienteCpfCnpj";
            this.lblClienteCpfCnpj.Size = new System.Drawing.Size(141, 13);
            this.lblClienteCpfCnpj.TabIndex = 17;
            this.lblClienteCpfCnpj.Text = "0000000000000000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Cpf / Cnpj";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome";
            // 
            // btnClienteCNPJ
            // 
            this.btnClienteCNPJ.Location = new System.Drawing.Point(369, 45);
            this.btnClienteCNPJ.Name = "btnClienteCNPJ";
            this.btnClienteCNPJ.Size = new System.Drawing.Size(80, 23);
            this.btnClienteCNPJ.TabIndex = 14;
            this.btnClienteCNPJ.Text = "Cliente CNPJ";
            this.btnClienteCNPJ.UseVisualStyleBackColor = true;
            this.btnClienteCNPJ.Click += new System.EventHandler(this.btnClienteCNPJ_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gbListaProduto);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(460, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(824, 461);
            this.panel3.TabIndex = 7;
            // 
            // gbListaProduto
            // 
            this.gbListaProduto.Controls.Add(this.GridProdutos);
            this.gbListaProduto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListaProduto.Location = new System.Drawing.Point(0, 0);
            this.gbListaProduto.Name = "gbListaProduto";
            this.gbListaProduto.Size = new System.Drawing.Size(824, 461);
            this.gbListaProduto.TabIndex = 8;
            this.gbListaProduto.TabStop = false;
            this.gbListaProduto.Text = "Produtos";
            // 
            // GridProdutos
            // 
            this.GridProdutos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(3, 16);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridProdutos.Size = new System.Drawing.Size(818, 442);
            this.GridProdutos.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 641);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Rodape);
            this.Controls.Add(this.Cabecalho);
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Cabecalho.ResumeLayout(false);
            this.gbCarrinho.ResumeLayout(false);
            this.gbCarrinho.PerformLayout();
            this.Rodape.ResumeLayout(false);
            this.Rodape.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbFormaPgto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFormaPgto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gbLocalizarProduto.ResumeLayout(false);
            this.gbLocalizarProduto.PerformLayout();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.gbListaProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Panel Rodape;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnNovoCarrinho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCarrinho;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOperador;
        private System.Windows.Forms.TextBox txtDataCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdCarrinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button btnClienteCPF;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.Label lblClienteCpfCnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClienteCNPJ;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox gbListaProduto;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.GroupBox gbLocalizarProduto;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.GroupBox gbFormaPgto;
        private System.Windows.Forms.DataGridView gridFormaPgto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFormaPgto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
    }
}