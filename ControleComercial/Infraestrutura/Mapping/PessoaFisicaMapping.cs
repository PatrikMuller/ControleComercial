using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class PessoaFisicaMapping : ClassMap<PessoaFisica> //SubclassMap<PessoaFisica>
    {

        public PessoaFisicaMapping()
        {

            Id(o => o.Id).GeneratedBy.Sequence("PessoaFisica_Id_Seq"); //Para Postgres
            //Id(pessoa => pessoa.IdPessoa).GeneratedBy.Identity(); //Para SQL Server
            //References(o => o.Pessoa, "PessoaId").Cascade.All();
            References(o => o.Pessoa, "PessoaId").Cascade.All();
            Map(o => o.Rg);
            Map(o => o.NomePai);
            Map(o => o.NomeMae);
            Map(o => o.Sexo);
            //Map(o => o.Matricula);
            Map(o => o.DataNascimento);
            //Map(obj => obj.DataNascimento);
            //Map(obj => obj.IdMunicipioNascimento);

        }

    }
}
