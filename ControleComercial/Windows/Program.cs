using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormsCarrinho.CadastroCarrinho());

            //Application.Run(new FormsPrincipal.FormPrincipal());

            //Application.Run(new FormsItem.ListaItem());
            //Application.Run(new FormsCarrinho.InserirCliente(46));
            //Application.Run(new FormsCarrinhoPessoa.ClienteCNPJ(46));

            //Application.Run(new FormsCarrinhoFormaPagamento.CadastroFormaPagamento(46, 435.98));

            //Application.Run(new FormsFormaPagamentoParcelamento.Cadastro());
            Application.Run(new FormsCarrinho.Lista());

        }
    }
}
