using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class CarrinhoFormaPagamentoParcelamentoMapping : ClassMap<CarrinhoFormaPagamentoParcelamento>
    {

        public CarrinhoFormaPagamentoParcelamentoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("CarrinhoFormaPagamentoParcelamento_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            References(o => o.Carrinho, "CarrinhoId");
            References(o => o.FormaPagamento, "FormaPagamentoId");
            References(o => o.FormaPagamentoParcelamento, "FormaPagamentoParcelamentoId");
            Map(o => o.QtdParcelas);
            Map(o => o.Juros);
            
        }

    }
}
