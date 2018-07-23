using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class ItemMapping : ClassMap<Item>
    {
        public ItemMapping()
        {
            Id(o => o.Id).GeneratedBy.Sequence("Item_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            Map(o => o.Nome);
            Map(o => o.Quantidade);
            Map(o => o.Preco);
            Map(o => o.Desconto);
        }
    }
}
