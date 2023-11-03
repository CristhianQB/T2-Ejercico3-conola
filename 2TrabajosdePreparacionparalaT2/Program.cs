using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2TrabajosdePreparacionparalaT2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int opcion = Pantallas.pantallaPrincipal();
            do
            {
                switch (opcion)
                {
                    case 0:
                        opcion = Pantallas.pantallaPrincipal();
                        break;
                    case 1:
                        opcion = Pantallas.pantallaSumar("Sumar");
                        break;
                     case 2:
                        opcion = Pantallas.pantallaRestar("Restar");
                        break;
                     case 3:
                        opcion = Pantallas.pantallaMultiplicar("Multiplicando");
                        break;
                     case 4:
                        opcion = Pantallas.pantallaDividir("Dividiendo");
                        break;
                    
                    
                }
            } while (opcion !=5);

        }
    }
}
