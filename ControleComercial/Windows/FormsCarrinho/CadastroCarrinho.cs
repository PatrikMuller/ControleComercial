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
        
        //Access
        CarrinhoAccess carrinhoDao = new CarrinhoAccess();
        CarrinhoItemAccess carrinhoItemDao = new CarrinhoItemAccess();
        CarrinhoPessoaAccess carrinhoPessoaDao = new CarrinhoPessoaAccess();
        CarrinhoFormaPagamentoAccess carrinhoFormaPagamentoAccess = new CarrinhoFormaPagamentoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


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
            btnClienteCNPJ.Enabled = false;
            btnVendedor.Enabled = false;
            btnFormaPgto.Enabled = false;


        }

        private void AtivaComponentes()
        {

            btnNovoCarrinho.Enabled = false;
            btnClienteCNPJ.Enabled = true;
            btnVendedor.Enabled = true;
            btnFormaPgto.Enabled = true;


        }

        private void LerCarrinho(Int32 Id)
        {

            carrinho = carrinhoDao.Ler(Id);
            if (carrinho != null)
            {
                txtIdCarrinho.Text = Convert.ToString(carrinho.Id);
                txtDataCarrinho.Text = Convert.ToString(carrinho.Data);                
            }

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
        

        public CadastroCarrinho(Int32 Id)
        {

            InitializeComponent();


            if (Id != 0)
            {
                LerCarrinho(Id);
                LerCliente();
                LerVendedor();
                GridProdutos.DataSource = carrinhoItemDao.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
                gridFormaPgto.DataSource = carrinhoFormaPagamentoAccess.Lista(Convert.ToInt32(txtIdCarrinho.Text));
                AtivaComponentes();
                configuraGridProdutos();
            }
                
            
        }

        private void btnNovoCarrinho_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
            txtIdCarrinho.Text = Convert.ToString(carrinhoDao.Novo(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
            AtivaComponentes();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.Data = DateTime.Now;
            txtIdCarrinho.Text = Convert.ToString(carrinhoDao.Gravar(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.Data);
            Close();
            DesativaComponentes();

        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            FormsCarrinhoItem.Cadastro form = new FormsCarrinhoItem.Cadastro
                (Convert.ToInt32(txtIdCarrinho.Text), //IdCarrinho
                GridProdutos.RowCount, //Total de Produtos
                Convert.ToDouble(txtQuantidade.Text)); //Quantidade

            if (form.ShowDialog() == DialogResult.OK)
            {
                GridProdutos.DataSource = carrinhoItemDao.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
                configuraGridProdutos();
            }

        }
                
        private void btnFormaPgto_Click(object sender, EventArgs e)
        {

            FormsCarrinhoFormaPagamento.CadastroFormaPagamento form = new FormsCarrinhoFormaPagamento.CadastroFormaPagamento(Convert.ToInt32(txtIdCarrinho.Text), 550.35);

            if (form.ShowDialog() == DialogResult.OK)
            {
                gridFormaPgto.DataSource = carrinhoFormaPagamentoAccess.Lista(Convert.ToInt32(txtIdCarrinho.Text));
            }

        }

        private void btnVendedor_Click(object sender, EventArgs e)
        {
                        
            pessoa.Id = 3;
            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinhoPessoaTipo.Id = 2; // 2 = Cliente

            //DataGridViewRow Row = new DataGridViewRow();
            //Row = form.Row();

            carrinhoPessoa.Carrinho = carrinho;
            carrinhoPessoa.Pessoa = pessoa;
            carrinhoPessoa.CarrinhoPessoaTipo = carrinhoPessoaTipo;

            carrinhoPessoaDao.Novo(carrinhoPessoa);
            LerVendedor();
            //gridVendedor.DataSource = dadosGridVendedor(carrinhoPessoaDao.Lista(Convert.ToInt32(txtIdCarrinho.Text), 2));

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQuantidade.Text = ObjUtilitario.mascaraQuantidade(txtQuantidade, e); //Mudar a Mascara
            txtQuantidade.SelectionStart = txtQuantidade.TextLength;
        }

        private void btnClienteCPF_Click(object sender, EventArgs e)
        {
            FormsCarrinhoPessoa.ClienteCPF form = new FormsCarrinhoPessoa.ClienteCPF(Convert.ToInt32(txtIdCarrinho.Text));
            form.ShowDialog();
        }

        private void btnClienteCNPJ_Click(object sender, EventArgs e)
        {
            FormsCarrinhoPessoa.ClienteCNPJ form = new FormsCarrinhoPessoa.ClienteCNPJ(Convert.ToInt32(txtIdCarrinho.Text));
            form.ShowDialog();
        }
        
    }
}
