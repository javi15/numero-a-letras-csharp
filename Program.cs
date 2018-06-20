using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NumeroATexto01
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("Digite el numero");
            string num = Console.ReadLine();
            
            Numeros NumLetra = new Numeros();
            //String numero = "15963.70";
            Console.WriteLine(NumLetra.Convertir(num, true));
            Console.ReadLine();
        }
    }
}
