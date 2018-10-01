namespace Windows.FormsPessoaJuridica
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
            this.lblValidaCnpj = new System.Windows.Forms.Label();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.btnValidar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIe = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tcDados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtDataConstituicao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tcDados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGravar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 36);
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
            this.groupBox1.Controls.Add(this.lblValidaCnpj);
            this.groupBox1.Controls.Add(this.txtRazaoSocial);
            this.groupBox1.Controls.Add(this.txtCnpj);
            this.groupBox1.Controls.Add(this.btnValidar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIe);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtFantasia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(684, 157);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Dados Principais ";
            // 
            // lblValidaCnpj
            // 
            this.lblValidaCnpj.AutoSize = true;
            this.lblValidaCnpj.Location = new System.Drawing.Point(323, 106);
            this.lblValidaCnpj.Name = "lblValidaCnpj";
            this.lblValidaCnpj.Size = new System.Drawing.Size(10, 13);
            this.lblValidaCnpj.TabIndex = 40;
            this.lblValidaCnpj.Text = "-";
            this.lblValidaCnpj.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRazaoSocial.Location = new System.Drawing.Point(96, 49);
            this.txtRazaoSocial.MaxLength = 200;
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(400, 20);
            this.txtRazaoSocial.TabIndex = 3;
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(96, 101);
            this.txtCnpj.Mask = "00.000.000-0000/00";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(140, 20);
            this.txtCnpj.TabIndex = 1;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(242, 99);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(75, 23);
            this.btnValidar.TabIndex = 2;
            this.btnValidar.Text = "Validar";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Identificador";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(96, 23);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 0;
            this.txtId.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "IE";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtIe
            // 
            this.txtIe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIe.Location = new System.Drawing.Point(96, 126);
            this.txtIe.MaxLength = 200;
            this.txtIe.Name = "txtIe";
            this.txtIe.Size = new System.Drawing.Size(140, 20);
            this.txtIe.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "CNPJ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fantasia";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtFantasia
            // 
            this.txtFantasia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFantasia.Location = new System.Drawing.Point(96, 75);
            this.txtFantasia.MaxLength = 200;
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(400, 20);
            this.txtFantasia.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Razão Social";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tcDados
            // 
            this.tcDados.Controls.Add(this.tabPage1);
            this.tcDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcDados.Location = new System.Drawing.Point(0, 157);
            this.tcDados.Name = "tcDados";
            this.tcDados.SelectedIndex = 0;
            this.tcDados.Size = new System.Drawing.Size(684, 218);
            this.tcDados.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtDataConstituicao);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 192);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Dados da Empresa";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dtDataConstituicao
            // 
            this.dtDataConstituicao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataConstituicao.Location = new System.Drawing.Point(103, 16);
            this.dtDataConstituicao.Name = "dtDataConstituicao";
            this.dtDataConstituicao.Size = new System.Drawing.Size(100, 20);
            this.dtDataConstituicao.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Data Constituição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.tcDados);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tcDados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblValidaCnpj;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcDados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DateTimePicker dtDataConstituicao;
        private System.Windows.Forms.Label label6;
    }
}