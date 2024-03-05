using Systen;

namespace Ejerrcicio9
{
    public class program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("Ingresar el primer numero:  ");
            num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingresar el segundo numero:  ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Ingresar el tercer numero:  ");
            num3 = Convert.ToDouble(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"El numero {num1} es MAYOR"); 
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"El numero {num2} es MAYOR");
            }
            else
            {
                Console.WriteLine($"El numero {num3} es MAYOR");
            }
        }
    }
}

