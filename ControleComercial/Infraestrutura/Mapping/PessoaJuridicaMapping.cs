using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class PessoaJuridicaMapping : ClassMap<PessoaJuridica> //SubclassMap<PessoaJuridica>
    {

        public PessoaJuridicaMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("PessoaJuridica_Id_Seq"); //Para Postgres
            //Id(pessoa => pessoa.IdPessoa).GeneratedBy.Identity(); //Para SQL Server
            References(o => o.Pessoa, "PessoaId").Cascade.All();
            Map(o => o.Ie);
            Map(o => o.Fantasia);
            Map(o => o.DataConstituicao);

        }
    }
}
