using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class PessoaFisicaMapping : SubclassMap<PessoaFisica>
    {

        public PessoaFisicaMapping()
        {
            Map(o => o.Cpf);
            Map(o => o.Rg);
            Map(o => o.NomePai);
            Map(o => o.NomeMae);
            Map(o => o.Sexo);
            Map(o => o.DataNascimento);
            //Map(obj => obj.DataNascimento);
            //Map(obj => obj.IdMunicipioNascimento);
        }

    }
}
