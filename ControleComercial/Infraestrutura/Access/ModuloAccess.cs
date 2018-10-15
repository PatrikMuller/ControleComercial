using System.Collections.Generic;
using System.Linq;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;


namespace Infraestrutura.Access
{
    public class ModuloAccess
    {

        public int Novo(Modulo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public int Gravar(Modulo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public Modulo Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Modulo>(id);
            }
        }

        public void Remove(Modulo obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public IList<Modulo> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<Modulo>().OrderBy(o => o.Id).ToList();
            }
        }

    }
}
