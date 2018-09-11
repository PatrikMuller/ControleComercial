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

namespace Windows.FormsItem
{
    public partial class CadastroItem : Form
    {
        public CadastroItem()
        {
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            ItemAccess itemAccess = new ItemAccess();

            item.Id = Convert.ToInt32(txtId.Text);
            item.Nome = txtNome.Text;
            item.Quantidade = Convert.ToDouble(txtQuantidade.Text);
            item.Preco = Convert.ToDouble(txtPreco.Text);
            item.Desconto = Convert.ToDouble(txtDesconto.Text);

            txtId.Text = Convert.ToString(itemAccess.Novo(item));
        }

    }
}
