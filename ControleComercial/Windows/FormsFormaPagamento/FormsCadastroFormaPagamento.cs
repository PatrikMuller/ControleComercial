using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Infraestrutura.Access;
using Infraestrutura.Models;

namespace Windows.FormsFormaPagamento
{
    public partial class FormsCadastroFormaPagamento : Form
    {

        //Objetos
        FormaPagamento obj = new FormaPagamento();

        //Access
        FormaPagamentoAccess formaPagamentoAccess = new FormaPagamentoAccess();
        FormaPagamentoParcelamentoAccess formaPagamentoParcelamentoAccess = new FormaPagamentoParcelamentoAccess();


        //Início - Métodos locais
        private void Ler(Int32 Id)
        {

            obj = formaPagamentoAccess.Ler(Id);

            txtId.Text = Convert.ToString(obj.Id);
            txtDescricao.Text = obj.Descricao;

            Grid.DataSource = formaPagamentoParcelamentoAccess.Lista(obj.Id);

            //AtivaComponentes();
        }

        private void DesativaComponentes()
        {

            //txtDescricao.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtDescricao.Enabled = true;
            btnGravar.Enabled = true;

        }
                
        //Fim - Métodos locais



        public FormsCadastroFormaPagamento(Int32 Id)
        {

            InitializeComponent();

            Ler(Id);            

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuButtonNovo_Click(object sender, EventArgs e)
        {
            FormsFormaPagamentoParcelamento.Cadastro form = new FormsFormaPagamentoParcelamento.Cadastro();
            form.ShowDialog();
        }

        private void MenuButtonEditar_Click(object sender, EventArgs e)
        {
            FormsFormaPagamentoParcelamento.Cadastro form = new FormsFormaPagamentoParcelamento.Cadastro();
            form.ShowDialog();
        }

        private void MenuButtonCancelar_Click(object sender, EventArgs e)
        {
            //
        }

    }
}
