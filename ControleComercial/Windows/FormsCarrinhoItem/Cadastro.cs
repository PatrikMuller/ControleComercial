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

namespace Windows.FormsCarrinhoItem
{
    public partial class Cadastro : Form
    {

        //Objetos
        Item item = new Item();
        Carrinho carrinho = new Carrinho();
        CarrinhoItem carrinhoItem = new CarrinhoItem();


        //Access
        ItemAccess itemAccess = new ItemAccess();
        CarrinhoItemAccess carrinhoItemAccess = new CarrinhoItemAccess();



        //Início - Métodos locais
        private void configuraGrid()
        {

            Grid.Columns[1].Width = 220;
            Grid.Columns[3].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";
            Grid.Columns[4].DefaultCellStyle.Format = "R$ ###,###,###,##0.00";

        }

        private void setarGrid()
        {

            Grid.DataSource = itemAccess.Lista("%" + txtLocalizar.Text + "%");
            configuraGrid();
        }

        private void Inserir(Int32 IdItem)
        {
            item = itemAccess.Ler(IdItem);
            
            carrinhoItem.Carrinho = carrinho;           
            carrinhoItem.Item = item;
            carrinhoItem.Preco = item.Preco;
            carrinhoItem.Desconto = Convert.ToDouble(0.00);

            carrinhoItemAccess.Gravar(carrinhoItem);
        }    
        //Fim - Métodos locais



        public Cadastro(Int32 IdCarrrinho, Int32 TotalItem, Double Quantidade)
        {

            carrinho.Id = IdCarrrinho;
            carrinhoItem.Ordem = TotalItem + 1;
            carrinhoItem.Quantidade = Quantidade;

            InitializeComponent();
            setarGrid();
            txtLocalizar.Focus();

        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            setarGrid();
        }
        
        private void Cadastro_Activated(object sender, EventArgs e)
        {
            setarGrid();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Inserir(Convert.ToInt32(Grid.CurrentRow.Cells[0].Value));
        }

    }
}
