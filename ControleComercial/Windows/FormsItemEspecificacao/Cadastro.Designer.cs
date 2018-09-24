namespace Windows.FormsItemEspecificacao
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
            this.Classe = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbEspecificacao = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.Classe.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInserir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(384, 36);
            this.panel1.TabIndex = 12;
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
            // 
            // Classe
            // 
            this.Classe.Controls.Add(this.label1);
            this.Classe.Controls.Add(this.cbEspecificacao);
            this.Classe.Controls.Add(this.label6);
            this.Classe.Controls.Add(this.cbTipo);
            this.Classe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Classe.Location = new System.Drawing.Point(0, 0);
            this.Classe.Name = "Classe";
            this.Classe.Size = new System.Drawing.Size(384, 125);
            this.Classe.TabIndex = 13;
            this.Classe.TabStop = false;
            this.Classe.Text = "Especificação do Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Tipo";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbTipo
            // 
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(88, 19);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(200, 21);
            this.cbTipo.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 71;
            this.label1.Text = "Especificação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cbEspecificacao
            // 
            this.cbEspecificacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEspecificacao.FormattingEnabled = true;
            this.cbEspecificacao.Location = new System.Drawing.Point(88, 46);
            this.cbEspecificacao.Name = "cbEspecificacao";
            this.cbEspecificacao.Size = new System.Drawing.Size(200, 21);
            this.cbEspecificacao.TabIndex = 70;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.Classe);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.panel1.ResumeLayout(false);
            this.Classe.ResumeLayout(false);
            this.Classe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.GroupBox Classe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbEspecificacao;
    }
}