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

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();
        

        //Início - Métodos locais
        private void LerPessoaFisica()
        {
            if (ObjPessoa.Id > 0)
            {
                txtid.Text = Convert.ToString(ObjPessoa.Id);
                txtnome.Text = ObjPessoa.Nome;
                txtcpf.Text = ObjPessoa.CpfCnpj;

                if (ObjPessoaFisica != null)
                {
                    txtrg.Text = Convert.ToString(ObjPessoaFisica.Rg);
                    txtnomepai.Text = Convert.ToString(ObjPessoaFisica.NomePai);
                    txtnomemae.Text = Convert.ToString(ObjPessoaFisica.NomeMae);
                    txtdatanascimento.Text = Convert.ToString(ObjPessoaFisica.DataNascimento);

                    cbSexo.SelectedValue = Convert.ToString(ObjPessoaFisica.Sexo);
                }
                                                
            }
        }

        private void DesativaComponentes()
        {

            txtnome.Enabled = false;
            txtcpf.Enabled = true;
            btnValidar.Enabled = true;
            txtrg.Enabled = false;
            tcDados.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtnome.Enabled = true;
            txtcpf.Enabled = false;
            btnValidar.Enabled = false;
            txtrg.Enabled = true;
            tcDados.Enabled = true;
            btnGravar.Enabled = true;

        }

        private void ConfiguraComponentes()
        {
            if (txtid.Text == "0")
                DesativaComponentes();
            else
                AtivaComponentes();
        }

        private void ValidarCpf()
        {
            if (ObjUtilitario.validacpf(txtcpf.Text))
            {
                lblValidaCpf.Text = "-";
                ObjPessoa = ObjPessoaAccess.LerCpfCnpj(txtcpf.Text);
                ObjPessoaFisica = ObjPessoaFisicaAccess.Ler(ObjPessoa.Id);

                LerPessoaFisica();

                AtivaComponentes();
            }
            else
            {
                lblValidaCpf.Text = "Numero de CPF Inválido!";
                txtcpf.Focus();
            }
        }
        //Fim - Métodos locais


        public FormCadastroPessoaFisica()
        {
            InitializeComponent();

            //if (id != 0)
            //{
            //    ObjPessoaFisica = ObjNegocioPessoaFisica.Ler(id);
            //    LerPessoaFisica();
            //}

            ConfiguraComponentes();

        }
                
        private void btnGravar_Click(object sender, EventArgs e)
        {
            ObjPessoaFisica.Id = Convert.ToInt32(txtid.Text);
            ObjPessoaFisica.Nome = txtnome.Text;
            ObjPessoaFisica.CpfCnpj = txtcpf.Text;
            ObjPessoaFisica.Rg = txtrg.Text;
            ObjPessoaFisica.NomePai = txtnomepai.Text;
            ObjPessoaFisica.NomeMae = txtnomemae.Text;
            ObjPessoaFisica.DataNascimento = Convert.ToDateTime(ObjUtilitario.formataData(txtdatanascimento.Text)); //txtdatanascimento.Text.Substring(6, 4) + "-" + txtdatanascimento.Text.Substring(3, 2) + "-" + txtdatanascimento.Text.Substring(0, 2);
            ObjPessoaFisica.Sexo = Convert.ToString(cbSexo.SelectedValue);
            //ObjPessoaFisica.Usuario = "patrikmuller";
            txtid.Text = Convert.ToString(ObjPessoaFisicaAccess.Novo(ObjPessoaFisica));
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
