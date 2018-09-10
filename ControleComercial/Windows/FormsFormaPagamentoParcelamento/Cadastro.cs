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

        //Objetos
        FormaPagamento formaPagamento = new FormaPagamento();
        ParcelamentoStatus parcelamentoStatus = new ParcelamentoStatus();
        FormaPagamentoParcelamento formaPagamentoParcelamento = new FormaPagamentoParcelamento();

        //Access
        ParcelamentoStatusAccess parcelamentoStatusAccess = new ParcelamentoStatusAccess();
        FormaPagamentoParcelamentoAccess formaPagamentoParcelamentoAccess = new FormaPagamentoParcelamentoAccess();

        //Negocio
        Negocio.Utilitario ObjUtilitario = new Negocio.Utilitario();
        
        
        //Início - Métodos locais
        private void Ler()
        {   
            
            txtId.Text = Convert.ToString(formaPagamentoParcelamento.Id);
            txtQtdParcelas.Text = Convert.ToString(formaPagamentoParcelamento.QtdParcelas);
            txtJuros.Text = Convert.ToString(formaPagamentoParcelamento.Juros);
            cbStatus.SelectedValue = Convert.ToString(formaPagamentoParcelamento.ParcelamentoStatus.Id);
            
        }

        private void Gravar()
        {
            parcelamentoStatus.Id = Convert.ToInt32(cbStatus.SelectedValue);
            
            formaPagamentoParcelamento.Id = Convert.ToInt32(txtId.Text);
            formaPagamentoParcelamento.QtdParcelas = Convert.ToInt32(txtQtdParcelas.Text);
            formaPagamentoParcelamento.Juros = Convert.ToDouble(txtJuros.Text);
            formaPagamentoParcelamento.FormaPagamento = formaPagamento;
            formaPagamentoParcelamento.ParcelamentoStatus = parcelamentoStatus;
                                    
            formaPagamentoParcelamentoAccess.Gravar(formaPagamentoParcelamento);

            Close();
        }
                
        private String IdMaiorZero(Int32 Id)
        {
            formaPagamentoParcelamento = formaPagamentoParcelamentoAccess.Ler(Id);

            Ler();

            return Convert.ToString(Id);
        }

        private String IdZero()
        {
            txtQtdParcelas.Text = Convert.ToString(formaPagamentoParcelamentoAccess.RetornaUtimaQtdParcelas(formaPagamento.Id) + 1);
                        
            return "0";
        }
        //Fim - Métodos locais



        public Cadastro(Int32 Id, Int32 IdFormaPagamento)
        {

            InitializeComponent();

            ObjUtilitario.setComboBox(cbStatus, parcelamentoStatusAccess.ddl());
            formaPagamento.Id = IdFormaPagamento;

            txtId.Text = Id == 0 ? IdZero() : IdMaiorZero(Id);
            
        }

                
        private void btnGravar_Click(object sender, EventArgs e)
        {
            Gravar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtJuros_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtJuros.Text = ObjUtilitario.mascaraPorcentagem(txtJuros, e);
            txtJuros.SelectionStart = txtJuros.TextLength;
        }

    }
}
