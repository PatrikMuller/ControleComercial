﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class PessoaFisica : Pessoa
    {
        public virtual string Cpf { get; set; }
        public virtual string Rg { get; set; }
        public virtual string NomePai { get; set; }
        public virtual string NomeMae { get; set; }
        public virtual string Sexo { get; set; }
        //public virtual string Matricula { get; set; }
        public virtual DateTime DataNascimento { get; set; }
    }
}
