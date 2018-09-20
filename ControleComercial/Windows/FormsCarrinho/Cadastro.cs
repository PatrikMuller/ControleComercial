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
    public partial class Cadastro : Form
    {
        //Modelo
        Carrinho carrinho = new Carrinho();
        CarrinhoItem carrinhoItem = new CarrinhoItem();
        CarrinhoPessoa carrinhoPessoa = new CarrinhoPessoa();
        FormaPagamentoParcelamento formaPagamentoParcelamento = new FormaPagamentoParcelamento();

        //Access
        CarrinhoAccess carrinhoAccess = new CarrinhoAccess();
        CarrinhoItemAccess carrinhoItemAccess = new CarrinhoItemAccess();
        CarrinhoPessoaAccess carrinhoPessoaAccess = new CarrinhoPessoaAccess();
        CarrinhoFormaPagamentoAccess carrinhoFormaPagamentoAccess = new CarrinhoFormaPagamentoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();

        //Variaveis
        double Total = 0.00;


        private void configuraGridProdutos()
        {

            GridProdutos.Columns[0].Width = 60;
            GridProdutos.Columns[1].Width = 180;
            GridProdutos.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.000";
            GridProdutos.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[4].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            GridProdutos.Columns[5].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }

        private void DesativaComponentes()
        {

            btnNovoCarrinho.Enabled = true;
            btnClienteCNPJ.Enabled = false;
            btnFormaPgto.Enabled = false;


        }

        private void AtivaComponentes()
        {

            btnNovoCarrinho.Enabled = false;
            btnClienteCNPJ.Enabled = true;
            btnFormaPgto.Enabled = true;


        }

        private void LerCarrinho(Int32 Id)
        {

            carrinho = carrinhoAccess.Ler(Id);
            if (carrinho != null)
            {
                txtIdCarrinho.Text = Convert.ToString(carrinho.Id);
                txtDataCarrinho.Text = Convert.ToString(carrinho.DataAbertura);
                txtOperador.Text = Convert.ToString(carrinho.UsuarioAbertura);

                Total = ObjUtilitario.Arredondar(carrinhoItemAccess.Total(Id));
                lblTotal.Text = "R$ " + Convert.ToString(Total);
            }

        }

        private void LerCliente()
        {

            carrinhoPessoa = carrinhoPessoaAccess.Ler(Convert.ToInt32(txtIdCarrinho.Text), 1);
            if (carrinhoPessoa != null)
            {
                lblClienteNome.Text = carrinhoPessoa.Pessoa.Nome;
                lblClienteCpfCnpj.Text = carrinhoPessoa.Pessoa.CpfCnpj;
            }

        }
                
        public Cadastro(Int32 Id)
        {

            InitializeComponent();


            if (Id != 0)
            {
                LerCarrinho(Id);
                LerCliente();
                GridProdutos.DataSource = carrinhoItemAccess.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
                gridFormaPgto.DataSource = carrinhoFormaPagamentoAccess.Lista(Convert.ToInt32(txtIdCarrinho.Text));
                AtivaComponentes();
                configuraGridProdutos();
            }


        }

        private void btnNovoCarrinho_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.DataAbertura = DateTime.Now;
            carrinho.UsuarioAbertura = "patrikmuller";
            txtIdCarrinho.Text = Convert.ToString(carrinhoAccess.Novo(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.DataAbertura);
            txtOperador.Text = carrinho.UsuarioAbertura;
            AtivaComponentes();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {

            carrinho.Id = Convert.ToInt32(txtIdCarrinho.Text);
            carrinho.DataFechamento = DateTime.Now;
            carrinho.UsuarioFechamento = "patrikmuller";
            txtIdCarrinho.Text = Convert.ToString(carrinhoAccess.Gravar(carrinho));
            txtDataCarrinho.Text = Convert.ToString(carrinho.DataAbertura);
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
                GridProdutos.DataSource = carrinhoItemAccess.ListaGrid(Convert.ToInt32(txtIdCarrinho.Text));
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

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQuantidade.Text = ObjUtilitario.mascaraQuantidade(txtQuantidade, e); //Mudar a Mascara
            txtQuantidade.SelectionStart = txtQuantidade.TextLength;
        }

        private void btnClienteCPF_Click(object sender, EventArgs e)
        {
            FormsCarrinhoPessoa.ClienteCPF form = new FormsCarrinhoPessoa.ClienteCPF(Convert.ToInt32(txtIdCarrinho.Text), carrinhoPessoa == null ? 0 : carrinhoPessoa.Id);
            form.ShowDialog();
            LerCliente();
        }

        private void btnClienteCNPJ_Click(object sender, EventArgs e)
        {
            FormsCarrinhoPessoa.ClienteCNPJ form = new FormsCarrinhoPessoa.ClienteCNPJ(Convert.ToInt32(txtIdCarrinho.Text), carrinhoPessoa == null ? 0 : carrinhoPessoa.Id);
            form.ShowDialog();
            LerCliente();
        }
    }
}
