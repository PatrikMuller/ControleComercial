﻿using System;
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

namespace Windows.FormsFabricante
{
    public partial class Cadastro : Form
    {
        //Objetos
        Fabricante obj = new Fabricante();

        //Access
        FabricanteAccess access = new FabricanteAccess();


        //Início - Métodos locais
        private void Ler(Int32 Id)
        {

            obj = access.Ler(Id);

            txtId.Text = Convert.ToString(obj.Id);
            txtDescricao.Text = obj.Descricao;

        }

        private void Gravar()
        {
            obj.Id = Convert.ToInt32(txtId.Text);
            obj.Descricao = txtDescricao.Text;

            access.Gravar(obj);

            Close();
        }
        //Fim - Métodos locais



        public Cadastro(Int32 Id)
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
    }
}
