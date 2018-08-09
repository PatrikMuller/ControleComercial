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

            PessoaFisica obj = new PessoaFisica();
            PessoaFisicaAccess dao = new PessoaFisicaAccess();

            //obj.IdPessoa = 0;
            obj.Nome = "Patrik";
            obj.NomeMae = "Mãe";
            obj.NomePai = "Pai";
            obj.Rg = "RG";
            obj.Sexo = "M";
            //obj.Cpf = "703.111.222-23";

            dao.Grava(obj);

            Console.WriteLine("Gravado com Sucesso!");
            Console.ReadKey();
        }
    }
}
