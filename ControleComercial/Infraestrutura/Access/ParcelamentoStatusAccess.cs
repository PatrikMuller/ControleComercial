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
    public class ParcelamentoStatusAccess
    {

        public Int32 Novo(ParcelamentoStatus o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(ParcelamentoStatus o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public ParcelamentoStatus Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<ParcelamentoStatus>(id);
            }
        }

        public IList<ParcelamentoStatus> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<ParcelamentoStatus>().OrderBy(o => o.Id).ToList();

            }
        }

        public Object Lista(Int32 IdFormaPagamento)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var lista = (from fpp in session.Query<ParcelamentoStatus>().
                             //Where(o => o.FormaPagamento.Id == IdFormaPagamento).
                             //Select(o => new { o.Id, o.QtdParcelas, o.Juros, Status = o.ParcelamentoStatus.Descricao }).
                             OrderBy(o => o.Id).ToList()
                             select fpp).ToList();



                return lista;

            }
        }

        public List<ddl> ddl()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                var retorno = session.Query<ParcelamentoStatus>().OrderBy(o => o.Id).ToList();

                List<ddl> lista = new List<ddl>();

                foreach (var obj in retorno)
                {
                    ddl Objddl = new ddl();

                    Objddl.Id = Convert.ToString(obj.Id);
                    Objddl.Nome = Convert.ToString(obj.Descricao);

                    lista.Add(Objddl);
                }

                return lista;

            }
        }

    }
}
