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
    public class CarrinhoFormaPagamentoParcelamentoAccess
    {
        public Int32 Novo(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Save(o);

                tx.Commit();
                return o.Id;
            }
        }

        public Int32 Gravar(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(o);

                tx.Commit();
                return o.Id;
            }
        }

        public CarrinhoFormaPagamentoParcelamento Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoFormaPagamentoParcelamento>(id);
            }
        }

        public void Remove(CarrinhoFormaPagamentoParcelamento o)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(o);
                tx.Commit();
            }
        }

        //public IList<CarrinhoFormaPagamentoParcelamento> Lista(int idCarrinho)
        public IList<CarrinhoFormaPagamentoParcelamento> Lista(int idCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                                
                return session.Query<CarrinhoFormaPagamentoParcelamento>().
                    Fetch(o => o.Carrinho).
                    Where(o => o.Carrinho.Id == idCarrinho).
                    Fetch(o => o.FormaPagamentoParcelamento).
                    Fetch(o => o.FormaPagamento).
                    OrderBy(o => o.Id).ToList();

                
            }
        }

        //public IList<CarrinhoFormaPagamentoParcelamento> Lista(int idCarrinho)
        public Object ListaGrid(int idCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {

                var retorno = (from fp in session.Query<CarrinhoFormaPagamentoParcelamento>().
                               Fetch(o => o.Carrinho).
                               Where(o => o.Carrinho.Id == idCarrinho).
                               Fetch(o => o.FormaPagamentoParcelamento).
                               Fetch(o => o.FormaPagamento).
                               Select(o => new { o.Id,
                                   FormaPGTO = o.FormaPagamento.Descricao,
                                   Parcelamento = o.FormaPagamentoParcelamento.FormaPagamento.Descricao,
                                   o.QtdParcelas, 
                                   o.Juros}).
                               OrderBy(o => o.Id)
                               select fp).ToList();

                return retorno;

                //Convert.ToString(carrinhoFormaPagamentoParcelamento.Id),
                //Convert.ToString(carrinhoFormaPagamentoParcelamento.FormaPagamento.Descricao), 
                ////Convert.ToString(carrinhoFormaPagamentoParcelamento.FormaPagamentoParcelamento.FormaPagamento.Descricao), 
                //Convert.ToString(carrinhoFormaPagamentoParcelamento.QtdParcelas),
                //Convert.ToString(carrinhoFormaPagamentoParcelamento.Juros)

                //var retorno = (from l in session.Query<CarrinhoItem>().
                //               Fetch(o => o.Item).
                //               Where(o => o.Carrinho.Id == idCarrinho).
                //               Select(o => new { o.Ordem, o.Item.Nome, o.Quantidade, o.Preco, o.Desconto, Total = (o.Quantidade * (o.Preco - o.Desconto)) }).
                //               OrderBy(o => o.Ordem)
                //               select l).ToList();


            }
        }

    }
}
