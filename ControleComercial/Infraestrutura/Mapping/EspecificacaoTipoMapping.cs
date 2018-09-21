﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class EspecificacaoTipoMapping : ClassMap<EspecificacaoTipo>
    {
        public EspecificacaoTipoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("EspecificacaoTipo_Id_Seq");
            Map(o => o.Descricao);

        }
    }
}
