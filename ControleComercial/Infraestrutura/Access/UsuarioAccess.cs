using System.Collections.Generic;
using System.Linq;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;


namespace Infraestrutura.Access
{
    public class UsuarioAccess
    {

        public int Novo(Usuario obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public int Gravar(Usuario obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public Usuario Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Usuario>(id);
            }
        }

        public void Remove(Usuario obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public IList<Usuario> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<Usuario>().OrderBy(o => o.Id).ToList();
            }
        }

    }
}
