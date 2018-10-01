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

namespace Windows.FormsPessoaJuridica
{
    public partial class Cadastro : Form
    {
        //Objetos
        Pessoa ObjPessoa = new Pessoa();
        PessoaJuridica ObjPessoaJuridica = new PessoaJuridica();

        //Access
        PessoaAccess ObjPessoaAccess = new PessoaAccess();
        PessoaJuridicaAccess ObjPessoaJuridicaAccess = new PessoaJuridicaAccess();
        SexoAccess ObjSexoAccess = new SexoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


        //Início - Métodos locais
        private void Ler()
        {

            //CASO OBJETO ESTEJA null CRIA UMA NOVA ESTÂNCIA
            ObjPessoa = ObjPessoa ?? new Pessoa();

            txtId.Text = Convert.ToString(ObjPessoa.Id);
            txtRazaoSocial.Text = ObjPessoa.Nome;
            txtCnpj.Text = ObjPessoa.CpfCnpj == null ? txtCnpj.Text : ObjPessoa.CpfCnpj;

            ObjPessoaJuridica = ObjPessoaJuridica ?? new PessoaJuridica();

            txtFantasia.Text = ObjPessoaJuridica.Fantasia;
            txtIe.Text = Convert.ToString(ObjPessoaJuridica.Ie);
            dtDataConstituicao.Text = ObjPessoaJuridica.DataConstituicao <= DateTime.MinValue ? Convert.ToString(DateTime.Now) : Convert.ToString(ObjPessoaJuridica.DataConstituicao);

            AtivaComponentes();
        }

        private void DesativaComponentes()
        {

            txtRazaoSocial.Enabled = false;
            txtFantasia.Enabled = false;
            txtCnpj.Enabled = true;
            btnValidar.Enabled = true;
            txtIe.Enabled = false;
            tcDados.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtRazaoSocial.Enabled = true;
            txtFantasia.Enabled = true;
            txtCnpj.Enabled = false;
            btnValidar.Enabled = false;
            txtIe.Enabled = true;
            tcDados.Enabled = true;
            btnGravar.Enabled = true;

        }

        private string CnpjValido()
        {

            lblValidaCnpj.Text = "-";
            ObjPessoa = ObjPessoaAccess.LerCpfCnpj(txtCnpj.Text);
            ObjPessoaJuridica = ObjPessoaJuridicaAccess.Ler(txtCnpj.Text);

            Ler();

            //AtivaComponentes();
            return "OK";

        }

        private string CnpjInvalido()
        {

            return "Numero de CPF Inválido!";

        }

        private void ValidarCnpj()
        {

            lblValidaCnpj.Text = ObjUtilitario.ValidaCnpj(txtCnpj.Text) == true ? CnpjValido() : CnpjInvalido();
            txtCnpj.Focus().Equals(lblValidaCnpj.Text != "OK");
            txtRazaoSocial.Focus().Equals(lblValidaCnpj.Text == "OK");

        }

        private string IdMaiorZero(int Id)
        {
            ObjPessoa = ObjPessoaAccess.Ler(Id);
            ObjPessoaJuridica = ObjPessoaJuridicaAccess.Ler(ObjPessoa.CpfCnpj);

            Ler();

            return Convert.ToString(Id);
        }

        private string IdZero()
        {
            DesativaComponentes();

            return "0";
        }
        //Fim - Métodos locais



        public Cadastro(int Id)
        {

            InitializeComponent();

            txtId.Text = Id == 0 ? IdZero() : IdMaiorZero(Id);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            ObjPessoa.Id = Convert.ToInt32(txtId.Text);
            ObjPessoa.Nome = txtRazaoSocial.Text;
            ObjPessoa.CpfCnpj = txtCnpj.Text;
            ObjPessoaJuridica.Pessoa = ObjPessoa;

            ObjPessoaJuridica.Fantasia = txtFantasia.Text;
            ObjPessoaJuridica.Ie = txtIe.Text;
            ObjPessoaJuridica.DataConstituicao = Convert.ToDateTime(ObjUtilitario.formataData(dtDataConstituicao.Text)); //txtdatanascimento.Text.Substring(6, 4) + "-" + txtdatanascimento.Text.Substring(3, 2) + "-" + txtdatanascimento.Text.Substring(0, 2);
            //ObjPessoaFisica.Usuario = "patrikmuller";

            txtId.Text = Convert.ToString(ObjPessoaJuridicaAccess.Salvar(ObjPessoaJuridica));
            Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarCnpj();
        }
    }
}
