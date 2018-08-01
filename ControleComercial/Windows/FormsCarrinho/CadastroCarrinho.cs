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
    public partial class CadastroCarrinho : Form
    {

        CarrinhoItem carrinhoItem = new CarrinhoItem();
        CarrinhoItemAccess carrinhoItemDao = new CarrinhoItemAccess();

                
        public CadastroCarrinho()
        {
            InitializeComponent();

            GridProdutos.DataSource = null;
            GridProdutos.DataSource = carrinhoItemDao.Lista();

        }

        private void btnNovoCarrinho_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            CarrinhoAccess CarrinhoDao = new CarrinhoAccess();


            //carrinho.Id = 15;
            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;

            //txtIdCarrinho.Text = Convert.ToString(carrinho.Id);
            txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Novo(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Carrinho carrinho = new Carrinho();
            CarrinhoAccess CarrinhoDao = new CarrinhoAccess();


            //carrinho.Id = 15;
            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;

            //txtIdCarrinho.Text = Convert.ToString(carrinho.Id);
            txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Gravar(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            LocalizarItem form = new LocalizarItem();
            
            if (form.ShowDialog() == DialogResult.OK)
            {
                DataGridViewRow Row = new DataGridViewRow();
                Row = form.Row();


                Carrinho carrinho = new Carrinho();
                carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                Item item = new Item();
                item.Id = Convert.ToInt32(Row.Cells[0].Value);


                carrinhoItem.Carrinho = carrinho;
                carrinhoItem.Item = item;
                carrinhoItem.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                carrinhoItem.Preco = Convert.ToDecimal(15.78);
                carrinhoItem.Desconto = Convert.ToDecimal(0.00);
                carrinhoItemDao.Novo(carrinhoItem);
                GridProdutos.DataSource = null;
                GridProdutos.DataSource = carrinhoItemDao.Lista();

                //GravarNotaItem(Convert.ToInt32(Row.Cells[0].Value), "patrikmuller");
                //setarGridItem();
            }

            //ConfiguraCampos();
        }



    }
}
