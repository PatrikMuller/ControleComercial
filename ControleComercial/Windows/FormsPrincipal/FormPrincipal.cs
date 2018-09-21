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
using Infraestrutura.Models;
using Infraestrutura.Access;

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
            FormsCarrinho.Lista form = new FormsCarrinho.Lista();
            form.ShowDialog();            
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

        private void btnGerarTabelas_Click(object sender, EventArgs e)
        {
            //UnidadeMedida
            UnidadeMedidaAccess umAccess = new UnidadeMedidaAccess();

            var umLista = umAccess.Lista();

            if (umLista.Count == 0)
            {

                UnidadeMedida umObj = new UnidadeMedida();

                umObj.Descricao = "UNIDADE";
                umObj.Sigla = "UNID";

                umAccess.Novo(umObj);

            }

            //Fabricante
            FabricanteAccess fAccess = new FabricanteAccess();

            var fLista = fAccess.Lista();

            if (fLista.Count == 0)
            {

                Fabricante fObj = new Fabricante();

                fObj.Descricao = "FABRICANTE";

                fAccess.Novo(fObj);

            }

            //CarrinhoPessoaTipo
            CarrinhoPessoaTipoAccess ctpAccess = new CarrinhoPessoaTipoAccess();

            var ctpLista = ctpAccess.Lista();

            if (ctpLista.Count == 0)
            {

                CarrinhoPessoaTipo ctpObj = new CarrinhoPessoaTipo();

                ctpObj.Descricao = "CLIENTE";

                ctpAccess.Novo(ctpObj);

                ctpObj.Descricao = "VENDEDOR";

                ctpAccess.Novo(ctpObj);

            }


            //FormaPagamento
            FormaPagamentoAccess fpAccess = new FormaPagamentoAccess();

            var fpLista = fpAccess.Lista();

            if (fpLista.Count == 0)
            {
                FormaPagamento fpObj = new FormaPagamento();

                fpObj.Descricao = "DINHEIRO";

                fpAccess.Novo(fpObj);

                fpObj.Descricao = "CARTÃO DÉBITO";

                fpAccess.Novo(fpObj);

                fpObj.Descricao = "CARTÃO CRÉDITO";

                fpAccess.Novo(fpObj);
            }


            //Parcelamento Status
            ParcelamentoStatusAccess psAccess = new ParcelamentoStatusAccess();

            var psLista = psAccess.Lista();

            if (psLista.Count == 0)
            {
                ParcelamentoStatus psObj = new ParcelamentoStatus();

                psObj.Descricao = "ATIVO";

                psAccess.Novo(psObj);

                psObj.Descricao = "INATIVO";

                psAccess.Novo(psObj);
            }



            //FormaPagamento
            FormaPagamentoParcelamentoAccess fppAccess = new FormaPagamentoParcelamentoAccess();

            var fppLista = fppAccess.Lista();

            if (fppLista.Count == 0)
            {
                FormaPagamentoParcelamento fppObj = new FormaPagamentoParcelamento();
                FormaPagamento fp = new FormaPagamento();
                ParcelamentoStatus ps = new ParcelamentoStatus();

                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0.00;
                fp.Id = 1;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);


                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0.00;
                fp.Id = 2;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);


                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0.00;
                fp.Id = 3;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);

            }



            //FormaPagamento
            ItemAccess iAccess = new ItemAccess();

            var iLista = iAccess.Lista();
            Int32 IdItem1 = 0;
            Int32 IdItem2 = 0;
            Int32 IdItem3 = 0;

            if (iLista.Count == 0)
            {
                Item iObj = new Item();

                iObj.Nome = "ANTENA WIRELLES";
                iObj.Preco = 45.38;
                iObj.Quantidade = 100;
                iObj.Desconto = 6.25;

                IdItem1 = iAccess.Novo(iObj);

                iObj.Nome = "BICILETA 21 MARCHAS";
                iObj.Preco = 835.28;
                iObj.Quantidade = 50;
                iObj.Desconto = 15.24;

                IdItem2 = iAccess.Novo(iObj);

                iObj.Nome = "FEIJAO TIO URBANO";
                iObj.Preco = 5.29;
                iObj.Quantidade = 1000;
                iObj.Desconto = 5.25;

                IdItem3 = iAccess.Novo(iObj);

                iObj.Nome = "CHOCOLATE BATON";
                iObj.Preco = 0.70;
                iObj.Quantidade = 1000;
                iObj.Desconto = 0.00;

                iAccess.Novo(iObj);

            }


            //Carrinho
            CarrinhoAccess cAccess = new CarrinhoAccess();

            var cLista = cAccess.Lista();
            Int32 IdCarrinho = 0;

            if (cLista.Count == 0)
            {
                Carrinho cObj = new Carrinho();

                cObj.Id = 0;
                cObj.DataAbertura = DateTime.Now;
                cObj.UsuarioAbertura = "patrikmuller";

                IdCarrinho = cAccess.Novo(cObj);                
            }

            //CarrinhoItem
            CarrinhoItemAccess ciAccess = new CarrinhoItemAccess();

            if (IdCarrinho != 0)
            {
                var ciLista = ciAccess.Lista(IdCarrinho);

                if (ciLista.Count == 0)
                {
                    Carrinho carrinho = new Carrinho();
                    Item item = new Item();
                    CarrinhoItem ciObj = new CarrinhoItem();

                    carrinho.Id = IdCarrinho;
                    item = iAccess.Ler(IdItem1);

                    ciObj.Carrinho = carrinho;
                    ciObj.Item = item;
                    ciObj.Ordem = 1;
                    ciObj.Preco = item.Preco;
                    ciObj.Quantidade = 1.234;
                    ciObj.Desconto = 0.00;

                    ciAccess.Novo(ciObj);


                    item = iAccess.Ler(IdItem2);
                    ciObj.Carrinho = carrinho;
                    ciObj.Item = item;
                    ciObj.Ordem = 2;
                    ciObj.Preco = item.Preco;
                    ciObj.Quantidade = 1.000;
                    ciObj.Desconto = 0.00;

                    ciAccess.Novo(ciObj);


                    item = iAccess.Ler(IdItem3);
                    ciObj.Carrinho = carrinho;
                    ciObj.Item = item;
                    ciObj.Ordem = 3;
                    ciObj.Preco = item.Preco;
                    ciObj.Quantidade = 2.123;
                    ciObj.Desconto = 0.00;

                    ciAccess.Novo(ciObj);

                }
            }
            
            
            //CarrinhoFormaPagamento
            CarrinhoFormaPagamentoAccess cfpAccess = new CarrinhoFormaPagamentoAccess();

            if (IdCarrinho != 0)
            {

                var cfpLista = cfpAccess.GetAll(IdCarrinho);

                if (cfpLista.Count == 0)
                {
                    Carrinho carrinho = new Carrinho();                    
                    FormaPagamento fp = new FormaPagamento();
                    CarrinhoFormaPagamento cfpObj = new CarrinhoFormaPagamento();

                    carrinho.Id = IdCarrinho;
                    fp = fpAccess.Ler(1);

                    cfpObj.Id = 0;
                    cfpObj.Carrinho = carrinho;
                    cfpObj.FormaPagamento = fp;
                    cfpObj.QtdParcelas = 1;
                    cfpObj.ValorPagar = 1235.23;
                    cfpObj.ValorParcela = 535.32;
                    cfpObj.Juros = 0.00;

                    cfpAccess.Novo(cfpObj);
                }

            }


            lblTabelas.Text = "Gravado com Sucesso!";

        }

        private void btnClasse_Click(object sender, EventArgs e)
        {
            FormsClasse.Lista formLista = new FormsClasse.Lista();
            formLista.ShowDialog();
        }

        private void btnEspecificacao_Click(object sender, EventArgs e)
        {
            FormsEspecificacao.Lista formLista = new FormsEspecificacao.Lista();
            formLista.ShowDialog();
        }

        private void btnEspecificacaoTipo_Click(object sender, EventArgs e)
        {
            FormsEspecificacaoTipo.Lista formLista = new FormsEspecificacaoTipo.Lista();
            formLista.ShowDialog();
        }
    }
}
