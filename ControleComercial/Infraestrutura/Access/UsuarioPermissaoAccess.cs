using System.Collections.Generic;
using System.Linq;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;


namespace Infraestrutura.Access
{
    public class UsuarioPermissaoAccess
    {

        public int Novo(UsuarioPermissao obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public int Gravar(UsuarioPermissao obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public UsuarioPermissao Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<UsuarioPermissao>(id);
            }
        }

        public void Remove(UsuarioPermissao obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public IList<UsuarioPermissao> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<UsuarioPermissao>().OrderBy(o => o.Id).ToList();
            }
        }

    }
}
