﻿using System;
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
    public class ItemEspecificacaoAccess
    {

        public int Novo(ItemEspecificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public int Gravar(ItemEspecificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public ItemEspecificacao Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<ItemEspecificacao>(id);
            }
        }

        public void Remove(ItemEspecificacao o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public void Delete(int Id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ItemEspecificacao o = new ItemEspecificacao();

                o.Id = Id;
                                
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<ItemEspecificacao> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<ItemEspecificacao>().OrderBy(o => o.Id).ToList();

            }
        }

        public Object Lista(int IdItem)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var lista = (from fpp in session.Query<ItemEspecificacao>().
                             Where(o => o.Item.Id == IdItem).
                             Fetch(o => o.EspecificacaoTipo).
                             Fetch(o => o.Especificacao).
                             Select(o => new { o.Id, Tipo = o.EspecificacaoTipo.Descricao, Especificacao = o.Especificacao.Descricao }).
                             OrderBy(o => o.Tipo).ToList()
                             select fpp).ToList();



                return lista;

            }
        }

    }
}
