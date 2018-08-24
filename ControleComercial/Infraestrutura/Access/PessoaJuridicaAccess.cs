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
    public class PessoaJuridicaAccess
    {

        public Int32 Salvar(PessoaJuridica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Pessoa.Id;
            }
        }

        public Int32 Novo(PessoaJuridica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o.Pessoa).Equals(o.Pessoa.Id == 0);
                session.Merge(o.Pessoa).Equals(o.Pessoa.Id > 0);

                session.Merge(o);

                tx.Commit();
                return o.Pessoa.Id;
            }
        }

        public Int32 Editar(PessoaJuridica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Pessoa.Id;
            }
        }

        public PessoaJuridica Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<PessoaJuridica>(id);
            }
        }

        public PessoaJuridica Ler(String Cpf)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //return session.Get<PessoaFisica>(id);
                return session.Query<PessoaJuridica>().Where(o => o.Pessoa.CpfCnpj == Cpf).OrderBy(o => o.Id).FirstOrDefault();
            }
        }

        public void Remove(PessoaJuridica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<PessoaJuridica> Lista(String nome)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //string hql = "select p from Carrinho p";
                //IQuery query = session.CreateQuery(hql);
                //return query.List<Carrinho>();
                //return session.Get<Carrinho>;

                //return session.Query<Bem>().Fetch(b => b.Marca).Fetch(b => b.Modelo).OrderBy(b => b.IdBem).ToList();

                //NHibernateSession.CreateQuery("FROM ListingCategoryDo l WHERE l.ListingId = :listingId ORDER BY l.PublishDate DESC")
                //    .SetParameter("listingId", listingId)
                //    .SetReadOnly(true)
                //    .SetMaxResults(1)
                //    .UniqueResult<ListingCategoryDo>();



                //var result = session.CreateQuery("From Pessoa p Join PessoaJuridica pj ON p.id = pj.Pessoa_id WHERE p.id = 1").List();



                return session.Query<PessoaJuridica>().Where(o => o.Pessoa.Nome.Like(nome)).Fetch(o => o.Pessoa).OrderBy(o => o.Pessoa.Nome).ToList();
                
            }
        }

    }
}