using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TrabajosdePreparacionparalaT2
{
    public class Pantallas
    {
       public static int pantallaPrincipal()
        {
            Console.Clear();
            Console.Write("============================\n" +
                "Las cuatro operaciones\n" +
                "============================\n" +
                "1:Suma\n" +
                "2:Resta\n" +
                "3:Multiplicación\n" +
                "4:Divición\n" +
                "5:Salir\n" +
                "============================\n");
            return opcionprincipal("Ingrese una opción: ");
        }

        public static int pantallaSumar(string texto)
        {
            cabezaPantallas(texto);
            string texto1 = "Numero 1: ";
            Console.Write(texto1);
            int num1 = int.Parse(Console.ReadLine());

            string texto2 = "Numero 2: ";
            Console.Write(texto2);
            int num2 = int.Parse(Console.ReadLine());

            int suma = num1 + num2;
            string texto3 = "=================\n" +
            "Resultado: " + suma + "\n";
            Console.Write(texto3);
            piedePantallas();
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1) return 1;
            if (opcion == 2) return 0;
            return opcion;
        }

        public static int pantallaRestar(string texto)
        {
            cabezaPantallas(texto);
            string texto1 = "Numero 1: ";
            Console.Write(texto1);
            int num1 = int.Parse(Console.ReadLine());

            string texto2 = "Numero 2: ";
            Console.Write(texto2);
            int num2 = int.Parse(Console.ReadLine());

            int resta = num1 - num2;
            string texto3 = "=================\n" +
            "Resultado: " + resta + "\n";
            Console.Write(texto3);

            piedePantallas();
            int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1) return 2;
                if (opcion == 2) return 0;
                return opcion;
        }
        public static int pantallaMultiplicar(string texto)
        {
            cabezaPantallas(texto);
            string texto1 = "Numero 1: ";
            Console.Write(texto1);
            int num1 = int.Parse(Console.ReadLine());

            string texto2 = "Numero 2: ";
            Console.Write(texto2);
            int num2 = int.Parse(Console.ReadLine());

            int producto = num1 * num2;
            string texto3 = "=================\n" +
            "Resultado: " + producto + "\n";
            Console.Write(texto3);

            piedePantallas();
            int opcion = int.Parse(Console.ReadLine());
                if (opcion == 1) return 3;
                if (opcion == 2) return 0;
                return opcion;
        }
        public static int pantallaDividir(string texto)
        {
            cabezaPantallas(texto);

            string texto1 = "Numero 1: ";
            Console.Write(texto1);
            int num1 = int.Parse(Console.ReadLine());

            string texto2 = "Numero 2: ";
            Console.Write(texto2);
            int num2 = int.Parse(Console.ReadLine());

            int division = num1 / num2;
            string texto3 = "=================\n" +
            "Resultado: " + division + "\n";
            Console.Write(texto3);

            piedePantallas();
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1) return 4;
            if (opcion == 2) return 0;
            return opcion;
        }

        private static void cabezaPantallas(string texto)
        {
            Console.Clear();
            Console.Write("============================\n" +
                            texto + " .....\n" +
                            "============================\n");
        }
        private static void piedePantallas()
        {
            Console.Write("============================\n" +
                            "1: Limpiar | 2 : Regresar al Menú |\n" +
                            "============================\n" +
                            "Ingrese una opción: ");
        }

        private static int opcionprincipal(string Texto)
        {
            Console.Write(Texto);
            return int.Parse(Console.ReadLine());
        }

        
    }
}
