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
    public partial class SelecionarFormaPagamento : Form
    {


        //Model
        FormaPagamentoParcelamento obj = new FormaPagamentoParcelamento();

        //
        FormaPagamentoParcelamentoAccess dao = new FormaPagamentoParcelamentoAccess();
        

        private DataTable dadosGrid(IList<FormaPagamentoParcelamento> l)
        {

            DataTable dt = new DataTable();

            dt.Columns.Add("id", System.Type.GetType("System.String"));
            dt.Columns.Add("forma", System.Type.GetType("System.String"));
            dt.Columns.Add("parcelas", System.Type.GetType("System.Decimal"));
            dt.Columns.Add("juros", System.Type.GetType("System.Decimal"));

            foreach (var o in l)
            {
                dt.Rows.Add(new String[] {  Convert.ToString(o.Id), Convert.ToString(o.FormaPagamento.Descricao), Convert.ToString(o.QtdParcelas), Convert.ToString(o.Juros) });
            }

            return dt;

        }

        private void configuraGrid()
        {

            //grid.Columns[1].Width = 200;
            //grid.Columns[2].DefaultCellStyle.Format = "###,###,###,##0.000";
            //grid.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }

        public DataGridViewRow Row()
        {

            return grid.CurrentRow;

        }


        public SelecionarFormaPagamento()
        {
            InitializeComponent();
        }

        private void ListaItem_Activated(object sender, EventArgs e)
        {

            //grid.DataSource = dadosGrid(dao.Lista(0));
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
