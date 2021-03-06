﻿using System.Collections.Generic;
using System.Linq;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;


namespace Infraestrutura.Access
{
    public class CarrinhoAccess
    {

        public int Novo(Carrinho obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                                
                session.Save(obj);
                
                tx.Commit();
                return obj.Id;
            }
        }

        public int Gravar(Carrinho obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public Carrinho Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Carrinho>(id);
            }
        }

        public void Remove(Carrinho obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public IList<Carrinho> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Query<Carrinho>().OrderBy(o => o.Id).ToList();
            }
        }
                
    }
}
