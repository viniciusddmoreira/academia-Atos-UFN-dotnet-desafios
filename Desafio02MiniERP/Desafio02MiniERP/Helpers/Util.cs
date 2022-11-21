using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio02MiniERP.Helpers
{
    internal static class Util
    {
        public static bool NomeValido(string nome)
        {
            Regex rgx = new Regex(@"^[aA-zZ]+((\s[aA-zZ]+)+)?$");

            if (rgx.IsMatch(nome))
                return true;
            else
                return false;
        }

        public static bool ContemLetras(string letras)
        {
            if (letras.Where(c => char.IsLetter(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public static bool ContemNumeros(string numeros)
        {
            if (numeros.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }

        public static bool ContemLetrasEnumeros(string texto)
        {
            if (ContemLetras(texto) && ContemNumeros(texto))
                return true;
            else
                return false;
        }

        public static bool ContemLetrasOuNumeros(string texto)
        {
            if (ContemLetras(texto) || ContemNumeros(texto))
                return true;
            else
                return false;
        }

        public static bool NumeroInteiroValido(string numero)
        {
            Regex rgx = new Regex(@"^[0-9]+$");

            if (rgx.IsMatch(numero))
                return true;
            else
                return false;
        }

        public static bool NumeroRealValido(string numeroreal)
        {
            Regex rgx = new Regex(@"^[0-9]+?(.|,[0-9]+)$");

            if (rgx.IsMatch(numeroreal))
                return true;
            else
                return false;

        }

        public static bool CepValido(string cep)
        {
            Regex rgx = new Regex(@"^\d{5}\-?\d{3}$");

            if (rgx.IsMatch(cep))
                return true;
            else
                return false;
        }
        public static bool EmailValido(string email)
        {
            Regex rgx = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rgx.IsMatch(email))
                return true;
            else
                return false;
        }

        public static bool UrlValida(string http)
        {
            Regex rgx = new Regex(@"^((http)|(https)|(ftp)):\/\/([\- \w]+\.)+\w{2,3}(\/ [%\-\w]+(\.\w{2,})?)*$");

            if (rgx.IsMatch(http))
                return true;
            else
                return false;
        }

        public static bool IpValido(string ip)
        {
            Regex rgx = new Regex(@"^\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b$");

            if (rgx.IsMatch(ip))
                return true;
            else
                return false;
        }

        public static bool DataValida(string data)
        {
            Regex rgx = new Regex(@"^((0[1-9]|[12]\d)\/(0[1-9]|1[0-2])|30\/(0[13-9]|1[0-2])|31\/(0[13578]|1[02]))\/\d{4}$");

            if (rgx.IsMatch(data))
                return true;
            else
                return false;
        }

        public static bool TelefoneValido(string telefone)
        {
            Regex rgx = new Regex(@"^([0-9]{2})\s[0-9]{4}-[0-9]{4}$");

            if (rgx.IsMatch(telefone))
                return true;
            else
                return false;
        }

        public static bool CpfValido(string cpf)
        {
            // Se vazio
            if (cpf.Length == 0)
                return false;

            //Expressao regular que valida cpf
            Regex rgx = new Regex(@"^\d{3}\.?\d{3}\.?\d{3}\-?\d{2}$");

            if (rgx.IsMatch(cpf))
                return true;
            else
                return false;

            // Limpa caracteres especiais pontos e espaços
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            cpf = cpf.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            cpf = cpf.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            cpf = cpf.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            cpf = cpf.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            cpf = cpf.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            cpf = cpf.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            // Se so tem numeros
            if (ContemLetras(cpf))
                return false;
            else
                return true;

            // Se o tamanho for < 11 entao retorna como inválido
            if (cpf.Length != 11)
                return false;

            // Caso coloque todos os numeros iguais
            switch (cpf)
            {
                case "11111111111":
                    return false;

                case "00000000000":
                    return false;

                case "2222222222":
                    return false;

                case "33333333333":
                    return false;

                case "44444444444":
                    return false;

                case "55555555555":
                    return false;

                case "66666666666":
                    return false;

                case "77777777777":
                    return false;

                case "88888888888":
                    return false;

                case "99999999999":
                    return false;
            }

            // Calcula Validade do CPF
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }


        public static bool CnpjValido(string cnpj)
        {

            // Se vazio
            if (cnpj.Length == 0)
                return false;

            //Expressao regular que valida cpf
            Regex rgx = new Regex(@"^\d{2}.?\d{3}.?\d{3}/?\d{4}-?\d{2}$");

            if (rgx.IsMatch(cnpj))
                return true;
            else
                return false;

            // Limpa caracteres especiais
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(" ", "");
            cnpj = cnpj.Replace("+", "").Replace("*", "").Replace(",", "").Replace("?", "");
            cnpj = cnpj.Replace("!", "").Replace("@", "").Replace("#", "").Replace("$", "");
            cnpj = cnpj.Replace("%", "").Replace("¨", "").Replace("&", "").Replace("(", "");
            cnpj = cnpj.Replace("=", "").Replace("[", "").Replace("]", "").Replace(")", "");
            cnpj = cnpj.Replace("{", "").Replace("}", "").Replace(":", "").Replace(";", "");
            cnpj = cnpj.Replace("<", "").Replace(">", "").Replace("ç", "").Replace("Ç", "");

            // Se comtem letras
            if (ContemLetras(cnpj))
                return false;
            else
                return true;

            // Se o tamanho for < 11 entao retorna como inválido
            if (cnpj.Length != 14)
                return false;

            // Caso coloque todos os numeros iguais
            switch (cnpj)
            {
                case "11111111111111":
                    return false;

                case "00000000000000":
                    return false;

                case "22222222222222":
                    return false;

                case "33333333333333":
                    return false;

                case "44444444444444":
                    return false;

                case "55555555555555":
                    return false;

                case "66666666666666":
                    return false;

                case "77777777777777":
                    return false;

                case "88888888888888":
                    return false;

                case "99999999999999":
                    return false;
            }

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;
            int resto;
            string digito;
            string tempCnpj;

            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
                return false;

            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;

            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        /*

 Expressão Regular
 *****************
 using System.Text.RegularExpressions;

 Busca posicionada
 -----------------
 Símbolo
 Descrição

 ^
 Busca somente no início da string.

 $
 Busca somente no fim da string.

 \b
 Encontra em qualquer parte da string.

 \B
 Encontra qualquer parte que não esteja limitada.

 Literais
 ---------
 Símbolo
 Descrição
 Alfa-numérica
 Todos os caracteres alfabéticos e numerais se encontram literalmente.

 \\
 Encontra o caractere de escape.

 Classes de Caracteres
 ---------------------
 Símbolo
 Descrição

 [abc]
 Encontra qualquer caractere que estiver dentro do grupo. Você pode usar hífen para denotar escala. Por Exemplo. [a-z] encontra qualquer letra do alfabeto. [0-9] encontra qualquer dígito.

 [^abc]
 Encontra qualquer caractere que não estiver dentro do grupo. O circunflexo indica que nenhum caractere deve estar na string.

 Observação: O circunflexo usado dentro da classe de caractere é diferente do que denota o início da string, não se confundam. A negação aqui só é permitida dentro dos sinais.

 .
 (Ponto). Encontra qualquer caractere exceto o caractere de nova linha ou terminador de linha Unicode.

 \w
 Encontra qualquer caractere alfanumérico incluindo underscore. Equivalente a [a-zA-Z0-9_].

 \W
 Encontra qualquer caractere que não se encontra na classe dos alfanuméricos. Equivalente a [^a-zA-Z0-9_].

 \d
 Encontra qualquer dígito. Equivalente a [0-9].

 \D
 Encontra qualquer caractere que não seja um dígito. Equivalente a [^0-9].

 \s
 Encontra qualquer caractere que equivale a um espaço. Equivalente a [ abc].

 \S
 Encontra qualquer caractere que não equivale a um espaço. Equivalente a [^abc].

 Repetição
 ---------
 Símbolo
 Descrição

 {x}
 Encontra exatamente x ocorrência na expressão regular.

 {x,}
 ncontra x ou mais ocorrências na expressão regular.

 {x,y}
 Encontra x para y numero de ocorrências na expressão regular.

 ?
 Encontra zero ou nenhuma ocorrência. Equivalente a {0,1}.

 *
 Encontra zero ou mais ocorrências. Equivalente a {0,}.

 +
 Encontra uma ou mais ocorrências. Equivalente a {1,}.

 Alternação & Agrupamento
 ------------------------
 Símbolo
 Descrição

 ( )
 Agrupamento de caracteres para criar uma cláusula de condição. Pode estar aninhado.

 |
 Combina cláusulas de condições dentro de umaexpressão regular e então encontra qualquer uma das cláusulas. Similar à expressão "OR".

 BackReferences
 --------------
 Símbolo
 Descrição

 ( )\n
 Encontra uma cláusula entre parênteses. n é o número de cláusulas para a esquerda da backReference.
 */
    }
}
