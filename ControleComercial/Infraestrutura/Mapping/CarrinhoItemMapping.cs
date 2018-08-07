using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class CarrinhoItemMapping : ClassMap<CarrinhoItem>
    {

        public CarrinhoItemMapping()
        {
            Id(o => o.Id).GeneratedBy.Sequence("CarrinhoItem_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            Map(o => o.Ordem);
            References(o => o.Carrinho, "CarrinhoId");
            References(o => o.Item, "ItemId");
            Map(o => o.Quantidade);
            Map(o => o.Preco);
            Map(o => o.Desconto);
        }

    }
}
