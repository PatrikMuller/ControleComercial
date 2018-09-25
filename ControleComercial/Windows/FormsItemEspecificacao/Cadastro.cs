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

namespace Windows.FormsItemEspecificacao
{
    public partial class Cadastro : Form
    {
        //Objetos
        Item item = new Item();
        EspecificacaoTipo tipo = new EspecificacaoTipo();
        Especificacao especificacao = new Especificacao();
        ItemEspecificacao itemEspecificacao = new ItemEspecificacao();
                
        //Access
        EspecificacaoAccess especificacaoAccess = new EspecificacaoAccess();
        EspecificacaoTipoAccess especificacaoTipoAccess = new EspecificacaoTipoAccess();
        ItemEspecificacaoAccess itemEspecificacaoAccess = new ItemEspecificacaoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();

        private void Gravar()
        {
            tipo.Id = Convert.ToInt32(cbTipo.SelectedValue);
            especificacao.Id = Convert.ToInt32(cbEspecificacao.SelectedValue);

            itemEspecificacao.Id = 0;
            itemEspecificacao.Item = item;
            itemEspecificacao.EspecificacaoTipo = tipo;
            itemEspecificacao.Especificacao = especificacao;

            itemEspecificacaoAccess.Gravar(itemEspecificacao);

            Close();
        }

        public Cadastro(int IdItem)
        {

            InitializeComponent();
            ObjUtilitario.setComboBox(cbTipo, especificacaoTipoAccess.ddl());
            ObjUtilitario.setComboBox(cbEspecificacao, especificacaoAccess.ddl());
            item.Id = IdItem;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Gravar();
        }

    }
}
