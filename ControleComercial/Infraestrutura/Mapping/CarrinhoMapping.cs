using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class CarrinhoMapping : ClassMap<Carrinho>
    {
        public CarrinhoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Carrinho_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            Map(o => o.DataAbertura);
            Map(o => o.UsuarioAbertura);
            Map(o => o.DataFechamento);
            Map(o => o.UsuarioFechamento);

        }
    }
}