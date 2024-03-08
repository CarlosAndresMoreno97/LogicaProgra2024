using System;
using System.ComponentModel.Design;

namespace Ejercicio11
{
    public class Program
    {
        static void Main(string[] args)
        {
            //11.	La pizzería Bella Napoli ofrece pizzas vegetarianas y no vegetarianas
            //a sus clientes. Los ingredientes para cada tipo de pizza aparecen a continuación.
            //•	Ingredientes vegetarianos: Pimiento y tofu.
            //•	Ingredientes no vegetarianos: Peperoni, Jamón y Salmón.
            //Escribir un programa en C# que pregunte al usuario si quiere una pizza vegetariana 	
            //o no, y en función de su respuesta le muestre un menú con los ingredientes 		
            //disponibles para que elija. Solo se puede elegir un ingrediente además de la 		
            //mozzarella y el tomate que están en todas las pizzas. Al final se debe mostrar por 	
            //pantalla si la pizza elegida es vegetariana o no y todos los ingredientes que lleva.

            Console.WriteLine("Bienvenido a la pizzeria Bella Napoli, que desea ordenar");
            Console.WriteLine("Tipos de pizza: ");

            Console.WriteLine("1 . Vegetariana");
            Console.WriteLine("2 . No vegetariana. ");

            // Declarar variables
            int tipo_de_pizza, ingrediente;

            Console.WriteLine("Introduzca el numero correspondiente al tipo de pizza que desea.");
            tipo_de_pizza = Convert.ToInt32(Console.ReadLine());

            if (tipo_de_pizza == 1 ) 
            {
                Console.WriteLine("Elige 1 ingrediente para tu pizza vegetaria");
                Console.WriteLine("1. Pimiento");
                Console.WriteLine("2. Tofu");
                Console.WriteLine("Ingrese el numero correspondiente al ingrediente que desea: ");
                ingrediente = Convert.ToInt32(Console.ReadLine());
                if( ingrediente == 1 )
                {
                    Console.WriteLine("Pizza vegetariana con mozzarella, tomate y pimiento");
                }
                else 
                {
                    Console.WriteLine("Pizza vegetariana con mozzarella, tomate y tofu");
                }
                    
            }

            else
            {
                Console.WriteLine("Elige 1 ingrediete para tu pizza NO vegetariana:  ");
                Console.WriteLine("1. Peperoni");
                Console.WriteLine("2. Jamon");
                Console.WriteLine("3. Salmon");
                Console.WriteLine("Ingrese el numero correspondiente al ingrediente que desea");
                ingrediente= Convert.ToInt32(Console.ReadLine());

                if(ingrediente == 1)
                {
                    Console.WriteLine("Pizza NO vegetariana con mozzarella, tomate y peperoni");
                }

                else if( ingrediente == 2) 
                {
                    Console.WriteLine("Pizza NO vegetariana con mozzarella, tomate y jamon");
                }

                else
                {
                    Console.WriteLine("Pizza NO vegetariana con mozzarella, tomate y salmon");
                }
            }

        }

    }
}
