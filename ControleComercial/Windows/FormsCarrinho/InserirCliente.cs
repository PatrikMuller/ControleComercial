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

namespace Windows.FormsCarrinho
{
    public partial class InserirCliente : Form
    {
        Pessoa pessoa = new Pessoa();

        PessoaAccess pessoaAccess = new PessoaAccess();
        

        public InserirCliente()
        {

            //cbTipoPessoa.Select();

            InitializeComponent();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            pessoa.Id = Convert.ToInt32(txtId.Text);

            pessoa.Nome = txtNome.Text;
            pessoa.CpfCnpj = txtCpfCnpj.Text;
            
            txtId.Text = Convert.ToString(pessoaAccess.Novo(pessoa));

        }
    }
}
