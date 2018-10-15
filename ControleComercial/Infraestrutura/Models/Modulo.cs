using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class Modulo
    {

        public virtual int Id { get; set; }
        public virtual string Descricao { get; set; }
        public virtual string Classe { get; set; }

    }
}
