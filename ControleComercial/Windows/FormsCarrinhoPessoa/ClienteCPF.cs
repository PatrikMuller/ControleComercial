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

namespace Windows.FormsCarrinhoPessoa
{
    public partial class ClienteCPF : Form
    {
        
        //Objetos
        Pessoa ObjPessoa = new Pessoa();
        Carrinho ObjCarrinho = new Carrinho();
        CarrinhoPessoa ObjCarrinhoPessoa = new CarrinhoPessoa();
        CarrinhoPessoaTipo ObjCarrinhoPessoaTipo = new CarrinhoPessoaTipo();

        //Access
        PessoaAccess pessoaAccess = new PessoaAccess();
        CarrinhoPessoaAccess carrinhoPessoaAccess = new CarrinhoPessoaAccess();

        //Apoio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


        //Início - Métodos locais
        private void Ler()
        {

            //CASO OBJETO ESTEJA null CRIA UMA NOVA ESTÂNCIA
            ObjPessoa = ObjPessoa ?? new Pessoa();

            //txtId.Text = Convert.ToString(ObjPessoa.Id);
            txtNome.Text = ObjPessoa.Nome;
            txtCpf.Text = ObjPessoa.CpfCnpj == null ? txtCpf.Text : ObjPessoa.CpfCnpj;

            //AtivaComponentes();
        }

        private String CpfValido()
        {

            lblValidaCpf.Text = "-";
            ObjPessoa = pessoaAccess.LerCpfCnpj(txtCpf.Text);

            Ler();

            AtivaComponentes();
            return "OK";

        }

        private String CpfInvalido()
        {

            return "Numero de CPF Inválido!";

        }

        private void Validar()
        {

            lblValidaCpf.Text = ObjUtilitario.validacpf(txtCpf.Text) == true ? CpfValido() : CpfInvalido();
            txtCpf.Focus().Equals(lblValidaCpf.Text != "OK");
            txtNome.Focus().Equals(lblValidaCpf.Text == "OK");

        }

        private void AtivaComponentes()
        {
            txtNome.Enabled = true;
            btnInserir.Enabled = true;

            txtCpf.Enabled = false;
            btnValidar.Enabled = false;
        }

        private void DesativaComponentes()
        {
            txtNome.Enabled = false;
            btnInserir.Enabled = false;

            txtCpf.Enabled = true;
            btnValidar.Enabled = true;
        }

        //Fim - Métodos locais


        public ClienteCPF(Int32 IdCarrinho)
        {

            //cbTipoPessoa.Select();
            ObjCarrinho.Id = IdCarrinho;
            ObjCarrinhoPessoaTipo.Id = 1;

            InitializeComponent();
            DesativaComponentes();

            txtCpf.Focus();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            ObjPessoa.Nome = txtNome.Text;
            ObjPessoa.CpfCnpj = txtCpf.Text;

            ObjCarrinhoPessoa.Id = 0;
            ObjCarrinhoPessoa.Carrinho = ObjCarrinho;
            ObjCarrinhoPessoa.Pessoa = ObjPessoa;
            ObjCarrinhoPessoa.CarrinhoPessoaTipo = ObjCarrinhoPessoaTipo;
            carrinhoPessoaAccess.Gravar(ObjCarrinhoPessoa);

            //if (Id != 0)
            //{
            //    this.DialogResult = DialogResult.OK;
            //}

            Close();

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            Validar();
        }

    }
}
