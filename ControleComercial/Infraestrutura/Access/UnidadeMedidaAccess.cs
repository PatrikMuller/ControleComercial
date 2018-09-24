using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;
using NHibernate.Linq;

namespace Infraestrutura.Access
{
    public class UnidadeMedidaAccess
    {

        public Int32 Novo(UnidadeMedida o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(UnidadeMedida o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public UnidadeMedida Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<UnidadeMedida>(id);
            }
        }

        public void Remove(UnidadeMedida o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<UnidadeMedida> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<UnidadeMedida>().OrderBy(o => o.Id).ToList();

            }
        }

        public List<ddl> ddl()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                var retorno = session.Query<UnidadeMedida>().
                    OrderBy(o => o.Descricao).ToList();

                List<ddl> lista = new List<ddl>();

                foreach (var obj in retorno)
                {
                    ddl Objddl = new ddl();

                    Objddl.Id = Convert.ToString(obj.Id);
                    Objddl.Nome = Convert.ToString(obj.Sigla) + " - " + obj.Descricao;

                    lista.Add(Objddl);
                }

                return lista;

            }
        }


    }
}
