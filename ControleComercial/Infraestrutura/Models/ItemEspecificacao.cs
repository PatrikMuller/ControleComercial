using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class ItemEspecificacao
    {

        public virtual int Id { get; set; }
        public Item Item { get; set; }
        public EspecificacaoTipo EspecificacaoTipo { get; set; }
        public Especificacao Especificacao { get; set; }
        
    }
}
