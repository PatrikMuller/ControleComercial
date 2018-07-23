using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using Infraestrutura.Access;
//using Infraestrutura.Models;

namespace Windows.Item
{
    public partial class CadastroItem : Form
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Infraestrutura.Models.Item item = new Infraestrutura.Models.Item();
            Infraestrutura.Access.ItemAccess itemAccess = new Infraestrutura.Access.ItemAccess();

            item.Id = Convert.ToInt32(txtId.Text);
            item.Nome = txtNome.Text;
            item.Quantidade = Convert.ToDecimal(txtQuantidade.Text);
            item.Preco = Convert.ToDecimal(txtPreco.Text);
            item.Desconto = Convert.ToDecimal(txtDesconto.Text);

            txtId.Text = Convert.ToString(itemAccess.Novo(item));                        
        }
    }
}
