using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class FormaPagamentoMapping : ClassMap<FormaPagamento>
    {
        public FormaPagamentoMapping()
        {
            Id(o => o.Id).GeneratedBy.Sequence("FormaPagamento_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            Map(o => o.Descricao);
        }
    }
}
