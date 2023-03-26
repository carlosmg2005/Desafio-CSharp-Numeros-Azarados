using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_CSharp_Números_Azarados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = Console.ReadLine();
            string contem = "13";

            if (numero.Contains(contem))
            {
                var malaSuerte = $"{numero} es de Mala Suerte";
                Console.WriteLine(malaSuerte);
            }
            else
            {
                var suerte = $"{numero} NO es de Mala Suerte";
                Console.WriteLine(suerte);
            }

            Console.ReadKey();
        }
    }
}
