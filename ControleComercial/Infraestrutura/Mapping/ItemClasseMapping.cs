using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class ItemClasseMapping : ClassMap<ItemClasse>
    {
        public ItemClasseMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("ItemClasse_Id_Seq");
            References(o => o.Item, "ItemId");
            References(o => o.Classe, "ClasseId");

        }
    }
}
