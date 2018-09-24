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
    public partial class Cadastro : Form
    {
        //Objetos
        Item obj = new Item();

        //Access
        ItemAccess itemAccess = new ItemAccess();
        UnidadeMedidaAccess unidadeMedidaAccess = new UnidadeMedidaAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


        //Início - Métodos locais
        private void Ler(Int32 Id)
        {

            obj = itemAccess.Ler(Id);

            txtId.Text = Convert.ToString(obj.Id);
            txtNome.Text = obj.Nome;
            cbUnidadeMedida.SelectedValue = obj.UnidadeMedida == null ? "1" : Convert.ToString(obj.UnidadeMedida.Id);
            txtQuantidade.Text = ObjUtilitario.lerQuantidade(obj.Quantidade);
            txtPreco.Text = ObjUtilitario.lerPreco(obj.Preco);
            txtDesconto.Text = ObjUtilitario.lerPorcentagem(obj.Desconto);

            //AtivaComponentes();
        }

        private void Gravar()
        {
            UnidadeMedida unidadeMedida = new UnidadeMedida();
            unidadeMedida.Id = Convert.ToInt32(cbUnidadeMedida.SelectedValue);

            obj.Id = Convert.ToInt32(txtId.Text);
            obj.Nome = txtNome.Text;
            obj.UnidadeMedida = unidadeMedida;
            obj.Quantidade = Convert.ToDouble(txtQuantidade.Text);
            obj.Preco = Convert.ToDouble(txtPreco.Text);
            obj.Desconto = Convert.ToDouble(txtDesconto.Text);

            itemAccess.Gravar(obj);

            Close();

        }

        private void DesativaComponentes()
        {

            //txtDescricao.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtNome.Enabled = true;
            btnGravar.Enabled = true;

        }

        //Fim - Métodos locais



        public Cadastro(int Id)
        {

            InitializeComponent();
            ObjUtilitario.setComboBox(cbUnidadeMedida, unidadeMedidaAccess.ddl());

            if (Id > 0)
            {
                Ler(Id);
            }


        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
                
        private void MenuButtonNovoClasse_Click(object sender, EventArgs e)
        {
            FormsItemClasse.Cadastro form = new FormsItemClasse.Cadastro();
            form.ShowDialog();
        }

        private void MenuButtonEditarClasse_Click(object sender, EventArgs e)
        {
            FormsItemClasse.Cadastro form = new FormsItemClasse.Cadastro();
            form.ShowDialog();
        }

        private void MenuButtonNovaEspecificacao_Click(object sender, EventArgs e)
        {
            FormsItemEspecificacao.Cadastro form = new FormsItemEspecificacao.Cadastro();
            form.ShowDialog();
        }

        private void MenuButtonEditarEspecificacao_Click(object sender, EventArgs e)
        {
            FormsItemEspecificacao.Cadastro form = new FormsItemEspecificacao.Cadastro();
            form.ShowDialog();
        }



        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtQuantidade.Text = ObjUtilitario.mascaraQuantidade(txtQuantidade, e); //Mudar a Mascara
            txtQuantidade.SelectionStart = txtQuantidade.TextLength;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtPreco.Text = ObjUtilitario.mascaraMoney(txtPreco, e); //Mudar a Mascara
            txtPreco.SelectionStart = txtPreco.TextLength;
        }

        private void txtDesconto_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtDesconto.Text = ObjUtilitario.mascaraPorcentagem(txtDesconto, e);
            txtDesconto.SelectionStart = txtDesconto.TextLength;
        }
    }
}

