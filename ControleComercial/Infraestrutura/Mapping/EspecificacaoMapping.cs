﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class EspecificacaoMapping : ClassMap<Especificacao>
    {
        public EspecificacaoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Especificacao_Id_Seq");
            Map(o => o.Descricao);

        }
    }
}
