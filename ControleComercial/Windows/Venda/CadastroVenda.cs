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

namespace Windows.Venda
{
    public partial class CadastroVenda : Form
    {
        public CadastroVenda()
        {
            InitializeComponent();
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
    }
}
