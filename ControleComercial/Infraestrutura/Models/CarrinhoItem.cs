﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class CarrinhoItem
    {
        public virtual int Id { get; set; }
        public virtual int Ordem { get; set; }
        public virtual Carrinho Carrinho { get; set; }
        public virtual Item Item { get; set; }
        public virtual Double Quantidade { get; set; }
        public virtual Double Preco { get; set; }
        public virtual Double Desconto { get; set; }
    }
}
