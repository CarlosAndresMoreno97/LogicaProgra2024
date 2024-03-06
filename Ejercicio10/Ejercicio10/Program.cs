using System;
namespace Ejercicio10
{
    public class Program
    {
        static void Main(string[] args)
        {
            //10.	Construir un programa que pida por pantalla 3 números y
            //luego diga cuál es el mayor, el del medio y el menor de los números ingresados.

            double num1, num2, num3;

            Console.WriteLine("Ingrese el primer numero: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el primer numero: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num2 > num3)
            {
                Console.WriteLine($"El numero {num1} es el MAYOR");
                Console.WriteLine($"El numero {num2} es el MEDIO");
                Console.WriteLine($"El numero {num3} es el MENOR");
            }

            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"El numero {num2} es el MAYOR");
                Console.WriteLine($"El numero {num1} es el MEDIO");
                Console.WriteLine($"El numero {num3}  es el MEDIO");

            }

            else if (num3 > num2 && num2 > num1)
            {
                Console.WriteLine($"El numero {num3} es el MAYOR");
                Console.WriteLine($"El numero {num2} es el MEDIO");
                Console.WriteLine($"El numero {num1} es el MENOR");
            }
          else
            {
                Console.WriteLine("Hay numeros iguales");
            }
        }
    }
}
