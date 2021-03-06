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
    public class CarrinhoFormaPagamentoAccess
    {

        public Int32 Novo(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public CarrinhoFormaPagamento Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoFormaPagamento>(id);
            }
        }

        public void Remove(CarrinhoFormaPagamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        public IList<CarrinhoFormaPagamento> GetAll(Int32 IdCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                return session.Query<CarrinhoFormaPagamento>().OrderBy(o => o.Id).ToList();

            }
        }

        public Object Lista(Int32 IdCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                //return session.Query<CarrinhoFormaPagamento>().
                //    Where(o => o.Carrinho.Id == IdCarrinho).
                //    OrderBy(o => o.Id).ToList();

                var retorno = (from cpf in session.Query<CarrinhoFormaPagamento>().
                                        Where(o => o.Carrinho.Id == IdCarrinho).
                                        //Select(o => new { o.Id, o.FormaPagamento.Descricao, o.QtdParcelas, o.Juros, o.ValorPagar, o.ValorParcela }).
                                        Select(o => new {o.Id, o.FormaPagamento.Descricao, o.QtdParcelas, o.ValorPagar }).
                                        OrderBy(o => o.Id).
                                        ToList()
                               select cpf).ToList();


                return retorno;

            }
        }

        public double TotalPago(int IdCarrinho)
        {
            double total = 0.00;

            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var retorno = session.Query<CarrinhoFormaPagamento>().
                                    Where(o => o.Carrinho.Id == IdCarrinho).
                                    GroupBy(o => o.Carrinho.Id).
                                    //Select(o => new { (o.Quantidade * (o.Preco - o.Desconto)) }).
                                    Select(o => new { Total = o.Sum(i => i.ValorPagar) }).
                                    FirstOrDefault();

                total = retorno == null ? 0.00 : retorno.Total;

            }

            return total;
        }

    }
}
