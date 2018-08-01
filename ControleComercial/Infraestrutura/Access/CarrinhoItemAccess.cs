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
    public class CarrinhoItemAccess
    {

        public Int32 Novo(CarrinhoItem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public Int32 Gravar(CarrinhoItem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public CarrinhoItem Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoItem>(id);
            }
        }

        public void Remove(CarrinhoItem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public IList<Object> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //string hql = "select p from Carrinho p";
                //IQuery query = session.CreateQuery(hql);
                //return query.List<Carrinho>();
                //return session.Get<Carrinho>;

                //return session.Query<Bem>().Fetch(b => b.Marca).Fetch(b => b.Modelo).OrderBy(b => b.IdBem).ToList();

                var results = from query in session.Query<CarrinhoItem>().
                              Fetch(c => c.Carrinho).
                              Fetch(i => i.Item).OrderBy(ci => ci.Id).ToList()
                              select(new
                              {
                                  query.Id,
                                  //query.Carrinho.Id as idcar,
                                  //query.Item.Id as iditem,
                                  query.Quantidade,
                                  query.Preco
                              });

                return results.ToList<Object>();

                //return session.Query<CarrinhoItem>().Fetch(b => b.Marca) Select(C => new CarrinhoItem { Id, C.Carrinho.Id, }).OrderBy(C => C.Id).ToList();
            }
        }

    }
}
