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
        public virtual string Nome { get; set; }
        public virtual Fabricante Fabricante { get; set; }
        public virtual UnidadeMedida UnidadeMedida { get; set; }
        public virtual double Quantidade { get; set; }
        public virtual double Preco { get; set; }
        public virtual double Desconto { get; set; }
    }
}