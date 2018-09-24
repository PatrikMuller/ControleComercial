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

namespace Windows.FormsItemEspecificacao
{
    public partial class Cadastro : Form
    {
        //Access

        EspecificacaoAccess especificacaoAccess = new EspecificacaoAccess();
        EspecificacaoTipoAccess especificacaoTipoAccess = new EspecificacaoTipoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();

        public Cadastro()
        {

            InitializeComponent();
            ObjUtilitario.setComboBox(cbTipo, especificacaoTipoAccess.ddl());
            ObjUtilitario.setComboBox(cbEspecificacao, especificacaoAccess.ddl());

        }
    }
}
