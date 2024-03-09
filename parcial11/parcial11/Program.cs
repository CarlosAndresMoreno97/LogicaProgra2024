using System;
namespace Parcial11 
{

    public class program
    {
        static void Main(string[] args)
        {
            double sueldo, venta1, venta2, venta3, comisionprm, primercomi, segundacomi, terceracomi, totalm, promedcomi;
            double objetivo = 1000000;
            
            Console.WriteLine("Ingrese el valor de la primera venta");
            venta1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la segunda venta");
            venta2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese el valor de la tercera venta");
            venta3 = Convert.ToDouble(Console.ReadLine());
            primercomi = venta1 * 0.1;
            segundacomi = venta2 * 0.1;
            terceracomi = venta3 * 0.1;
            comisionprm = (primercomi + segundacomi + terceracomi);
            Console.WriteLine("El dinero que obtendra el vendedor por concepto de comisiones es de " + comisionprm);

           
            Console.WriteLine("Ingrese el valor del sueldo ");
            sueldo = Convert.ToDouble(Console.ReadLine());
            totalm = (sueldo + comisionprm);
            Console.WriteLine("El total que recibira en el mes tomando en cuenta el sueldo  y las comisiones es de: " + totalm);

            
            if ((primercomi > segundacomi) && (segundacomi > terceracomi))

                Console.WriteLine("La mayor comision fue de la venta 1");

            else if ((segundacomi > primercomi) && (primercomi > terceracomi))
                Console.WriteLine("la mayor comision fue de la venta 2");
            else Console.WriteLine("la mayor comision fue de la numero 3 venta");

           
            promedcomi = (primercomi + segundacomi + terceracomi) / 3;
        }
    }

}