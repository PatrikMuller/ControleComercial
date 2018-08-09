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
    public class CarrinhoFormaPagamentoParcelamentoAccess
    {
        public Int32 Novo(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public CarrinhoFormaPagamentoParcelamento Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoFormaPagamentoParcelamento>(id);
            }
        }

        public void Remove(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        //public IList<CarrinhoFormaPagamentoParcelamento> Lista(int idCarrinho)
        public IList<CarrinhoFormaPagamentoParcelamento> Lista(int idCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                                
                return session.Query<CarrinhoFormaPagamentoParcelamento>().
                    Fetch(o => o.Carrinho).
                    Where(o => o.Carrinho.Id == idCarrinho).
                    Fetch(o => o.FormaPagamentoParcelamento).
                    Fetch(o => o.FormaPagamento).
                    OrderBy(o => o.Id).ToList();

                
            }
        }
    }
}
