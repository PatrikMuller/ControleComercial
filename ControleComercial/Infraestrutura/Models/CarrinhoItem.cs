using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class CarrinhoItem
    {
        public virtual int Id { get; set; }
        public virtual Carrinho Carrinho { get; set; }
        public virtual Item Item { get; set; }
        public virtual Decimal Quantidade { get; set; }
        public virtual Decimal Preco { get; set; }
        public virtual Decimal Desconto { get; set; }
    }
}
