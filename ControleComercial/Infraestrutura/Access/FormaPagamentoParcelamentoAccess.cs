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

        public void Gravar(FormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
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

        public Object Lista(Int32 IdFormaPagamento)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                
                var lista = (from fpp in session.Query<FormaPagamentoParcelamento>().
                             Where(o => o.FormaPagamento.Id == IdFormaPagamento).
                             Select(o => new { o.Id, o.QtdParcelas, o.Juros, Status = o.ParcelamentoStatus.Descricao}).
                             OrderBy(o => o.Id).ToList()
                             select fpp).ToList();



                return lista;
                                
            }
        }

        public List<ddl> ddl(Int32 IdFormaPagamento)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                var retorno = session.Query<FormaPagamentoParcelamento>().Where(o => o.FormaPagamento.Id == IdFormaPagamento).OrderBy(o => o.Id).ToList();

                List<ddl> lista = new List<ddl>();

                foreach (var obj in retorno)
                {
                    ddl Objddl = new ddl();

                    Objddl.Id = Convert.ToString(obj.Id);
                    Objddl.Nome = Convert.ToString(obj.QtdParcelas) + " - Juros em cada Parcela: " + obj.Juros.ToString("###,###,###,##0.00"); //ToString("###,###,###,##0.00")

                    lista.Add(Objddl);
                }

                return lista;

            }
        }

        public Int32 RetornaUtimaQtdParcelas(Int32 IdFormaPagamento)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var retorno = (from fpp in session.Query<FormaPagamentoParcelamento>().
                             Where(o => o.FormaPagamento.Id == IdFormaPagamento).
                             Select(o => new { o.QtdParcelas }).
                             OrderByDescending(o => o.QtdParcelas ).Take(1).ToList()
                             select fpp).SingleOrDefault();
                                
                return retorno == null ? 0 : retorno.QtdParcelas;

            }
        }

    }
}
