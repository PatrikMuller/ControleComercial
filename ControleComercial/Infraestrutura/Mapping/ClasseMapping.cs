using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class ClasseMapping : ClassMap<Classe>
    {
        public ClasseMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Classe_Id_Seq");
            Map(o => o.Descricao);

        }
    }
}
