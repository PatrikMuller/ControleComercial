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

namespace Windows.FormsPessoaFisica
{
    public partial class FormListaPessoaFisica : Form
    {

        //negocio
        //BLLPessoaFisica ObjNegocioPessoaFisica = new BLLPessoaFisica();
        //Utilitario ObjUtilitario = new Utilitario();


        //Objetos
        Pessoa pessoa = new Pessoa();
        
        //Access
        PessoaAccess pessoaAccess = new PessoaAccess();
        
        

        //Início - Métodos locais
        private void configuraGrid()
        {
            Grid.Columns[0].Width = 80;
            Grid.Columns[1].Width = 220;
            Grid.Columns[2].Width = 100;
            Grid.Columns[3].Width = 120;
        }

        private void configuraBotoes()
        {
            if (Grid.RowCount == 0)
            {
                MenuItemEditar.Enabled = false;
                MenuButtonEditar.Enabled = false;
            }
            else
            {
                MenuItemEditar.Enabled = true;
                MenuButtonEditar.Enabled = true;
            }
        }

        private void setarGrid()
        {
            Grid.DataSource = pessoaAccess.Lista("%" + txtLocalizar.Text + "%");
            //lista = ObjNegocioPessoaFisica.Lista(txtLocalizar.Text);
            //ObjUtilitario.setGridView(Grid, lista);
            //configuraGrid();
            //configuraBotoes();
        }

        private void Editar()
        {
            //Int32 id = Convert.ToInt32(Grid.CurrentRow.Cells[0].Value);
            //CadastroPessoaFisica Form = new CadastroPessoaFisica(id);
            //Form.ShowDialog();
        }

        private void Novo()
        {
            //CadastroPessoaFisica Form = new CadastroPessoaFisica(0);
            //Form.ShowDialog();
            FormCadastroPessoaFisica form = new FormCadastroPessoaFisica();
            form.ShowDialog();
        }
        //Fim - Métodos locais

        
        
        public FormListaPessoaFisica()
        {
            InitializeComponent();
            setarGrid();
            txtLocalizar.Focus();
        }


        private void FormListaPessoaFisica_Activated(object sender, EventArgs e)
        {
            setarGrid();
        }
                
        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {
            setarGrid();
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void MenuItemNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void MenuItemEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void MenuItemFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MenuButtonNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void MenuButtonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

    }
}
