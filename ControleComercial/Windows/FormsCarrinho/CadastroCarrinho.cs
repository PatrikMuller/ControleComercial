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

        //Modelo
        Carrinho carrinho = new Carrinho();
        Item item = new Item();
        CarrinhoItem carrinhoItem = new CarrinhoItem();

        //Persistencia
        CarrinhoAccess CarrinhoDao = new CarrinhoAccess();       
        CarrinhoItemAccess carrinhoItemDao = new CarrinhoItemAccess();


        private DataTable dadosGridProduto(IList<CarrinhoItem> l)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("nº", System.Type.GetType("System.String"));
            dt.Columns.Add("produto", System.Type.GetType("System.String"));
            dt.Columns.Add("qtd", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("preco", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("desconto", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("total", System.Type.GetType("System.Decimal"));
            
            foreach (var carrinhoItem in l)
            {
                dt.Rows.Add(new String[] { Convert.ToString(carrinhoItem.Ordem), carrinhoItem.Item.Nome, Convert.ToString(carrinhoItem.Quantidade), Convert.ToString(carrinhoItem.Preco), Convert.ToString(carrinhoItem.Desconto), Convert.ToString(carrinhoItem.Quantidade * (carrinhoItem.Preco - carrinhoItem.Desconto)) });
            }

            return dt;
            
        }

        private void configuraGridProdutos()
        {
            
            //GridProdutos.Columns[1].Width = 200;
            GridProdutos.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.000";
            GridProdutos.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[4].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[5].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }


        public CadastroCarrinho()
        {

            InitializeComponent();

            //GridProdutos.DataSource = dadosGridProduto(carrinhoItemDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));
            GridProdutos.DataSource = dadosGridProduto(carrinhoItemDao.Lista(41));
            configuraGridProdutos();

        }
        
        private void btnNovoCarrinho_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
            txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Novo(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {            
            
            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
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
                
                carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                item.Id = Convert.ToInt32(Row.Cells[0].Value);
                carrinhoItem.Ordem = (GridProdutos.Rows.Count);
                carrinhoItem.Carrinho = carrinho;
                carrinhoItem.Item = item;
                carrinhoItem.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                carrinhoItem.Preco = Convert.ToDecimal(Row.Cells[3].Value);
                carrinhoItem.Desconto = Convert.ToDecimal(0.00);
                carrinhoItemDao.Novo(carrinhoItem);
                GridProdutos.DataSource = null;
                GridProdutos.DataSource = dadosGridProduto(carrinhoItemDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));
                configuraGridProdutos();

            }

        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {
            //LocalizarItem form = new LocalizarItem();
            InserirCliente form = new InserirCliente();

            if (form.ShowDialog() == DialogResult.OK)
            {
                
                //DataGridViewRow Row = new DataGridViewRow();
                //Row = form.Row();

                //carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                //item.Id = Convert.ToInt32(Row.Cells[0].Value);
                //carrinhoItem.Ordem = (GridProdutos.Rows.Count);
                //carrinhoItem.Carrinho = carrinho;
                //carrinhoItem.Item = item;
                //carrinhoItem.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                //carrinhoItem.Preco = Convert.ToDecimal(Row.Cells[3].Value);
                //carrinhoItem.Desconto = Convert.ToDecimal(0.00);
                //carrinhoItemDao.Novo(carrinhoItem);
                //GridProdutos.DataSource = null;
                //GridProdutos.DataSource = dadosGridProduto(carrinhoItemDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));
                //configuraGridProdutos();

            }
        }
    }
}
