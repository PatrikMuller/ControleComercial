//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class ModuloMapping : ClassMap<Modulo>
    {

        public ModuloMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Modulo_Id_Seq");
            Map(o => o.Descricao);
            Map(o => o.Classe);

        }

    }
}
