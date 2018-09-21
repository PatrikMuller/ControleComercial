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
    public class ItemEspecificacaoAccess
    {

        public int Novo(ItemEspecificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public int Gravar(ItemEspecificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public ItemEspecificacao Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<ItemEspecificacao>(id);
            }
        }
                
        public IList<ItemEspecificacao> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<ItemEspecificacao>().OrderBy(o => o.Id).ToList();

            }
        }

    }
}
