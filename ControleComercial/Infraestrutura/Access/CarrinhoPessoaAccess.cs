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
    public class CarrinhoPessoaAccess
    {

        public Int32 Novo(CarrinhoPessoa o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public void Gravar(CarrinhoPessoa o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
            }
        }

        public CarrinhoPessoa Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoPessoa>(id);
            }
        }

        public CarrinhoPessoa Ler(Int32 idCarrinho, Int32 carrinhoPessoaTipo_Id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<CarrinhoPessoa>().
                    Fetch(o => o.Pessoa).
                    Fetch(o => o.CarrinhoPessoaTipo).
                    Where(o => o.Carrinho.Id == idCarrinho && o.CarrinhoPessoaTipo.Id == carrinhoPessoaTipo_Id).
                    FirstOrDefault();
            }
        }

        public void Remove(CarrinhoPessoa o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<CarrinhoPessoa> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //string hql = "select p from Carrinho p";
                //IQuery query = session.CreateQuery(hql);
                //return query.List<Carrinho>();
                //return session.Get<Carrinho>;

                //return session.Query<Bem>().Fetch(b => b.Marca).Fetch(b => b.Modelo).OrderBy(b => b.IdBem).ToList();

                return session.Query<CarrinhoPessoa>().Fetch(o => o.Pessoa).Fetch(o => o.CarrinhoPessoaTipo).OrderBy(o => o.Id).ToList();
            }
        }

        public IList<CarrinhoPessoa> Lista(Int32 idCarrinho, int carrinhoPessoaTipo_Id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<CarrinhoPessoa>().
                    Fetch(o => o.Pessoa).
                    Fetch(o => o.CarrinhoPessoaTipo).
                    Where(o => o.Carrinho.Id == idCarrinho && o.CarrinhoPessoaTipo.Id == carrinhoPessoaTipo_Id).
                    OrderBy(o => o.Id).ToList();

            }

        }
    }
}
