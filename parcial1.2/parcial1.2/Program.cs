using System;
namespace punto2delparcial 
{
    public class Program 
    { 
        static void Main(string[] args) 
        {
            // Un tren sale de la estación “A” a las 10:00 AM y viaja a una velocidad constante de 80 km / h.
            // Un segundo tren sale de la misma estación a las 11:00 AM y viaja en la misma dirección a una velocidad
            // constante de 100 km / h. ¿A qué hora el segundo tren alcanzará al primer tren? Mostrar esta hora en pantalla


            double tren1=80, tren2=100, salid1=10, salid2=11, horadeencuento,distanc1, distanc2;

            distanc1 = tren1 * 5;
            distanc2 = tren2 * 4;
            Console.WriteLine("La distancia recorrida por el primer tren es igual a:  " + distanc1);
            Console.WriteLine("La distancia recorrida por el segundo tren es igual a:  " + distanc2);


            horadeencuento = salid1 + 5;
            horadeencuento = salid2 + 4;
            Console.WriteLine("Los dos trenes se encuentran a las:  "  +  horadeencuento);
        }
    
    }



}