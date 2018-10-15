using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class UsuarioPermissao
    {

        public virtual int Id { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Modulo Modulo { get; set; }
        public virtual bool Ativo { get; set; }

    }
}
