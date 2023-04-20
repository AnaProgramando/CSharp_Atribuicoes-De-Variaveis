using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_AtribuicoesDeVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto - Atribuicções de Variáveis: \r\n");

            int idade = 23;
            int idadeAna = idade;

            idade = 20;

            Console.WriteLine("A idade é " + idade + " anos.");
            Console.WriteLine("A idade é " + idadeAna + " anos.");
            // Aqui definimos que idadeAna é igual a idade, mas em seguida, alteramos o valor de idade, esta variável passou a receber o valor 20. Quando executamos o código, vemos que idadeAna continua igual a 23, porém, idade terá um novo valor, ou seja o 20.

            Console.ReadLine();
        }
    }
}
