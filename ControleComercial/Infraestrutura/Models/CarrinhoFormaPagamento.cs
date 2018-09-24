using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class CarrinhoFormaPagamento
    {

        public virtual int Id { get; set; }
        public virtual Carrinho Carrinho { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual double ValorPagar { get; set; }
        public virtual int QtdParcelas { get; set; }
        public virtual double Juros { get; set; }
        public virtual double ValorParcela { get; set; }

    }
}
