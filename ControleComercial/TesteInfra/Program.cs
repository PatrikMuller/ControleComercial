using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Infraestrutura.Access;
using Infraestrutura.Models;

namespace TesteInfra
{
    class Program
    {
        static void Main(string[] args)
        {

            //PessoaFisica obj = new PessoaFisica();
            //PessoaFisicaAccess dao = new PessoaFisicaAccess();

            ////obj.IdPessoa = 0;
            //obj.Nome = "Patrik";
            //obj.NomeMae = "Mãe";
            //obj.NomePai = "Pai";
            //obj.Rg = "RG";
            //obj.Sexo = "M";
            ////obj.Cpf = "703.111.222-23";

            //dao.Grava(obj);

            //Console.WriteLine("Gravado com Sucesso!");
            //Console.ReadKey();

            //UnidadeMedida
            UnidadeMedidaAccess umAccess = new UnidadeMedidaAccess();

            var umLista = umAccess.Lista();

            if (umLista == null)
            {

                UnidadeMedida umObj = new UnidadeMedida();

                umObj.Descricao = "UNIDADE";
                umObj.Sigla = "UNID";

                umAccess.Novo(umObj);
                                
            }

            //Fabricante
            FabricanteAccess fAccess = new FabricanteAccess();

            var fLista = fAccess.Lista();

            if (fLista == null)
            {

                Fabricante fObj = new Fabricante();

                fObj.Descricao = "FABRICANTE";
                
                fAccess.Novo(fObj);

            }

            //CarrinhoPessoaTipo
            CarrinhoPessoaTipoAccess ctpAccess = new CarrinhoPessoaTipoAccess();

            var ctpLista = ctpAccess.Lista();

            if (ctpLista == null)
            {

                CarrinhoPessoaTipo ctpObj = new CarrinhoPessoaTipo();

                ctpObj.Descricao = "CLIENTE";

                ctpAccess.Novo(ctpObj);

                ctpObj.Descricao = "VENDEDOR";

                ctpAccess.Novo(ctpObj);

            }


            //FormaPagamento
            FormaPagamentoAccess fpAccess = new FormaPagamentoAccess();

            var fpLista = fpAccess.Lista();

            if (fpLista == null)
            {
                FormaPagamento fpObj = new FormaPagamento();

                fpObj.Descricao = "DINHEIRO";

                fpAccess.Novo(fpObj);

                fpObj.Descricao = "CARTÃO DÉBITO";

                fpAccess.Novo(fpObj);

                fpObj.Descricao = "CARTÃO CRÉDITO";

                fpAccess.Novo(fpObj);
            }


            //Parcelamento Status
            ParcelamentoStatusAccess psAccess = new ParcelamentoStatusAccess();

            var psLista = psAccess.Lista();

            if (psLista == null)
            {
                ParcelamentoStatus psObj = new ParcelamentoStatus();

                psObj.Descricao = "ATIVO";

                psAccess.Novo(psObj);

                psObj.Descricao = "INATIVO";

                psAccess.Novo(psObj);
            }



            //FormaPagamento
            FormaPagamentoParcelamentoAccess fppAccess = new FormaPagamentoParcelamentoAccess();

            var fppLista = fppAccess.Lista();

            if (fppLista == null)
            {
                FormaPagamentoParcelamento fppObj = new FormaPagamentoParcelamento();
                FormaPagamento fp = new FormaPagamento();
                ParcelamentoStatus ps = new ParcelamentoStatus();

                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0;
                fp.Id = 1;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);


                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0;
                fp.Id = 2;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);


                fppObj.QtdParcelas = 1;
                fppObj.Juros = 0;
                fp.Id = 3;
                fppObj.FormaPagamento = fp;
                ps.Id = 1;
                fppObj.ParcelamentoStatus = ps;

                fppAccess.Novo(fppObj);

            }



        }
    }
}
