using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Windows;

namespace Windows.FormsPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnPessoaFisica_Click(object sender, EventArgs e)
        {

            FormsPessoaFisica.FormListaPessoaFisica formListaPessoaFisica = new FormsPessoaFisica.FormListaPessoaFisica();
            formListaPessoaFisica.ShowDialog();
            
            ////LocalizarItem form = new LocalizarItem();
            //InserirCliente form = new InserirCliente();

            //if (form.ShowDialog() == DialogResult.OK)
            //{

            //    pessoa.Id = form.Id;
            //    carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            //    carrinhoPessoaTipo.Id = 1; // 1 = Cliente

            //    //DataGridViewRow Row = new DataGridViewRow();
            //    //Row = form.Row();

            //    carrinhoPessoa.Carrinho = carrinho;
            //    carrinhoPessoa.Pessoa = pessoa;
            //    carrinhoPessoa.CarrinhoPessoaTipo = carrinhoPessoaTipo;

            //    carrinhoPessoaDao.Novo(carrinhoPessoa);

            //}
        }
    }
}
