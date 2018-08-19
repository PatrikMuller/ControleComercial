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

namespace Windows.FormsPessoaFisica
{
    public partial class FormCadastroPessoaFisica : Form
    {

        //Objetos
        Pessoa ObjPessoa = new Pessoa();
        PessoaFisica ObjPessoaFisica = new PessoaFisica();

        //Access
        PessoaAccess ObjPessoaAccess = new PessoaAccess();
        PessoaFisicaAccess ObjPessoaFisicaAccess = new PessoaFisicaAccess();
        SexoAccess ObjSexoAccess = new SexoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();
        

        //Início - Métodos locais
        private void LerPessoaFisica()
        {

            //CASO OBJETO ESTEJA null CRIA UMA NOVA ESTÂNCIA
            ObjPessoa = ObjPessoa ?? new Pessoa();
            
            txtId.Text = Convert.ToString(ObjPessoa.Id);
            txtNome.Text = ObjPessoa.Nome;
            txtCpf.Text = ObjPessoa.CpfCnpj == null ? txtCpf.Text : ObjPessoa.CpfCnpj;
            
            ObjPessoaFisica = ObjPessoaFisica ?? new PessoaFisica();
            
            txtRg.Text = Convert.ToString(ObjPessoaFisica.Rg);
            txtNomePai.Text = Convert.ToString(ObjPessoaFisica.NomePai);
            txtNomeMae.Text = Convert.ToString(ObjPessoaFisica.NomeMae);
            dtDataNascimento.Text = ObjPessoaFisica.DataNascimento <= DateTime.MinValue ? Convert.ToString(DateTime.Now) : Convert.ToString(ObjPessoaFisica.DataNascimento);
            cbSexo.SelectedValue = ObjPessoaFisica.Sexo == null ? "M" : Convert.ToString(ObjPessoaFisica.Sexo);

            AtivaComponentes();
        }

        private void DesativaComponentes()
        {
            
            txtNome.Enabled = false;
            txtCpf.Enabled = true;
            btnValidar.Enabled = true;
            txtRg.Enabled = false;
            tcDados.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtNome.Enabled = true;
            txtCpf.Enabled = false;
            btnValidar.Enabled = false;
            txtRg.Enabled = true;
            tcDados.Enabled = true;
            btnGravar.Enabled = true;

        }
        
        private String CpfValido()
        {

            lblValidaCpf.Text = "-";
            ObjPessoa = ObjPessoaAccess.LerCpfCnpj(txtCpf.Text);
            ObjPessoaFisica = ObjPessoaFisicaAccess.Ler(txtCpf.Text);
            
            LerPessoaFisica();

            //AtivaComponentes();
            return "OK";

        }

        private String CpfInvalido()
        {

            return "Numero de CPF Inválido!";

        }
                        
        private void ValidarCpf()
        {

            lblValidaCpf.Text = ObjUtilitario.validacpf(txtCpf.Text) == true ? CpfValido() : CpfInvalido();
            txtCpf.Focus().Equals(lblValidaCpf.Text != "OK");
            txtNome.Focus().Equals(lblValidaCpf.Text == "OK");

        }

        private String IdMaiorZero(Int32 Id)
        {
            ObjPessoa = ObjPessoaAccess.Ler(Id);
            ObjPessoaFisica = ObjPessoaFisicaAccess.Ler(ObjPessoa.CpfCnpj);

            LerPessoaFisica();

            return Convert.ToString(Id);
        }

        private String IdZero()
        {
            DesativaComponentes();

            return "0";
        }
        //Fim - Métodos locais
              


        public FormCadastroPessoaFisica(Int32 Id)
        {

            InitializeComponent();

            ObjUtilitario. setComboBox(cbSexo, ObjSexoAccess.Lista());

            txtId.Text = Id == 0 ? IdZero() : IdMaiorZero(Id);
                        
        }
                
        private void btnGravar_Click(object sender, EventArgs e)
        {
                        
            ObjPessoa.Id = Convert.ToInt32(txtId.Text);
            ObjPessoa.Nome = txtNome.Text;
            ObjPessoa.CpfCnpj = txtCpf.Text;
            ObjPessoaFisica.Pessoa = ObjPessoa;
                        
            ObjPessoaFisica.Rg = txtRg.Text;
            ObjPessoaFisica.NomePai = txtNomePai.Text;
            ObjPessoaFisica.NomeMae = txtNomeMae.Text;
            ObjPessoaFisica.DataNascimento = Convert.ToDateTime(ObjUtilitario.formataData(dtDataNascimento.Text)); //txtdatanascimento.Text.Substring(6, 4) + "-" + txtdatanascimento.Text.Substring(3, 2) + "-" + txtdatanascimento.Text.Substring(0, 2);
            ObjPessoaFisica.Sexo = Convert.ToString(cbSexo.SelectedValue);
            //ObjPessoaFisica.Usuario = "patrikmuller";

            txtId.Text = Convert.ToString(ObjPessoaFisicaAccess.Salvar(ObjPessoaFisica));
            Close();
                        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void btnValidar_Click(object sender, EventArgs e)
        {
            ValidarCpf();
        }
        
    }
}
