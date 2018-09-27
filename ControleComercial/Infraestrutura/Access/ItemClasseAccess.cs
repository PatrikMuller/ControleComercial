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
    public class ItemClasseAccess
    {

        public int Novo(ItemClasse o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public int Gravar(ItemClasse o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public ItemClasse Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<ItemClasse>(id);
            }
        }

        public void Remove(ItemClasse o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public void Delete(int Id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ItemClasse o = new ItemClasse();

                o.Id = Id;

                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<ItemClasse> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<ItemClasse>().OrderBy(o => o.Id).ToList();

            }
        }

        public Object Lista(int IdItem)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var lista = (from fpp in session.Query<ItemClasse>().
                             Where(o => o.Item.Id == IdItem).
                             Fetch(o => o.Classe).
                             Select(o => new { o.Id, Classe = o.Classe.Descricao }).
                             OrderBy(o => o.Classe).ToList()
                             select fpp).ToList();



                return lista;

            }
        }

    }
}
