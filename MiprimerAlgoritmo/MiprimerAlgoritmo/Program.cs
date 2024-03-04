using System;

namespace MiPrimerAlgritmo
{
    public class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double sum, rest, prod, coc;

            Console.WriteLine("Ingresar el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ingresar el segundo numero, el segundo numero debe ser diferente de cero");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
            rest = num1 - num2;
            prod = num1 * num2;
            coc = num1 / num2;

            Console.WriteLine("Suma: " + num1 + " + " + num2 + " = " + sum);
            Console.WriteLine("Resta: " + num1 + " - " + num2 + " = " + rest);
            Console.WriteLine("Producto: " + num1 + " x " + num2 + " = " + prod);
            Console.WriteLine("Cociente: " + num1 + " / " + num2 + " = " + coc);

        }
    }
}
