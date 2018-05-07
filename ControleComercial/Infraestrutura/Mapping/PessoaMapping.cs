using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class PessoaMapping : ClassMap<Pessoa>
    {

        public PessoaMapping()
        {
            //Id(pessoa => pessoa.IdPessoa).GeneratedBy.Sequence("Pessoa_IdPessoa_Seq"); //Para Postgres
            Id(pessoa => pessoa.IdPessoa).GeneratedBy.Identity(); //Para SQL Server
            Map(pessoa => pessoa.Nome);
        }

    }
}
