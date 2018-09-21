using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura.Models
{
    public class ItemClasse
    {

        public virtual int Id { get; set; }
        public Item Item { get; set; }
        public Classe Classe { get; set; }

    }
}
