using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class Pessoa
    {

        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string CpfCnpj { get; set; }

    }
}
