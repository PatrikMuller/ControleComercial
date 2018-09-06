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
    public class CarrinhoFormaPagamentoAccess
    {

        public Int32 Novo(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public CarrinhoFormaPagamento Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoFormaPagamento>(id);
            }
        }

        public void Remove(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<CarrinhoFormaPagamento> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<CarrinhoFormaPagamento>().OrderBy(o => o.Id).ToList();

            }
        }

    }
}
