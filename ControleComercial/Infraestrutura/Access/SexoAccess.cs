using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infraestrutura.Models;

namespace Infraestrutura.Access
{
    public class SexoAccess
    {

        //método para listar no combobox
        public List<ddl> Lista()
        {

            List<ddl> lista = new List<ddl>();

            ddl ddlObj1 = new ddl();

            ddlObj1.Id = "F";
            ddlObj1.Nome = "FEMININO";

            lista.Add(ddlObj1);

            ddl ddlObj2 = new ddl();

            ddlObj2.Id = "M";
            ddlObj2.Nome = "MASCULINO";

            lista.Add(ddlObj2);

            return lista;
        }

    }
}
