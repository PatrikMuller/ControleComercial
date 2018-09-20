using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Infraestrutura.Factory;
using Infraestrutura.Models;
using NHibernate;
using NHibernate.Linq;
using System.Data;

namespace Infraestrutura.Access
{
    public class CarrinhoItemAccess
    {
        
        public Int32 Novo(CarrinhoItem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                                                                
                session.Save(obj);

                tx.Commit();
                return obj.Id;
            }
        }

        public void Gravar(CarrinhoItem obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();

                session.Merge(obj);

                tx.Commit();
            }
        }

        public CarrinhoItem Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<CarrinhoItem>(id);
            }
        }
        
        public Object ListaGrid(Int32 idCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                                                
                var retorno = (from l in session.Query<CarrinhoItem>().
                               Fetch(o => o.Item).
                               Where(o => o.Carrinho.Id == idCarrinho).
                               Select(o => new { o.Ordem, o.Item.Nome, o.Quantidade, o.Preco, o.Desconto, Total = (o.Quantidade * (o.Preco - o.Desconto))}).
                               OrderBy(o => o.Ordem)
                               select l).ToList();

                return retorno;                        

            }
        }
        
        public IList<CarrinhoItem> Lista(Int32 idCarrinho)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                
                return session.Query<CarrinhoItem>().Fetch(i => i.Item).
                    Where(i => i.Carrinho.Id == idCarrinho).
                    OrderBy(c => c.Id).ToList();
                                
            }
        }

        public Object Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                var retorno = (from c in session.Query<CarrinhoItem>().
                                    //Where(o => o.Pessoa.Nome.Like(nome)).
                                    Fetch(o => o.Carrinho).
                                    Fetch(o => o.Item).
                                    Select(o => new { o.Carrinho.Id, Abertura = o.Carrinho.DataAbertura, Item = o.Item.Nome, o.Preco }).
                                    OrderBy(o => o.Id).
                                    ToList()
                               select c).Take(40).ToList();


                return retorno;
            }
        }

        public Double Total(Int32 idCarrinho)
        {
            Double total = 0.00;

            using (ISession session = NHibernateHelper.AbreSessao())
            {                
                var retorno = (from c in session.Query<CarrinhoItem>().
                                    Where(o => o.Carrinho.Id == idCarrinho).
                                    GroupBy(o => o.Carrinho.Id).
                                    //Select(o => new { (o.Quantidade * (o.Preco - o.Desconto)) }).
                                    Select(o => new { Total = o.Sum(i => i.Quantidade * (i.Preco - i.Desconto)) }).
                                    ToList()
                               select c).SingleOrDefault();
                                
                total = retorno.Total;

            }

            return total;
        }



    }
}
