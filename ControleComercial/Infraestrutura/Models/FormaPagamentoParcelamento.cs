﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class FormaPagamentoParcelamento
    {

        public virtual int Id { get; set; }
        public virtual FormaPagamento FormaPagamento { get; set; }
        public virtual int QtdParcelas { get; set; }
        public virtual Decimal Juros { get; set; }
        
    }
}