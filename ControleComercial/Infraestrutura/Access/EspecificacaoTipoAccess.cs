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
    public class EspecificacaoTipoAccess
    {

        public Int32 Novo(EspecificacaoTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(EspecificacaoTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public EspecificacaoTipo Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<EspecificacaoTipo>(id);
            }
        }

        public void Remove(EspecificacaoTipo o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<EspecificacaoTipo> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<EspecificacaoTipo>().OrderBy(o => o.Id).ToList();

            }
        }

    }
}
