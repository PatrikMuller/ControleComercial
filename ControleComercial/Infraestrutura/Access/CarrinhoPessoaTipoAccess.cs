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
    public class CarrinhoPessoaTipoAccess
    {

        public Int32 Novo(CarrinhoPessoaTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(CarrinhoPessoaTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public CarrinhoPessoaTipo Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoPessoaTipo>(id);
            }
        }

        public void Remove(CarrinhoPessoaTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<CarrinhoPessoaTipo> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<CarrinhoPessoaTipo>().OrderBy(o => o.Id).ToList();

            }
        }

    }
}
