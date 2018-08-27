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

        //public IList<PessoaJuridica> Lista(String nome)
        public Object Lista(String nome)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                
                var retorno = (from pj in session.Query<PessoaJuridica>().
                                Where(o => o.Pessoa.Nome.Like(nome)).
                                Fetch(o => o.Pessoa).
                                Select(o => new { o.Pessoa.Id, o.Pessoa.Nome, o.Fantasia, Cnpj = o.Pessoa.CpfCnpj, IE = o.Ie }).
                                OrderBy(o => o.Nome).
                                ToList()
                              select pj).Take(40).ToList();


                return retorno;
                
                //return session.Query<PessoaJuridica>().
                //    Where(o => o.Pessoa.Nome.Like(nome)).
                //    Fetch(o => o.Pessoa).
                //    //Select(o => new { o.Id, o.Pessoa.Nome, o.Fantasia }).
                //    OrderBy(o => o.Pessoa.Nome).
                //    ToList();
                //ToList().Select(o => new Object { id = o.Id, nome = o.Pessoa.Nome});//Select(p => id = p.Id, nome = p.Pessoa.Nome);
                
            }
        }

    }
}