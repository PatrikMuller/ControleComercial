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
        Pessoa pessoa = new Pessoa();
        CarrinhoItem carrinhoItem = new CarrinhoItem();
        CarrinhoPessoa carrinhoPessoa = new CarrinhoPessoa();
        CarrinhoPessoaTipo carrinhoPessoaTipo = new CarrinhoPessoaTipo();
        FormaPagamentoParcelamento formaPagamentoParcelamento = new FormaPagamentoParcelamento();
        CarrinhoFormaPagamentoParcelamento carrinhoFormaPagamentoParcelamento = new CarrinhoFormaPagamentoParcelamento();

        //Persistencia
        CarrinhoAccess CarrinhoDao = new CarrinhoAccess();
        CarrinhoItemAccess carrinhoItemDao = new CarrinhoItemAccess();
        CarrinhoPessoaAccess carrinhoPessoaDao = new CarrinhoPessoaAccess();
        CarrinhoFormaPagamentoParcelamentoAccess carrinhoFormaPagamentoParcelamentoDao = new CarrinhoFormaPagamentoParcelamentoAccess();
                        
        private void configuraGridProdutos()
        {

            //GridProdutos.Columns[1].Width = 200;
            GridProdutos.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.000";
            GridProdutos.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[4].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[5].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }

        private void DesativaComponentes()
        {

            btnNovoCarrinho.Enabled = true;
            btnInserirCliente.Enabled = false;
            btnVendedor.Enabled = false;
            btnFormaPgto.Enabled = false;


        }

        private void AtivaComponentes()
        {

            btnNovoCarrinho.Enabled = false;
            btnInserirCliente.Enabled = true;
            btnVendedor.Enabled = true;
            btnFormaPgto.Enabled = true;


        }

        private void LerCliente()
        {

            carrinhoPessoa = carrinhoPessoaDao.Ler(Convert.ToInt32(txtIdCarrinho.Text), 1);
            if (carrinhoPessoa != null)
            {
                lblClienteNome.Text = carrinhoPessoa.Pessoa.Nome;
                lblClienteCpfCnpj.Text = carrinhoPessoa.Pessoa.CpfCnpj;
            }
            
        }

        private void LerVendedor()
        {

            carrinhoPessoa = carrinhoPessoaDao.Ler(Convert.ToInt32(txtIdCarrinho.Text), 2);
            if (carrinhoPessoa != null)
            {
                lblVendedorNome.Text = carrinhoPessoa.Pessoa.Nome;
            }

        }
        

        public CadastroCarrinho()
        {

            InitializeComponent();
                        
            //GridProdutos.DataSource = carrinhoItemDao.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
            //configuraGridProdutos();

            //LerCliente();

            //LerVendedor();
            
            //gridFormaPgto.DataSource = carrinhoFormaPagamentoParcelamentoDao.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));

            DesativaComponentes();
                        

        }

        private void btnNovoCarrinho_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
            txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Novo(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
            AtivaComponentes();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
            txtIdCarrinho.Text = Convert.ToString(CarrinhoDao.Gravar(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
            Close();
            DesativaComponentes();

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {

            LocalizarItem form = new LocalizarItem();

            if (form.ShowDialog() == DialogResult.OK)
            {

                DataGridViewRow Row = new DataGridViewRow();
                Row = form.Row();

                carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                carrinhoItem.Carrinho = carrinho;

                item.Id = Convert.ToInt32(Row.Cells[0].Value);
                carrinhoItem.Item = item;

                carrinhoItem.Ordem = (GridProdutos.Rows.Count + 1);
                carrinhoItem.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
                carrinhoItem.Preco = Convert.ToDecimal(Row.Cells[3].Value);
                carrinhoItem.Desconto = Convert.ToDecimal(0.00);

                carrinhoItemDao.Novo(carrinhoItem);
                GridProdutos.DataSource = null;
                //GridProdutos.DataSource = dadosGridProduto(carrinhoItemDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));
                GridProdutos.DataSource = carrinhoItemDao.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
                configuraGridProdutos();

                //NHibernate.Exceptions.GenericADOException: 'could not insert: [Infraestrutura.Models.CarrinhoItem#39][SQL: 
                //INSERT INTO "CarrinhoItem" (Ordem, Quantidade, Preco, Desconto, CarrinhoId, ItemId, Id) VALUES (?, ?, ?, ?, ?, ?, ?)]'



            }

        }

        private void btnInserirCliente_Click(object sender, EventArgs e)
        {

            InserirCliente form = new InserirCliente(0);

            if (form.ShowDialog() == DialogResult.OK)
            {

                //pessoa.Id = form.Id;
                carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                carrinhoPessoaTipo.Id = 1; // 1 = Cliente

                //DataGridViewRow Row = new DataGridViewRow();
                //Row = form.Row();

                carrinhoPessoa.Carrinho = carrinho;
                carrinhoPessoa.Pessoa = pessoa;
                carrinhoPessoa.CarrinhoPessoaTipo = carrinhoPessoaTipo;

                carrinhoPessoaDao.Novo(carrinhoPessoa);

            }

        }

        private void btnFormaPgto_Click(object sender, EventArgs e)
        {

            //LocalizarItem form = new LocalizarItem();
            SelecionarFormaPagamento form = new SelecionarFormaPagamento();

            if (form.ShowDialog() == DialogResult.OK)
            {

                DataGridViewRow Row = new DataGridViewRow();
                Row = form.Row();

                carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
                formaPagamentoParcelamento.Id = Convert.ToInt32(Row.Cells[0].Value);

                carrinhoFormaPagamentoParcelamento.Carrinho = carrinho;
                carrinhoFormaPagamentoParcelamento.FormaPagamentoParcelamento = formaPagamentoParcelamento;
                carrinhoFormaPagamentoParcelamento.QtdParcelas = Convert.ToInt32(Row.Cells[2].Value);
                carrinhoFormaPagamentoParcelamento.Juros = Convert.ToDecimal(Row.Cells[3].Value);

                carrinhoFormaPagamentoParcelamentoDao.Novo(carrinhoFormaPagamentoParcelamento);
                //gridFormaPgto.DataSource = dadosGridFormaPgto(carrinhoFormaPagamentoParcelamentoDao.Lista(Convert.ToInt32(txtIdCarrinho.Text)));


            }

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
                        
            pessoa.Id = 14;
            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinhoPessoaTipo.Id = 2; // 2 = Cliente

            //DataGridViewRow Row = new DataGridViewRow();
            //Row = form.Row();

            carrinhoPessoa.Carrinho = carrinho;
            carrinhoPessoa.Pessoa = pessoa;
            carrinhoPessoa.CarrinhoPessoaTipo = carrinhoPessoaTipo;

            carrinhoPessoaDao.Novo(carrinhoPessoa);
            //gridVendedor.DataSource = dadosGridVendedor(carrinhoPessoaDao.Lista(Convert.ToInt32(txtIdCarrinho.Text), 2));

        }
    }
}
