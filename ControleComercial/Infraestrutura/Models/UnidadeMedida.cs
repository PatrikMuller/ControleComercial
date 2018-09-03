using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class UnidadeMedida
    {

        public virtual int Id { get; set; }
        public virtual String Descricao { get; set; }
        public virtual String Sigla { get; set; }

    }
}
