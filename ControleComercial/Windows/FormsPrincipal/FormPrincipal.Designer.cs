namespace Windows.FormsPrincipal
{
    partial class FormPrincipal
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
            this.pnTopo = new System.Windows.Forms.Panel();
            this.pnConteudo = new System.Windows.Forms.Panel();
            this.btnEspecificacaoTipo = new System.Windows.Forms.Button();
            this.btnEspecificacao = new System.Windows.Forms.Button();
            this.btnClasse = new System.Windows.Forms.Button();
            this.lblTabelas = new System.Windows.Forms.Label();
            this.btnGerarTabelas = new System.Windows.Forms.Button();
            this.btnUnidadeMedida = new System.Windows.Forms.Button();
            this.btnFabricante = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnFormaPagamento = new System.Windows.Forms.Button();
            this.btnTelaVenda = new System.Windows.Forms.Button();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.pnBaixo = new System.Windows.Forms.Panel();
            this.pnConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTopo
            // 
            this.pnTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTopo.Location = new System.Drawing.Point(0, 0);
            this.pnTopo.Name = "pnTopo";
            this.pnTopo.Size = new System.Drawing.Size(989, 100);
            this.pnTopo.TabIndex = 0;
            // 
            // pnConteudo
            // 
            this.pnConteudo.Controls.Add(this.btnEspecificacaoTipo);
            this.pnConteudo.Controls.Add(this.btnEspecificacao);
            this.pnConteudo.Controls.Add(this.btnClasse);
            this.pnConteudo.Controls.Add(this.lblTabelas);
            this.pnConteudo.Controls.Add(this.btnGerarTabelas);
            this.pnConteudo.Controls.Add(this.btnUnidadeMedida);
            this.pnConteudo.Controls.Add(this.btnFabricante);
            this.pnConteudo.Controls.Add(this.button3);
            this.pnConteudo.Controls.Add(this.btnProduto);
            this.pnConteudo.Controls.Add(this.btnFormaPagamento);
            this.pnConteudo.Controls.Add(this.btnTelaVenda);
            this.pnConteudo.Controls.Add(this.btnPessoaJuridica);
            this.pnConteudo.Controls.Add(this.btnPessoaFisica);
            this.pnConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnConteudo.Location = new System.Drawing.Point(0, 100);
            this.pnConteudo.Name = "pnConteudo";
            this.pnConteudo.Size = new System.Drawing.Size(989, 511);
            this.pnConteudo.TabIndex = 1;
            // 
            // btnEspecificacaoTipo
            // 
            this.btnEspecificacaoTipo.Location = new System.Drawing.Point(436, 118);
            this.btnEspecificacaoTipo.Name = "btnEspecificacaoTipo";
            this.btnEspecificacaoTipo.Size = new System.Drawing.Size(100, 50);
            this.btnEspecificacaoTipo.TabIndex = 14;
            this.btnEspecificacaoTipo.Text = "Especificação Tipo";
            this.btnEspecificacaoTipo.UseVisualStyleBackColor = true;
            this.btnEspecificacaoTipo.Click += new System.EventHandler(this.btnEspecificacaoTipo_Click);
            // 
            // btnEspecificacao
            // 
            this.btnEspecificacao.Location = new System.Drawing.Point(330, 118);
            this.btnEspecificacao.Name = "btnEspecificacao";
            this.btnEspecificacao.Size = new System.Drawing.Size(100, 50);
            this.btnEspecificacao.TabIndex = 13;
            this.btnEspecificacao.Text = "Especificação";
            this.btnEspecificacao.UseVisualStyleBackColor = true;
            this.btnEspecificacao.Click += new System.EventHandler(this.btnEspecificacao_Click);
            // 
            // btnClasse
            // 
            this.btnClasse.Location = new System.Drawing.Point(224, 118);
            this.btnClasse.Name = "btnClasse";
            this.btnClasse.Size = new System.Drawing.Size(100, 50);
            this.btnClasse.TabIndex = 12;
            this.btnClasse.Text = "Classe";
            this.btnClasse.UseVisualStyleBackColor = true;
            this.btnClasse.Click += new System.EventHandler(this.btnClasse_Click);
            // 
            // lblTabelas
            // 
            this.lblTabelas.AutoSize = true;
            this.lblTabelas.Location = new System.Drawing.Point(115, 227);
            this.lblTabelas.Name = "lblTabelas";
            this.lblTabelas.Size = new System.Drawing.Size(11, 13);
            this.lblTabelas.TabIndex = 11;
            this.lblTabelas.Text = "*";
            // 
            // btnGerarTabelas
            // 
            this.btnGerarTabelas.Location = new System.Drawing.Point(118, 174);
            this.btnGerarTabelas.Name = "btnGerarTabelas";
            this.btnGerarTabelas.Size = new System.Drawing.Size(100, 50);
            this.btnGerarTabelas.TabIndex = 10;
            this.btnGerarTabelas.Text = "Gerar Tabelas";
            this.btnGerarTabelas.UseVisualStyleBackColor = true;
            this.btnGerarTabelas.Click += new System.EventHandler(this.btnGerarTabelas_Click);
            // 
            // btnUnidadeMedida
            // 
            this.btnUnidadeMedida.Location = new System.Drawing.Point(118, 118);
            this.btnUnidadeMedida.Name = "btnUnidadeMedida";
            this.btnUnidadeMedida.Size = new System.Drawing.Size(100, 50);
            this.btnUnidadeMedida.TabIndex = 9;
            this.btnUnidadeMedida.Text = "Unidade de Medida";
            this.btnUnidadeMedida.UseVisualStyleBackColor = true;
            this.btnUnidadeMedida.Click += new System.EventHandler(this.btnUnidadeMedida_Click);
            // 
            // btnFabricante
            // 
            this.btnFabricante.Location = new System.Drawing.Point(12, 118);
            this.btnFabricante.Name = "btnFabricante";
            this.btnFabricante.Size = new System.Drawing.Size(100, 50);
            this.btnFabricante.TabIndex = 8;
            this.btnFabricante.Text = "Fabricante";
            this.btnFabricante.UseVisualStyleBackColor = true;
            this.btnFabricante.Click += new System.EventHandler(this.btnFabricante_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Controle de Acesso";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Location = new System.Drawing.Point(12, 62);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(100, 50);
            this.btnProduto.TabIndex = 5;
            this.btnProduto.Text = "Produtos";
            this.btnProduto.UseVisualStyleBackColor = true;
            this.btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFormaPagamento
            // 
            this.btnFormaPagamento.Location = new System.Drawing.Point(12, 174);
            this.btnFormaPagamento.Name = "btnFormaPagamento";
            this.btnFormaPagamento.Size = new System.Drawing.Size(100, 50);
            this.btnFormaPagamento.TabIndex = 3;
            this.btnFormaPagamento.Text = "Forma Pagamento";
            this.btnFormaPagamento.UseVisualStyleBackColor = true;
            this.btnFormaPagamento.Click += new System.EventHandler(this.btnFormaPagamento_Click);
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.Location = new System.Drawing.Point(224, 174);
            this.btnTelaVenda.Name = "btnTelaVenda";
            this.btnTelaVenda.Size = new System.Drawing.Size(100, 50);
            this.btnTelaVenda.TabIndex = 2;
            this.btnTelaVenda.Text = "Tela de Venda";
            this.btnTelaVenda.UseVisualStyleBackColor = true;
            this.btnTelaVenda.Click += new System.EventHandler(this.btnTelaVenda_Click);
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Location = new System.Drawing.Point(118, 6);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(100, 50);
            this.btnPessoaJuridica.TabIndex = 1;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Click += new System.EventHandler(this.btnPessoaJuridica_Click);
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Location = new System.Drawing.Point(12, 6);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(100, 50);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // pnBaixo
            // 
            this.pnBaixo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBaixo.Location = new System.Drawing.Point(0, 511);
            this.pnBaixo.Name = "pnBaixo";
            this.pnBaixo.Size = new System.Drawing.Size(989, 100);
            this.pnBaixo.TabIndex = 2;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 611);
            this.Controls.Add(this.pnBaixo);
            this.Controls.Add(this.pnConteudo);
            this.Controls.Add(this.pnTopo);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnConteudo.ResumeLayout(false);
            this.pnConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Panel pnConteudo;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnTelaVenda;
        private System.Windows.Forms.Button btnFormaPagamento;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnFabricante;
        private System.Windows.Forms.Button btnUnidadeMedida;
        private System.Windows.Forms.Button btnGerarTabelas;
        private System.Windows.Forms.Label lblTabelas;
        private System.Windows.Forms.Button btnEspecificacaoTipo;
        private System.Windows.Forms.Button btnEspecificacao;
        private System.Windows.Forms.Button btnClasse;
    }
}