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
    public class ItemAccess
    {
        public Int32 Novo(Item o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(Item o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Item Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Item>(id);
            }
        }

        public void Remove(Item o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<Item> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<Item>().OrderBy(C => C.Id).ToList();
            }
        }

        //public IList<Item> Lista(String Nome)
        //{
        //    using (ISession session = NHibernateHelper.AbreSessao())
        //    {
        //        return session.Query<Item>().
        //            Where(o => o.Nome.Like(Nome)).
        //            OrderBy(C => C.Id).ToList();
        //    }
        //}

        public Object Lista(String nome)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                
                var retorno = (from pf in session.Query<Item>().
                                    Where(o => o.Nome.Like(nome)).
                                    Fetch(o => o.UnidadeMedida).
                                    Select(o => new { o.Id, o.Nome, Medida = o.UnidadeMedida.Sigla, o.Quantidade, o.Preco, o.Desconto }).
                                    OrderBy(o => o.Nome).
                                    ToList()
                               select pf).Take(40).ToList();
                
                return retorno;

            }
        }

    }
}
