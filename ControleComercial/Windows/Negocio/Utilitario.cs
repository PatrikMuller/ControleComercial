using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Infraestrutura.Models;

namespace Windows.Negocio
{
    class Utilitario
    {


        public Utilitario()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        //Método arredonda para 2 casas decimais
        public Double Arredondar(Double valor)
        {
            return Math.Round(valor, 2);
        }

        //método para preencher um dropdownlist
        public void setComboBox(ComboBox cb, List<ddl> lista)
        {
            cb.DataSource = null;

            cb.DataSource = lista;
            cb.ValueMember = "Id";
            cb.DisplayMember = "Nome";
        }

        //formata data para o padrão (aaaa-mm-dd)
        public object formataData(String data)
        {
            String s = data.Replace('/', ' ').Trim();

            if (s == String.Empty)
                return null;

            else
                return Convert.ToDateTime(data).ToString("yyyy/MM/dd");
        }

        //Método para validar CPF
        public bool validacpf(String cpf)
        {
            return true;

            //bool resultado = false;

            //cpf = cpf.Trim();
            //cpf = cpf.Replace(".", "").Replace(",", "").Replace("-", "");

            //if (cpf.Length == 11)
            //{
            //    int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            //    int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            //    string tempCpf = string.Empty;
            //    string digito = string.Empty;
            //    int soma = 0;
            //    int resto = 0;
            //    string verificador = cpf.Substring(9, 2);

            //    tempCpf = cpf.Substring(0, 9);

            //    for (int i = 0; i < 9; i++)
            //        soma += Convert.ToInt32(tempCpf.Substring(i, 1)) * multiplicador1[i];

            //    resto = soma % 11;

            //    if (resto < 2)
            //        resto = 0;
            //    else
            //        resto = 11 - resto;

            //    digito = Convert.ToString(resto);

            //    tempCpf += digito;

            //    soma = 0;

            //    for (int i = 0; i < 10; i++)
            //        soma += Convert.ToInt32(tempCpf.Substring(i, 1)) * multiplicador2[i];

            //    resto = soma % 11;

            //    if (resto < 2)
            //        resto = 0;
            //    else
            //        resto = 11 - resto;

            //    digito += Convert.ToString(resto);


            //    if (cpf == "11111111111")
            //        resultado = false;
            //    else
            //        if (cpf == "22222222222")
            //        resultado = false;
            //    else
            //            if (cpf == "33333333333")
            //        resultado = false;
            //    else
            //                if (cpf == "44444444444")
            //        resultado = false;
            //    else
            //                    if (cpf == "55555555555")
            //        resultado = false;
            //    else
            //                        if (cpf == "66666666666")
            //        resultado = false;
            //    else
            //                            if (cpf == "77777777777")
            //        resultado = false;
            //    else
            //                                if (cpf == "88888888888")
            //        resultado = false;
            //    else
            //                                    if (cpf == "99999999999")
            //        resultado = false;
            //    else
            //                                        if (verificador == digito)
            //        resultado = true;
            //}

            //return resultado;
        }

        //Método para validar CNPJ
        public bool ValidaCnpj(String cnpj)
        {
            return true;

            //int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            //int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            //int soma;
            //int resto;
            //string digito;
            //string verificador;
            //string tempCnpj;
            //cnpj = cnpj.Trim();
            //cnpj = cnpj.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "");

            //if (cnpj.Length != 14)

            //    return false;

            //verificador = cnpj.Substring(12, 2);

            //tempCnpj = cnpj.Substring(0, 12);

            //soma = 0;

            //for (int i = 0; i < 12; i++)

            //    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            //resto = (soma % 11);

            //if (resto < 2)

            //    resto = 0;

            //else

            //    resto = 11 - resto;

            //digito = resto.ToString();

            //tempCnpj = tempCnpj + digito;

            //soma = 0;

            //for (int i = 0; i < 13; i++)

            //    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            //resto = (soma % 11);

            //if (resto < 2)

            //    resto = 0;

            //else

            //    resto = 11 - resto;

            //digito = digito + resto.ToString();

            //if (verificador == digito)
            //    return true;
            //else
            //    return false;

        }

