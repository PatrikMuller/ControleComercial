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

namespace Windows.FormsItemClasse
{
    public partial class Cadastro : Form
    {

        //Access
        ClasseAccess classeAccess = new ClasseAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();

        public Cadastro()
        {
                        
            InitializeComponent();
            ObjUtilitario.setComboBox(cbClasse, classeAccess.ddl());

        }
    }
}
