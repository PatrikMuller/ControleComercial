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
    public partial class ClienteCNPJ : Form
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
            txtCnpj.Text = ObjPessoa.CpfCnpj == null ? txtCnpj.Text : ObjPessoa.CpfCnpj;

            //AtivaComponentes();
        }

        private String CnpjValido()
        {

            lblValidaCpf.Text = "-";
            ObjPessoa = pessoaAccess.LerCpfCnpj(txtCnpj.Text);

            Ler();

            AtivaComponentes();
            return "OK";

        }

        private String CnpjInvalido()
        {

            return "Numero de CNPJ Inválido!";

        }

        private void Validar()
        {

            lblValidaCpf.Text = ObjUtilitario.ValidaCnpj(txtCnpj.Text) == true ? CnpjValido() : CnpjInvalido();
            txtCnpj.Focus().Equals(lblValidaCpf.Text != "OK");
            txtNome.Focus().Equals(lblValidaCpf.Text == "OK");

        }

        private void AtivaComponentes()
        {
            txtNome.Enabled = true;
            btnInserir.Enabled = true;

            txtCnpj.Enabled = false;
            btnValidar.Enabled = false;
        }

        private void DesativaComponentes()
        {
            txtNome.Enabled = false;
            btnInserir.Enabled = false;

            txtCnpj.Enabled = true;
            btnValidar.Enabled = true;
        }

        //Fim - Métodos locais


        public ClienteCNPJ(Int32 IdCarrinho)
        {

            //cbTipoPessoa.Select();
            ObjCarrinho.Id = IdCarrinho;
            ObjCarrinhoPessoaTipo.Id = 1;

            InitializeComponent();
            DesativaComponentes();

            txtCnpj.Focus();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            ObjPessoa.Nome = txtNome.Text;
            ObjPessoa.CpfCnpj = txtCnpj.Text;

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
