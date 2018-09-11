using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class Item
    {
        public virtual int Id { get; set; }
        public virtual String Nome { get; set; }
        public virtual Double Quantidade { get; set; }
        public virtual Double Preco { get; set; }
        public virtual Double Desconto { get; set; }
    }
}