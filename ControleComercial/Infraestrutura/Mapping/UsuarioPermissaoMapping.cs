using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class UsuarioPermissaoMapping : ClassMap<UsuarioPermissao>
    {

        public UsuarioPermissaoMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("UsuarioPermissao_Id_Seq");
            References(o => o.Usuario, "UsuarioId");
            References(o => o.Modulo, "ModuloId");
            Map(o => o.Ativo);

        }

    }
}
