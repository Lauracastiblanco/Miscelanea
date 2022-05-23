using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Menu
    {
        public void menu ()
        {
            int seleccion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Bienvenido al Menu");
                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("Elija 1 si desea ir a la seccion de operadores");
                    Console.WriteLine("Elija 2 si desea ir a la seccion de condicionales");
                    Console.WriteLine("Elija 3 si desea ir a la seccion de ciclos");
                    Console.WriteLine("Elija 4 si desea ir a la seccion de arreglos");
                    Console.WriteLine("Elija 0 para salir del Menu");
                    seleccion = char.Parse(Console.ReadLine());
                    switch (seleccion)
                    {
                        case '1':
                            Operadores operadores = new Operadores();
                            operadores.operadores(); break;
                        case '2':
                            Condicionales condicionales = new Condicionales();
                            condicionales.condicionales(); break;
                        case '3':
                            Ciclos ciclos = new Ciclos();
                            ciclos.ciclos(); break;
                        case '0':
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("-----[Ingresa un numero valido]-----");
                            break;
                    }

                }catch(FormatException ex)
                {
                    Console.WriteLine("No especifico una opcion valida");
                    Menu menu = new Menu();
                    menu.menu();
                }
            }while (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6 || seleccion == 7 || seleccion == 0);
        }
    }
}


