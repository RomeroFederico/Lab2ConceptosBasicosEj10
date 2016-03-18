using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_10
{

    /*    
    10.  Partiendo de la base del ejercicio anterior, se pide realizar un 
    programa que imprima por pantalla una pirámide como la siguiente: 
                    * 
                   *** 
                  ***** 
                 ******* 
                ********* 
    Nota: Utilizar estructuras repetitivas y selectivas. 
    */

    class Ejercicio_10
    {
        static void Main(string[] args)
        {
            int altura;
            string ast = "*";

            Console.Title = "Ejercicio Nro. 10";

            Console.Write("Ingrese la altura de la piramide: ");

            do
            {
                while (!int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese la altura de la piramide: ");
                }

                if (altura <= 0)
                {
                    Console.Clear();
                    Console.Write("ERROR!!! Ingrese la altura de la piramide: ");
                }
            } while (altura <= 0);

            for (int j = 0; j < altura; j++)
            {
                for (int i = 0; i < j; i++)
                    Console.Write(" ");
                Console.WriteLine("{0, 50}", ast);

                ast += "**";
            }

            Console.ReadKey();
        }
    }
}