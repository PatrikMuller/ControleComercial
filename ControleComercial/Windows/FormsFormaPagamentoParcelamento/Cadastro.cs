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

namespace Windows.FormsFormaPagamentoParcelamento
{
    public partial class Cadastro : Form
    {

        //Access
        ParcelamentoStatusAccess access = new ParcelamentoStatusAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();
        
        public Cadastro()
        {
            InitializeComponent();

            ObjUtilitario.setComboBox(cbStatus, access.ddl());
        }
    }
}
