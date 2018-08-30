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

namespace Windows.FormsFormaPagamento
{
    public partial class FormsCadastroFormaPagamento : Form
    {

        //Objetos
        FormaPagamento obj = new FormaPagamento();

        //Access
        FormaPagamentoAccess access = new FormaPagamentoAccess();
                

        //Início - Métodos locais
        private void Ler(Int32 Id)
        {

            obj = access.Ler(Id);

            txtId.Text = Convert.ToString(obj.Id);
            txtDescricao.Text = obj.Descricao;
            
            //AtivaComponentes();
        }

        private void DesativaComponentes()
        {

            //txtDescricao.Enabled = false;
            btnGravar.Enabled = false;

        }

        private void AtivaComponentes()
        {

            txtDescricao.Enabled = true;
            btnGravar.Enabled = true;

        }
                
        //Fim - Métodos locais



        public FormsCadastroFormaPagamento(Int32 Id)
        {

            InitializeComponent();

            Ler(Id);            

        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            //
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
                
    }
}
