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
    public partial class LocalizarItem : Form
    {

        //private Int32 idcarrinho;
        //private Decimal quantidade;
        //private CadastroCarrinho CadastroCarrinho;


        //public LocalizarItem(Int32 idcarrinho, Decimal quantidade, CadastroCarrinho form)
        public LocalizarItem()
        {
            //this.idcarrinho = idcarrinho;
            //this.quantidade = quantidade;
            //this.CadastroCarrinho = form;
            InitializeComponent();
        }


        public DataGridViewRow Row()
        {
            return grid.CurrentRow;
        }


        private void ListaItem_Activated(object sender, EventArgs e)
        {
            Item item = new Item();
            ItemAccess itemAccess = new ItemAccess();

            grid.DataSource = null;
            grid.DataSource = itemAccess.Lista();

            //Grid.DataSource = null;
            //Grid.DataSource = lista;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (grid.CurrentRow != null)
            {
                this.DialogResult = DialogResult.OK;
            }


            //CarrinhoItem carrinhoItem = new CarrinhoItem();
            //CarrinhoItemAccess CarrinhoItemDao = new CarrinhoItemAccess();

            ////carrinho.Id = 15;
            //carrinhoItem.Carrinho.Id = idcarrinho;
            //carrinhoItem.Item = grid.ro


            ////txtIdCarrinho.Text = Convert.ToString(carrinho.Id);
            //txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Gravar(carrinhoItem));
            //txtDataCarrinho.Text = Convert.ToString(carrinhoItem.Data);

            //CadastroItem form = new CadastroItem();
            //form.ShowDialog();

            //Conta novaConta = new ContaCorrente();
            //novaConta.Titular = new Cliente(txtTitular.Text);
            //novaConta.Numero = Convert.ToInt32(txtNumero.Text);

            //formPrincipal.AdicionaConta(novaConta);
            //Close();

        }

    }
}
