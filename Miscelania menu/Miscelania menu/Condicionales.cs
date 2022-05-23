using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu

{ 
    internal class Condicionales

    {
        public void condicionales()
        {
            int eleccion = 0;
            do { 
                try
                { 
            Console.WriteLine("Por favor, elige un algoritmo:");
            Console.WriteLine(" 1. Un algoritmo para saber si el número ingresado por teclado es positivo o negativo.");
            Console.WriteLine(" 2. Un algoritmo que reciba dos números por teclado y diga cuál es el mayor y cuál el menor.");
            Console.WriteLine(" 3. Un algoritmo que lea tres números enteros positivos y que calcule e imprima en pantalla el menor y el mayor de ellos.");
            Console.WriteLine(" 4. Dados dos números A y B, sumarlos si A es menor que B o sino restarlos.");
            Console.WriteLine(" 5. Dados dos números A y B encontrar el cociente entre A y B. Recordar que la división por cerono está definida, en ese caso debe aparecer una leyenda anunciando que la división no esposible.");
            Console.WriteLine(" 6. Dados dos números A y B, sumarlos si al menos uno de ellos es negativo, en caso contrario multiplicarlos.");
            Console.WriteLine(" 7. Escribir un algoritmo que determine si un año es bisiesto o no.");
            Console.WriteLine("Elija 0 para salir");
            eleccion = char.Parse(Console.ReadLine());


            switch (eleccion)
            {
                case '1':
                    PositivoNegativo(); break;
                case '2':
                    MayorMenor(); break;
                case '3':
                    TresEnteros(); break;
                case '4':
                    SumaResta(); break;
                case '5':
                    Cociente(); break;
                case '6':
                    SumaMultiplicacion(); break;
                case '7':
                    Bisiesto(); break;

                case '0':
                    Environment.Exit(0); break;

                default: Console.WriteLine("-----[Ingresa un numero valido]-----"); break;


            }
            }catch (FormatException ex)
            {
                Console.WriteLine("No especifico ninguna opcion valida");
                Ciclos ciclos = new Ciclos();
                ciclos.ciclos();
            }
        } while (eleccion == 1 || eleccion == 2 || eleccion == 3 || eleccion == 4 || eleccion == 5 || eleccion == 6 || eleccion == 7 || eleccion == 0);

        }
        
        private double a = 0;
        private double b = 0;
        private double c = 0;
        private double d = 0;
        private double e = 0;

        public double PositivoNegativo()

        {
            Console.WriteLine("Digita el numero para conocer si es negativo positivo");
            a = double. Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("El numero es negativo.");
            }
            else if (a > 0)
            {
                Console.WriteLine("El numero es positivo");
            }
            return 0;
        }
        public double MayorMenor()
        {
            Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
            Console.WriteLine("El primer numero es:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("El segundo numero es:");
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                Console.WriteLine(a + " Es menor que " + b);
                Console.WriteLine(b + " Es mayor que " + a);
            }
            else if (a > b)
            {
                Console.WriteLine(a + " Es mayor que " + b);
                Console.WriteLine(b + " Es menor que " + a);
            }
            return 0;
        }
         public double TresEnteros()
            {
                Console.WriteLine("Para llevar a cabo el programa por favor, digite tres numeros");
                Console.WriteLine("El primer numero es:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El tercer numero es:");
                c = Convert.ToInt32(Console.ReadLine());

                if (a >= b && a >= c)
                {
                    Console.WriteLine(a + " Es mayor");
                }
                else if (b > c)
                {
                    Console.WriteLine(b + " Es mayor");
                }
                else
                {
                    Console.WriteLine(c + " Es mayor");

                }
                if (a <= b && a <= c)
                {
                    Console.WriteLine(a + " Es menor");
                }
                else if (b < c)
                {
                    Console.WriteLine(b + " Es menor");
                }
                else
                {
                    Console.WriteLine(c + " Es menor");

                }
            return 0;
            }
         public double SumaResta()
            {
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a < b)
                {
                    c = a - b;
                    Console.WriteLine("El resultado de la suma es: " + c);
                }
                else if (a > b)
                {
                    d = b - a;
                    Console.WriteLine("El resultado de la resta: " + d);
                }
            return 0;
            }

         public double Cociente()

            {
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                d = double.Parse(Console.ReadLine());

                if (d == 0 || a == 0)
                {
                    Console.WriteLine("La division no es posible");
                }
                else if (d > 0)
                {
                    b = a / d;
                    Console.WriteLine(" El resultado de la divison es; " + b);

                }
            return 0;

            }
         public double SumaMultiplicacion()

            {
                Console.WriteLine("Para llevar a cabo el programa por favor, digite dos numeros");
                Console.WriteLine("El primer numero es:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("El segundo numero es:");
                b = Convert.ToInt32(Console.ReadLine());

                if (a < 0 || b < 0)
                {
                    c = a + b;
                    Console.WriteLine(c);
                }
                else if (a > 0 || b > 0)
                {
                    e = a * b;
                    Console.WriteLine(" El resultado de la multiplicacion es: " + e);

                }

            return 0;
            }

         public double Bisiesto()

            {
                Console.WriteLine("Digite un año para saber si es bisiesto");
                a = Convert.ToInt32(Console.ReadLine());
                if (a % 4 == 0 && a % 100 != 0 || a % 400 == 0)
                {
                    Console.WriteLine("Es bisiesto" + a);
                }
                else
                {
                    Console.WriteLine("no es bisiesto " + a);
                }

            return 0;
            }

        }
    }
