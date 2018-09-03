using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class UnidadeMedidaMapping : ClassMap<UnidadeMedida>
    {

        public UnidadeMedidaMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("UnidadeMedida_Id_Seq");
            Map(o => o.Descricao);
            Map(o => o.Sigla);

        }

    }
}
