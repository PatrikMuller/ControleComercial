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


        private void tabelaGridProduto(DataGridView g, IList<CarrinhoItem> l)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("id", System.Type.GetType("System.String"));
            dt.Columns.Add("produto", System.Type.GetType("System.String"));
            dt.Columns.Add("qtd", System.Type.GetType("System.String"));
            dt.Columns.Add("preco", System.Type.GetType("System.String"));
                        
            //for (int i = 1; i < 10; i++)
            foreach (var carrinhoItem in l)
            {
                dt.Rows.Add(new String[] { Convert.ToString(carrinhoItem.Id), carrinhoItem.Item.Nome, Convert.ToString(carrinhoItem.Quantidade), Convert.ToString(carrinhoItem.Preco) });
            }

            //return dt;

            g.DataSource = null;
            g.DataSource = dt;
        }



        public CadastroCarrinho()
        {
            InitializeComponent();

            //tabelaGridProduto(GridProdutos, carrinhoItemDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));
            tabelaGridProduto(GridProdutos, carrinhoItemDao.Lista(31));

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
                tabelaGridProduto(GridProdutos, carrinhoItemDao.Lista(31));

                //GridProdutos.DataSource = null;
                //GridProdutos.DataSource = carrinhoItemDao.Lista();

                //GravarNotaItem(Convert.ToInt32(Row.Cells[0].Value), "patrikmuller");
                //setarGridItem();
            }

            //ConfiguraCampos();
        }



    }
}
