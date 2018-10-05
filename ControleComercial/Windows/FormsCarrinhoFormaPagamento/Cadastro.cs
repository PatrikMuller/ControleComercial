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

namespace Windows.FormsCarrinhoFormaPagamento
{
    public partial class Cadastro : Form
    {
        //Objetos
        Carrinho ObjCarrinho = new Carrinho();
        FormaPagamento ObjFormaPagamento = new FormaPagamento();
        FormaPagamentoParcelamento ObjFormaPagamentoParcelamento = new FormaPagamentoParcelamento();
        CarrinhoFormaPagamento ObjCarrinhoFormaPagamento = new CarrinhoFormaPagamento();


        //Access
        FormaPagamentoAccess formaPagamentoAccess = new FormaPagamentoAccess();
        FormaPagamentoParcelamentoAccess formaPagamentoParcelamentoAccess = new FormaPagamentoParcelamentoAccess();
        CarrinhoFormaPagamentoAccess carrinhoFormaPagamentoAccess = new CarrinhoFormaPagamentoAccess();


        //Apoio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


        //Variaveis
        double Total = 0.00;
        double TotalPago = 0.00;
        double valorPagar = 0.00;
        double Parcela = 0.00;

        private void CalculaParcela()
        {
            valorPagar = Convert.ToDouble(txtValorPagar.Text);
            ObjFormaPagamentoParcelamento = formaPagamentoParcelamentoAccess.Ler(Convert.ToInt32(cbParcelas.SelectedValue));

            Parcela = ObjUtilitario.Arredondar((valorPagar / ObjFormaPagamentoParcelamento.QtdParcelas) + (valorPagar / 100 * ObjFormaPagamentoParcelamento.Juros));

            txtValorParcela.Text = Parcela.ToString("###,###,###,##0.00");
        }


        public Cadastro(int IdCarrinho, double ValorTotal)
        {

            InitializeComponent();

            ObjCarrinho.Id = IdCarrinho;
            Total = ValorTotal;
            TotalPago = ObjUtilitario.Arredondar(carrinhoFormaPagamentoAccess.TotalPago(IdCarrinho));
            valorPagar = Total - TotalPago;
            Parcela = valorPagar;

            txtValorPagar.Text = ObjUtilitario.lerPreco(valorPagar);
            txtValorParcela.Text = ObjUtilitario.lerPreco(valorPagar);

            ObjUtilitario.setComboBox(cbFormaPagamento, formaPagamentoAccess.ddl());
            ObjUtilitario.setComboBox(cbParcelas, formaPagamentoParcelamentoAccess.ddl(Convert.ToInt32(cbFormaPagamento.SelectedValue)));

        }

        private void txtValorPagar_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtValorPagar.Text = ObjUtilitario.mascaraMoney(txtValorPagar, valorPagar, e); //Mudar a Mascara
            txtValorPagar.SelectionStart = txtValorPagar.TextLength;
        }

        private void Cadastro_Activated(object sender, EventArgs e)
        {
            txtTotal.Text = Total.ToString("###,###,###,##0.00");
            txtValorPagar.Text = valorPagar.ToString("###,###,###,##0.00");
            txtValorParcela.Text = Parcela.ToString("###,###,###,##0.00");
            txtValorPagar.Focus();
        }

        private void cbFormaPagamento_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ObjUtilitario.setComboBox(cbParcelas, formaPagamentoParcelamentoAccess.ddl(Convert.ToInt32(cbFormaPagamento.SelectedValue)));
        }

        private void txtValorPagar_Leave(object sender, EventArgs e)
        {
            CalculaParcela();
        }

        private void cbParcelas_Leave(object sender, EventArgs e)
        {
            CalculaParcela();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            ObjFormaPagamento.Id = Convert.ToInt32(cbFormaPagamento.SelectedValue);

            ObjCarrinhoFormaPagamento.Carrinho = ObjCarrinho;
            ObjCarrinhoFormaPagamento.FormaPagamento = ObjFormaPagamento;
            ObjCarrinhoFormaPagamento.ValorPagar = ObjUtilitario.Arredondar(Convert.ToDouble(txtValorPagar.Text));
            ObjCarrinhoFormaPagamento.QtdParcelas = ObjFormaPagamentoParcelamento.QtdParcelas;
            ObjCarrinhoFormaPagamento.Juros = ObjFormaPagamentoParcelamento.Juros;
            ObjCarrinhoFormaPagamento.ValorParcela = Convert.ToDouble(txtValorParcela.Text);
            carrinhoFormaPagamentoAccess.Gravar(ObjCarrinhoFormaPagamento);
            Close();

        }
                
    }
}
