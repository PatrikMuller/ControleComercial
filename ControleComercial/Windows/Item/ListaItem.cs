using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows.Item
{
    public partial class ListaItem : Form
    {
        public ListaItem()
        {
            InitializeComponent();
        }

        private void ListaItem_Activated(object sender, EventArgs e)
        {
            Infraestrutura.Models.Item item = new Infraestrutura.Models.Item();
            Infraestrutura.Access.ItemAccess itemAccess = new Infraestrutura.Access.ItemAccess();

            grid.DataSource = null;
            grid.DataSource = itemAccess.Lista();

            //Grid.DataSource = null;
            //Grid.DataSource = lista;

        }
    }
}
