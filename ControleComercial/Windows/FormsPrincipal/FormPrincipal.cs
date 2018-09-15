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

            if (iLista.Count == 0)
            {
                Item iObj = new Item();

                iObj.Nome = "ANTENA WIRELLES";
                iObj.Preco = 45.38;
                iObj.Quantidade = 100;
                iObj.Desconto = 6.25;
                
                iAccess.Novo(iObj);

                iObj.Nome = "BICILETA 21 MARCHAS";
                iObj.Preco = 835.28;
                iObj.Quantidade = 50;
                iObj.Desconto = 15.24;

                iAccess.Novo(iObj);

                iObj.Nome = "FEIJAO TIO URBANO";
                iObj.Preco = 5.29;
                iObj.Quantidade = 1000;
                iObj.Desconto = 5.25;

                iAccess.Novo(iObj);

                iObj.Nome = "CHOCOLATE BATON";
                iObj.Preco = 0.70;
                iObj.Quantidade = 1000;
                iObj.Desconto = 0.00;

                iAccess.Novo(iObj);

            }

            lblTabelas.Text = "Gravado com Sucesso!";

        }

    }
}
