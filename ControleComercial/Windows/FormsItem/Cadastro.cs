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
        ItemAccess access = new ItemAccess();


        //Início - Métodos locais
        private void Ler(Int32 Id)
        {

            obj = access.Ler(Id);

            txtId.Text = Convert.ToString(obj.Id);
            txtNome.Text = obj.Nome;
            txtQuantidade.Text = Convert.ToString(obj.Quantidade);
            txtPreco.Text = Convert.ToString(obj.Preco);
            txtDesconto.Text = Convert.ToString(obj.Desconto);

            //AtivaComponentes();
        }

        private void Gravar()
        {

            obj.Id = Convert.ToInt32(txtId.Text);
            obj.Nome = txtNome.Text;
            obj.Quantidade = Convert.ToDouble(txtQuantidade.Text);
            obj.Preco = Convert.ToDouble(txtPreco.Text);
            obj.Desconto = Convert.ToDouble(txtDesconto.Text);

            access.Gravar(obj);

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
    }
}

