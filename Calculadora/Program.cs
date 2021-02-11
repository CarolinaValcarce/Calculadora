using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            Console.WriteLine("Introduce el primer número");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            numero2 = double.Parse(Console.ReadLine());
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma de {0} y {1} es {2}", numero1, numero2, resultado);
            resultado = numero1 - numero2;
            Console.WriteLine("El resultado de la resta de {0} menos {1} es {2}", numero1, numero2, resultado);
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de la multiplicación de {0} por {1} es {2}", numero1, numero2, resultado);
            if (numero2 == 0)
            {
                Console.WriteLine("El resultado de la división de {0} entre {1}  es Infinito",numero1,numero2);
                Console.ReadLine();
            }

            else
            {
                resultado = numero1 / numero2;
                Console.WriteLine("El resultado de la división de {0} entre {1} es {2}", numero1, numero2, resultado);
                Console.ReadLine();
            }
        }
    }

}
