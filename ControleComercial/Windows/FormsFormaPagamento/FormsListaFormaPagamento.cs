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
    public partial class FormsListaFormaPagamento : Form
    {
        //Objetos
        FormaPagamento obj = new FormaPagamento();

        //Access
        FormaPagamentoAccess access = new FormaPagamentoAccess();
        


        //Início - Métodos locais
        private void configuraGrid(Int32 QtdLinhas)
        {
            if (QtdLinhas > 0)
            {
                Grid.Columns[0].Width = 80;
                Grid.Columns[1].Width = 220;
            }
        }

        private void configuraBotoes(Int32 QtdLinhas)
        {

            MenuItemEditar.Enabled = QtdLinhas == 0 ? false : true;
            MenuButtonEditar.Enabled = QtdLinhas == 0 ? false : true;

        }

        private void setarGrid()
        {

            Grid.DataSource = access.Lista();
            configuraGrid(Grid.RowCount);
            configuraBotoes(Grid.RowCount);

        }

        private void Editar()
        {

            Int32 id = Convert.ToInt32(Grid.CurrentRow.Cells[0].Value);
            FormsCadastroFormaPagamento form = new FormsCadastroFormaPagamento(id);
            form.ShowDialog();

        }

        private void Novo()
        {

            //FormCadastroPessoaFisica form = new FormCadastroPessoaFisica(0);
            //form.ShowDialog();

        }
        //Fim - Métodos locais



        public FormsListaFormaPagamento()
        {

            InitializeComponent();
            setarGrid();
            txtLocalizar.Focus();

        }

        private void FormListaPessoaFisica_Activated(object sender, EventArgs e)
        {

            setarGrid();

        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {

            setarGrid();

        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void MenuItemNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void MenuItemEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void MenuItemFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuButtonNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void MenuButtonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}
