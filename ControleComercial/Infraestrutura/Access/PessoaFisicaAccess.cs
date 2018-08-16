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
    public class PessoaFisicaAccess
    {

        public Int32 Salvar(PessoaFisica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                
                session.Save(o.Pessoa).Equals(o.Pessoa.Id == 0);
                //session.Merge(o.Pessoa).Equals(o.Pessoa.Id > 0);

                //session.Save(o).Equals(o.Id == 0);
                //session.Merge(o).Equals(o.Id > 0);
                //session.Merge(o);

                //if (o.Pessoa.Id == 0)
                //    session.Save(o.Pessoa);
                //else
                //    session.Merge(o.Pessoa);

                //if (o.Id == 0)
                //    session.Save(o);
                //else
                //    session.Merge(o);

                //session.Merge(o);


                if (o.Id == 0)
                {
                    session.Save(o);
                }
                else
                {
                    session.Update(o.Pessoa);
                    session.Update(o);
                }
                    


                tx.Commit();
                return o.Pessoa.Id;
            }
        }

        public Int32 Novo(PessoaFisica o)
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

        public Int32 Editar(PessoaFisica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Pessoa.Id;
            }
        }

        public PessoaFisica Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<PessoaFisica>(id);
            }
        }
        
        public PessoaFisica Ler(String Cpf)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                //return session.Get<PessoaFisica>(id);
                return session.Query<PessoaFisica>().Where(o => o.Pessoa.CpfCnpj == Cpf).OrderBy(o => o.Id).FirstOrDefault();
            }
        }

        public void Remove(PessoaFisica o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<PessoaFisica> Lista(String nome)
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
                var result = session.CreateQuery("From Pessoa p Left Join PessoaFisica pf ON p.id = pf.Pessoa_id WHERE p.id = 1").
                    SetMaxResults(1).
                    UniqueResult<PessoaFisica>();


                return session.Query<PessoaFisica>().Where(o => o.Pessoa.Nome.Like(nome)).OrderBy(o => o.Pessoa.Id).ToList();

            }
        }






















        public void Adiciona(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(obj);
                tx.Commit();
            }
        }

        public PessoaFisica BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<PessoaFisica>(id);
            }
        }
                
        public void Atualiza(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<PessoaFisica> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from PessoaFisica p";
                IQuery query = session.CreateQuery(hql);
                return query.List<PessoaFisica>();
            }
        }

    }
}
