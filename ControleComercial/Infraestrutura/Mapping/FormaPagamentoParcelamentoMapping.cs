using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class FormaPagamentoParcelamentoMapping : ClassMap<FormaPagamentoParcelamento>
    {
        public FormaPagamentoParcelamentoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("FormaPagamentoParcelamento_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            References(o => o.FormaPagamento, "FormaPagamentoId");
            Map(o => o.QtdParcelas);
            Map(o => o.Juros);
            References(o => o.ParcelamentoStatus, "ParcelamentoStatusId");

        }
    }
}
