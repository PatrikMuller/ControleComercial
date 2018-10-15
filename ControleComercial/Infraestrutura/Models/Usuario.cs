using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class Usuario
    {

        public virtual int Id { get; set; }
        public virtual Pessoa Pessoa { get; set; }
        public virtual string Login { get; set; }
        public virtual string Senha { get; set; }
        public virtual bool TrocarSenhaProximoAcesso { get; set; }
        
    }
}
