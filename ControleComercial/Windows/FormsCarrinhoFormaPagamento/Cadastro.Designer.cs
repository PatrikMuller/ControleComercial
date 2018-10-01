namespace Windows.FormsCarrinhoFormaPagamento
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
            this.btnInserir = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbParcelas = new System.Windows.Forms.ComboBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 36);
            this.panel1.TabIndex = 14;
            // 
            // btnInserir
            // 
            this.btnInserir.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnInserir.Location = new System.Drawing.Point(12, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 12;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtValorPagar);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.txtValorParcela);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbParcelas);
            this.groupBox1.Controls.Add(this.cbFormaPagamento);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 205);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Forma de Pagamento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "Valor a Pagar";
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.BackColor = System.Drawing.SystemColors.Window;
            this.txtValorPagar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtValorPagar.Location = new System.Drawing.Point(135, 53);
            this.txtValorPagar.MaxLength = 18;
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.ReadOnly = true;
            this.txtValorPagar.Size = new System.Drawing.Size(160, 20);
            this.txtValorPagar.TabIndex = 59;
            this.txtValorPagar.Text = "0,00";
            this.txtValorPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorPagar_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTotal.Location = new System.Drawing.Point(135, 27);
            this.txtTotal.MaxLength = 18;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(160, 20);
            this.txtTotal.TabIndex = 57;
            this.txtTotal.Text = "0,00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Location = new System.Drawing.Point(135, 132);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ReadOnly = true;
            this.txtValorParcela.Size = new System.Drawing.Size(200, 20);
            this.txtValorParcela.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Valor da Parcela";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Valor Total";
            // 
            // cbParcelas
            // 
            this.cbParcelas.FormattingEnabled = true;
            this.cbParcelas.Location = new System.Drawing.Point(135, 105);
            this.cbParcelas.Name = "cbParcelas";
            this.cbParcelas.Size = new System.Drawing.Size(200, 21);
            this.cbParcelas.TabIndex = 52;
            this.cbParcelas.Leave += new System.EventHandler(this.cbParcelas_Leave);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Location = new System.Drawing.Point(135, 79);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(200, 21);
            this.cbFormaPagamento.TabIndex = 51;
            this.cbFormaPagamento.SelectionChangeCommitted += new System.EventHandler(this.cbFormaPagamento_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Quantidade de Parcelas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Forma de Pagamento";
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Activated += new System.EventHandler(this.Cadastro_Activated);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbParcelas;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}