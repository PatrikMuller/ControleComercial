using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    public class PessoaJuridicaMapping : SubclassMap<PessoaJuridica>
    {

        public PessoaJuridicaMapping()
        {
            
            Map(o => o.Ie);
            Map(o => o.Fantasia);
            Map(o => o.DataConstituicao);

        }
    }
}
