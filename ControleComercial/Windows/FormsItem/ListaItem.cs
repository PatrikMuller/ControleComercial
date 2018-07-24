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
    public partial class ListaItem : Form
    {
        public ListaItem()
        {
            InitializeComponent();
        }

        private void ListaItem_Activated(object sender, EventArgs e)
        {
            Item item = new Item();
            ItemAccess itemAccess = new ItemAccess();

            grid.DataSource = null;
            grid.DataSource = itemAccess.Lista();

            //Grid.DataSource = null;
            //Grid.DataSource = lista;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            CadastroItem form = new CadastroItem();
            form.ShowDialog();
        }

    }
}
