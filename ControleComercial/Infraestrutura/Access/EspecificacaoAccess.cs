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
    public class EspecificacaoAccess
    {

        public Int32 Novo(Especificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(Especificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Especificacao Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Especificacao>(id);
            }
        }

        public void Remove(Especificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<Especificacao> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<Especificacao>().OrderBy(o => o.Id).ToList();

            }
        }

        public List<ddl> ddl()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                var retorno = session.Query<Especificacao>().
                    OrderBy(o => o.Descricao).ToList();

                List<ddl> lista = new List<ddl>();

                foreach (var obj in retorno)
                {
                    ddl Objddl = new ddl();

                    Objddl.Id = Convert.ToString(obj.Id);
                    Objddl.Nome = obj.Descricao;

                    lista.Add(Objddl);
                }

                return lista;

            }
        }

    }
}
