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
            this.pnConteudo.Controls.Add(this.btnTelaVenda);
            this.pnConteudo.Controls.Add(this.btnPessoaJuridica);
            this.pnConteudo.Controls.Add(this.btnPessoaFisica);
            this.pnConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnConteudo.Location = new System.Drawing.Point(0, 100);
            this.pnConteudo.Name = "pnConteudo";
            this.pnConteudo.Size = new System.Drawing.Size(989, 511);
            this.pnConteudo.TabIndex = 1;
            // 
            // btnTelaVenda
            // 
            this.btnTelaVenda.Location = new System.Drawing.Point(224, 6);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTopo;
        private System.Windows.Forms.Panel pnConteudo;
        private System.Windows.Forms.Panel pnBaixo;
        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnTelaVenda;
    }
}