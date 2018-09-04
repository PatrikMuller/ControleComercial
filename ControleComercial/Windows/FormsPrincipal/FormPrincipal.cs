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
            FormsPessoaFisica.Lista formLista = new FormsPessoaFisica.Lista();
            formLista.ShowDialog();                        
        }

        private void btnPessoaJuridica_Click(object sender, EventArgs e)
        {
            FormsPessoaJuridica.Lista formLista = new FormsPessoaJuridica.Lista();
            formLista.ShowDialog();
        }

        private void btnTelaVenda_Click(object sender, EventArgs e)
        {
            FormsCarrinho.CadastroCarrinho formCadastroCarrinho = new FormsCarrinho.CadastroCarrinho();
            formCadastroCarrinho.ShowDialog();
        }

        private void btnFormaPagamento_Click(object sender, EventArgs e)
        {
            FormsFormaPagamento.Lista formLista = new FormsFormaPagamento.Lista();
            formLista.ShowDialog();            
        }

        private void btnFabricante_Click(object sender, EventArgs e)
        {
            FormsFabricante.Lista formLista = new FormsFabricante.Lista();
            formLista.ShowDialog();
        }

        private void btnUnidadeMedida_Click(object sender, EventArgs e)
        {
            FormsUnidadeMedida.Lista formLista = new FormsUnidadeMedida.Lista();
            formLista.ShowDialog();
        }
    }
}
