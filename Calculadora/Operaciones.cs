using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
        public Operaciones()
        {
        }

        public void suma()
        {
            double num1, num2;
            double resultado;

            Console.WriteLine("Operacion seleccionada: Suma\n\nIngrese un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero para la suma\n");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + resultado);
        }

        public void resta()
        {
            double num1, num2;
            double resultado;

            Console.WriteLine("Operacion seleccionada: Resta\n\nIngrese un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero para la resta\n");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 - num2;

            Console.WriteLine(num1 + " - " + num2 + " = " + resultado);
        }

        public void multiplicacion()
        {
            double num1, num2;
            double resultado;

            Console.WriteLine("Operacion seleccionada: Multiplicacion\n\nIngrese un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero para la multiplicacion\n");
            num2 = int.Parse(Console.ReadLine());
            resultado = num1 * num2;

            Console.WriteLine(num1 + " * " + num2 + " = " + resultado);
        }
        public void division()
        {
            double num1, num2;
            double resultado;

            Console.WriteLine("Operacion seleccionada: División\n\nIngrese un numero");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero para la división\n");
            num2 = int.Parse(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Error, no se puede dividir por 0");
                return;
            }
            else
            {
                resultado = num1 / num2;

                Console.WriteLine(num1 + " / " + num2 + " = " + resultado);
            }
        }
    }
}
