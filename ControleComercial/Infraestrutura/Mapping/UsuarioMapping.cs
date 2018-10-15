using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class UsuarioMapping : ClassMap<Usuario>
    {

        public UsuarioMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("Usuario_Id_Seq");
            References(o => o.Pessoa, "PessoaId").Cascade.All();
            Map(o => o.Login);
            Map(o => o.Senha);
            Map(o => o.TrocarSenhaProximoAcesso);

        }

    }
}
