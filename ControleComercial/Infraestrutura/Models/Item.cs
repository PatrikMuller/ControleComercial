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
        public virtual Decimal Quantidade { get; set; }
        public virtual Decimal Preco { get; set; }
        public virtual Decimal Desconto { get; set; }
    }
}