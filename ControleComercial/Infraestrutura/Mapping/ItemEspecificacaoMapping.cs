using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class ItemEspecificacaoMapping : ClassMap<ItemEspecificacao>
    {
        public ItemEspecificacaoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("ItemEspecificacao_Id_Seq");
            References(o => o.Item, "ItemId");
            References(o => o.EspecificacaoTipo, "EspecificacaoTipoId");
            References(o => o.Especificacao, "EspecificacaoId");

        }
    }
}