        //Método para colocar Mascara no formato dinheiro em TextBox (Colocar no Evento KeyPress)
        public String mascaraMoney(TextBox txt, KeyPressEventArgs e)
        {

            String texto = txt.Text;

            //só aceita 18 digitos
            if (texto.Length <= 17)
            {
                if (char.IsNumber(e.KeyChar))
                {
                    texto = texto + e.KeyChar;
                }
            }

            texto = texto.Replace(",", "").Trim();

            int tamanho = texto.Length;
            int posvirgula = (tamanho - 2);

            Int32 number = Convert.ToInt32(e.KeyChar);

            //tecla backspace
            if (number == 8)
            {
                texto = texto.Remove(tamanho - 1, 1);
                posvirgula = (posvirgula - 1);
            }

            texto = texto.Insert(posvirgula, ",");

            texto = Convert.ToDouble(texto).ToString("###,###,###,##0.00");

            e.KeyChar = ' ';

            return texto;
        }
        public String mascaraMoney(TextBox txt, Double ValorMaximo, KeyPressEventArgs e)
        {

            String texto = txt.Text;

            //só aceita 18 digitos
            if (texto.Length <= 17)
            {
                //if (char.IsNumber(e.KeyChar))
                //{
                //    texto = texto + e.KeyChar;
                //}
                if (char.IsNumber(e.KeyChar))
                {
                    String max = texto + e.KeyChar;
                    max = max.Substring(0, max.Length);

                    max = max.Replace(",", "").Trim();

                    int tamanhoMax = max.Length;
                    int posvirgulaMax = (tamanhoMax - 2);

                    max = max.Insert(posvirgulaMax, ",");

                    if (Convert.ToDouble(max) <= ValorMaximo)
                    {
                        texto = texto + e.KeyChar;
                    }
                }
            }

            texto = texto.Replace(",", "").Trim();

            int tamanho = texto.Length;
            int posvirgula = (tamanho - 2);

            Int32 number = Convert.ToInt32(e.KeyChar);

            //tecla backspace
            if (number == 8)
            {
                texto = texto.Remove(tamanho - 1, 1);
                posvirgula = (posvirgula - 1);
            }

            texto = texto.Insert(posvirgula, ",");

            texto = Convert.ToDouble(texto).ToString("###,###,###,##0.00");

            e.KeyChar = ' ';

            return texto;
        }

        //Método para colocar Mascara no formato dinheiro em TextBox (Colocar no Evento KeyPress)
        public String mascaraPorcentagem(TextBox txt, KeyPressEventArgs e)
        {

            String texto = txt.Text;

            texto = texto.Replace(",", "").Replace("%", "").Trim();

            //só aceita 3 digitos e menor que 100
            if (texto.Length <= 5)
            {
                if (char.IsNumber(e.KeyChar))
                {
                    String cem = texto + e.KeyChar;
                    cem = cem.Substring(0, cem.Length - 2);

                    if (Convert.ToInt32(cem) <= 100)
                    {
                        texto = texto + e.KeyChar;
                    }
                }
            }

            //texto = texto.Replace(",", "").Replace("%", "").Trim();

            int tamanho = texto.Length;
            int posvirgula = (tamanho - 2);

            Int32 number = Convert.ToInt32(e.KeyChar);

            //tecla backspace
            if (number == 8)
            {
                texto = texto.Remove(tamanho - 1, 1);
                posvirgula = (posvirgula - 1);
            }

            texto = texto.Insert(posvirgula, ",");

            texto = Convert.ToDouble(texto).ToString("##0.00");

            e.KeyChar = '%';

            return texto;
        }

        //Método para colocar Mascara no formato dinheiro em TextBox (Colocar no Evento KeyPress)
        public String lerPorcentagem(Double campo)
        {
            String texto = Convert.ToDouble(campo).ToString("##0.00") + "%";

            return texto;
        }

        //Método para colocar Mascara no formato inteiro com 8 digitos completanto com 0 a esquerda
        public String mascaraInteiro(Int32 campo)
        {
            String texto = Convert.ToString(campo).PadLeft(8, '0');

            return texto;
        }



    }
}
