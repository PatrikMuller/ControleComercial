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

namespace Windows.FormsItemClasse
{
    public partial class Cadastro : Form
    {
        //Objetos
        Item item = new Item();
        Classe classe = new Classe();
        ItemClasse itemClasse = new ItemClasse();

        //Access
        ClasseAccess classeAccess = new ClasseAccess();
        ItemClasseAccess itemClasseAccess = new ItemClasseAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();


        private void Gravar()
        {
            classe.Id = Convert.ToInt32(cbClasse.SelectedValue);
            
            itemClasse.Id = 0;
            itemClasse.Item = item;
            itemClasse.Classe = classe;

            itemClasseAccess.Gravar(itemClasse);

            Close();
        }


        public Cadastro(int IdItem)
        {
                        
            InitializeComponent();
            ObjUtilitario.setComboBox(cbClasse, classeAccess.ddl());
            item.Id = IdItem;

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Gravar();
        }

    }
}
