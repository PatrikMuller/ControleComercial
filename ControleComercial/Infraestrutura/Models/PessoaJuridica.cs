using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class PessoaJuridica
    {

        public virtual int Id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual string Ie { get; set; }
        public virtual string Fantasia { get; set; }
        public virtual DateTime DataConstituicao { get; set; }

    }
}
