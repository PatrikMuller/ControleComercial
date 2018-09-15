using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class Carrinho
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataAbertura { get; set; }
        public virtual String UsuarioAbertura { get; set; }
        public virtual DateTime DataFechamento { get; set; }
        public virtual String UsuarioFechamento { get; set; }

    }
}
