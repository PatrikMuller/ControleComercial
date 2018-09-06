using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class CarrinhoFormaPagamentoMapping : ClassMap<CarrinhoFormaPagamento>
    {

        public CarrinhoFormaPagamentoMapping()
        {
            Id(o => o.Id).GeneratedBy.Sequence("CarrinhoFormaPagamento_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            References(o => o.Carrinho, "CarrinhoId");
            References(o => o.FormaPagamento, "FormaPagamentoId");
            Map(o => o.ValorPagar);
            Map(o => o.QtdParcelas);
            Map(o => o.Juros);
            Map(o => o.ValorParcela);

        }
        
    }
}
