using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            //20. Solicite el ingreso de 2 números al usuario y determine el mayor
            string numero1;
            double salidaNum1;
            string num2;
            double salidaNum2;
            bool flag = false;
            do
            {
                Console.WriteLine("Ingrese dos números para comparar");
                numero1 = Console.ReadLine();
                num2 = Console.ReadLine();
                if (!double.TryParse(numero1,out salidaNum1))
                {
                    Console.WriteLine("Ingrese un valor numérico");
                }
                if (!double.TryParse(num2, out salidaNum2))
                {
                    Console.WriteLine("Ingrese un valor numérico");
                }
                else 
                {
                    flag = true;
                    if (salidaNum1 > salidaNum2)
                    {
                        Console.WriteLine($"El número {salidaNum1} es mauor que {salidaNum2}");
                    }
                    else if (salidaNum2 > salidaNum1)
                    {
                        Console.WriteLine($"El número {salidaNum2} es mayor que {salidaNum1}");
                    }
                    else
                    {
                        Console.WriteLine($"El númro {salidaNum1} es igual a {salidaNum2}");
                    }
                    Console.WriteLine("Presione una tecla para salir");
                }
            } while (flag==false);
            Console.ReadKey();
        }
    }
}
