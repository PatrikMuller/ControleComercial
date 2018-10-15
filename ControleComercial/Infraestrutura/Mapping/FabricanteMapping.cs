//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping 
{
    class FabricanteMapping : ClassMap<Fabricante>
    {
        public FabricanteMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Fabricante_Id_Seq");
            Map(o => o.Descricao);

        }
    }
}
