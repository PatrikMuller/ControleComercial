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
    public class FormaPagamentoParcelamentoAccess
    {

        public Int32 Novo(FormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(FormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public FormaPagamentoParcelamento Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<FormaPagamentoParcelamento>(id);
            }
        }

        public void Remove(FormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<FormaPagamentoParcelamento> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                
                return session.Query<FormaPagamentoParcelamento>().Fetch(o => o.FormaPagamento).OrderBy(o => o.Id).ToList();

            }
        }
                
    }
}
