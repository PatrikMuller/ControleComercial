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
        FabricanteAccess fabricanteAccess = new FabricanteAccess();
        UnidadeMedidaAccess unidadeMedidaAccess = new UnidadeMedidaAccess();
        ItemClasseAccess itemClasseAccess = new ItemClasseAccess();
        ItemEspecificacaoAccess itemEspecificacaoAccess = new ItemEspecificacaoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();

                
        //Início - Métodos locais
        private void Ler(int Id)
        {

            obj = itemAccess.Ler(Id);

            if (obj != null)
            {
                txtId.Text = Convert.ToString(obj.Id);
                txtNome.Text = obj.Nome;
                cbFabricante.SelectedValue = obj.Fabricante == null ? "1" : Convert.ToString(obj.Fabricante.Id);
                cbUnidadeMedida.SelectedValue = obj.UnidadeMedida == null ? "1" : Convert.ToString(obj.UnidadeMedida.Id);
                txtQuantidade.Text = ObjUtilitario.lerQuantidade(obj.Quantidade);
                txtPreco.Text = ObjUtilitario.lerPreco(obj.Preco);
                txtDesconto.Text = ObjUtilitario.lerPorcentagem(obj.Desconto);

                SetaGridClasse();
                SetaGridEspecificacao();
            }

        }

        private void Gravar()
        {
            Fabricante fabricante = new Fabricante();
            fabricante.Id = Convert.ToInt32(cbFabricante.SelectedValue);

            UnidadeMedida unidadeMedida = new UnidadeMedida();
            unidadeMedida.Id = Convert.ToInt32(cbUnidadeMedida.SelectedValue);

            obj.Id = Convert.ToInt32(txtId.Text);
            obj.Nome = txtNome.Text;
            obj.Fabricante = fabricante;
            obj.UnidadeMedida = unidadeMedida;
            obj.Quantidade = Convert.ToDouble(txtQuantidade.Text);
            obj.Preco = Convert.ToDouble(txtPreco.Text);
            obj.Desconto = Convert.ToDouble(txtDesconto.Text);

            txtId.Text = (txtId.Text == "0") ? Convert.ToString(itemAccess.Novo(obj)) : Convert.ToString(itemAccess.Gravar(obj));

            lblGravar.Text = "Registro gravado com sucesso!";

            ConfiguraCampos();
        }

        private bool idMaiorZero()
        {
            return txtId.Text == "0" ? false : true;
        }

        private void SetaGridClasse()
        {
            gridClasse.DataSource = itemClasseAccess.Lista(obj.Id);
        }

        private void SetaGridEspecificacao()
        {
            gridEspecificacao.DataSource = itemEspecificacaoAccess.Lista(obj.Id);
        }
                
        private bool GridClasseCount()
        {
            return gridClasse.RowCount > 0 ? true : false;
        }

        private bool GridEspecificacaoCount()
        {
            return gridEspecificacao.RowCount > 0 ? true : false;
        }

        private void ConfiguraCampos()
        {

            tsClasse.Enabled = idMaiorZero();
            tsEspecificacao.Enabled = idMaiorZero();

            MenuButtonDeletarClasse.Enabled = GridClasseCount();
            MenuButtonDeletarEspecificacao.Enabled = GridEspecificacaoCount();

        }               
        //Fim - Métodos locais



        public Cadastro(int Id)
        {

            InitializeComponent();
            ObjUtilitario.setComboBox(cbFabricante, fabricanteAccess.ddl());
            ObjUtilitario.setComboBox(cbUnidadeMedida, unidadeMedidaAccess.ddl());

            if (Id > 0)
            {
                Ler(Id);
            }

            ConfiguraCampos();

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
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


        private void MenuButtonNovoClasse_Click(object sender, EventArgs e)
        {
            FormsItemClasse.Cadastro form = new FormsItemClasse.Cadastro(obj.Id);
            form.ShowDialog();
            SetaGridClasse();
            ConfiguraCampos();
        }

        private void MenuButtonDeletarClasse_Click(object sender, EventArgs e)
        {
            itemClasseAccess.Delete(Convert.ToInt32(gridClasse.CurrentRow.Cells[0].Value));
            SetaGridClasse();
            ConfiguraCampos();
            lblGravar.Text = "Classe deletada com sucesso!";
        }

        private void MenuButtonNovaEspecificacao_Click(object sender, EventArgs e)
        {
            FormsItemEspecificacao.Cadastro form = new FormsItemEspecificacao.Cadastro(obj.Id);
            form.ShowDialog();
            SetaGridEspecificacao();
            ConfiguraCampos();
        }
                
        private void MenuButtonDeletarEspecificacao_Click(object sender, EventArgs e)
        {
            itemEspecificacaoAccess.Delete(Convert.ToInt32(gridEspecificacao.CurrentRow.Cells[0].Value));
            SetaGridEspecificacao();
            ConfiguraCampos();
            lblGravar.Text = "Especificação deletada com sucesso!";
        }
    }
}

