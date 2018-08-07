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
            this.label1 = new System.Windows.Forms.Label();
            this.GridProdutos = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLocalizar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Corpo = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Rodape = new System.Windows.Forms.Panel();
            this.btnNovoCarrinho = new System.Windows.Forms.Button();
            this.txtIdCarrinho = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCarrinho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Cabecalho = new System.Windows.Forms.Panel();
            this.btnInserirCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.Corpo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.Rodape.SuspendLayout();
            this.Cabecalho.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Produtos";
            // 
            // GridProdutos
            // 
            this.GridProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProdutos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridProdutos.Location = new System.Drawing.Point(0, 0);
            this.GridProdutos.Name = "GridProdutos";
            this.GridProdutos.Size = new System.Drawing.Size(778, 434);
            this.GridProdutos.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.GridProdutos);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 434);
            this.panel3.TabIndex = 2;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(12, 25);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 6;
            this.txtQuantidade.Text = "1,000";
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
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 40);
            this.panel2.TabIndex = 1;
            // 
            // Corpo
            // 
            this.Corpo.Controls.Add(this.panel5);
            this.Corpo.Controls.Add(this.panel4);
            this.Corpo.Controls.Add(this.panel1);
            this.Corpo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Corpo.Location = new System.Drawing.Point(0, 64);
            this.Corpo.Name = "Corpo";
            this.Corpo.Size = new System.Drawing.Size(1272, 474);
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
            this.panel5.Size = new System.Drawing.Size(494, 102);
            this.panel5.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnInserirCliente);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(494, 372);
            this.panel4.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(494, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 474);
            this.panel1.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 82);
            this.button5.TabIndex = 5;
            this.button5.Text = "Localizar";
            this.button5.UseVisualStyleBackColor = true;
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(93, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 82);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Rodape
            // 
            this.Rodape.Controls.Add(this.button5);
            this.Rodape.Controls.Add(this.btnGravar);
            this.Rodape.Controls.Add(this.button3);
            this.Rodape.Controls.Add(this.btnNovoCarrinho);
            this.Rodape.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Rodape.Location = new System.Drawing.Point(0, 538);
            this.Rodape.Name = "Rodape";
            this.Rodape.Size = new System.Drawing.Size(1272, 100);
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
            this.Cabecalho.Size = new System.Drawing.Size(1272, 64);
            this.Cabecalho.TabIndex = 3;
            // 
            // btnInserirCliente
            // 
            this.btnInserirCliente.Location = new System.Drawing.Point(194, 78);
            this.btnInserirCliente.Name = "btnInserirCliente";
            this.btnInserirCliente.Size = new System.Drawing.Size(75, 23);
            this.btnInserirCliente.TabIndex = 2;
            this.btnInserirCliente.Text = "Cliente";
            this.btnInserirCliente.UseVisualStyleBackColor = true;
            this.btnInserirCliente.Click += new System.EventHandler(this.btnInserirCliente_Click);
            // 
            // CadastroCarrinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 638);
            this.Controls.Add(this.Corpo);
            this.Controls.Add(this.Rodape);
            this.Controls.Add(this.Cabecalho);
            this.Name = "CadastroCarrinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroCarrinho";
            ((System.ComponentModel.ISupportInitialize)(this.GridProdutos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Corpo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.Rodape.ResumeLayout(false);
            this.Cabecalho.ResumeLayout(false);
            this.Cabecalho.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridProdutos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel Corpo;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel Rodape;
        private System.Windows.Forms.Button btnNovoCarrinho;
        private System.Windows.Forms.TextBox txtIdCarrinho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDataCarrinho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel Cabecalho;
        private System.Windows.Forms.Button btnInserirCliente;
    }
}