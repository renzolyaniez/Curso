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
            int operacion = 0;
            Operaciones op = new Operaciones();

            do
            {
                Console.WriteLine("Calculadoraaa\n");
                Console.WriteLine("1- Suma\n2- Resta\n3- Multiplicación\n4- División\n5- Salir");

                Console.WriteLine("Seleccione una operación:");
                operacion = int.Parse(Console.ReadLine());

                switch (operacion)
                {
                    case 1:
                        op.suma();
                        break;

                    case 2:
                        op.resta();
                        break;

                    case 3:
                        op.multiplicacion();
                        break;

                    case 4:
                        op.division();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Error, la opcion ingresada no es correcta\n");
                        break;
                }

            } while (operacion != 5);
            Console.ReadLine();
        }
    }
}
