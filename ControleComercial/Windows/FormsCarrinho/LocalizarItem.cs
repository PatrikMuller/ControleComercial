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
    public partial class LocalizarItem : Form
    {

        //Model
        Item item = new Item();

        //
        ItemAccess itemAccess = new ItemAccess();


        private DataTable dadosGrid(IList<Item> l)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("id", System.Type.GetType("System.String"));
            dt.Columns.Add("produto", System.Type.GetType("System.String"));
            dt.Columns.Add("qtd", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("preço", System.Type.GetType("System.Decimal"));
            
            foreach (var item in l)
            {
                dt.Rows.Add(new String[] { Convert.ToString(item.Id), item.Nome, Convert.ToString(item.Quantidade), Convert.ToString(item.Preco) });
            }

            return dt;

        }

        private void configuraGrid()
        {

            grid.Columns[1].Width = 200;
            grid.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.000";
            grid.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }

        public DataGridViewRow Row()
        {

            return grid.CurrentRow;

        }
        
        public LocalizarItem()
        {

            InitializeComponent();

        }
                
        private void ListaItem_Activated(object sender, EventArgs e)
        {

            grid.DataSource = dadosGrid(itemAccess.Lista());
            configuraGrid();

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            if (grid.CurrentRow != null)
            {
                this.DialogResult = DialogResult.OK;
            }

        }

    }
}
