using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FluentNHibernate.Mapping;
using Infraestrutura.Models;

namespace Infraestrutura.Mapping
{
    class CarrinhoPessoaMapping : ClassMap<CarrinhoPessoa>
    {
        public CarrinhoPessoaMapping()
        {
            Id(o => o.Id).GeneratedBy.Sequence("CarrinhoPessoa_Id_Seq"); //Para Postgres
            //Id(carrinho => carrinho.Id).GeneratedBy.Identity(); //Para SQL Server
            References(o => o.Carrinho, "CarrinhoId");
            References(o => o.Pessoa, "PessoaId");
            References(o => o.CarrinhoPessoaTipo, "CarrinhoPessoaTipoId");
        }
    }
}
