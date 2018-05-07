﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class PessoaJuridica : Pessoa
    {
        public virtual string Cnpj { get; set; }
        public virtual string Ie { get; set; }
        public virtual string Fantasia { get; set; }
        public virtual DateTime DataConstituicao { get; set; }
    }
}
