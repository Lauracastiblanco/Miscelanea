using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Ciclos
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;
      
        public void ciclos()
        {
            int seleccion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Elige el ciclo que quieres llevar a cabo");
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("1. Imprimir todos los múltiplos de 3 que hay entre 1 y 100. ");
                    Console.WriteLine("2. Imprimir los números impares entre 0 y 100. ");
                    Console.WriteLine("3. Imprimir los números pares del 1 al 100. ");
                    Console.WriteLine("4. Escribir un programa que imprima por pantalla los cuadrados de los números del 1 al 30. ");
                    Console.WriteLine("5. Escribir un programa que sume los cuadrados de los cien primeros números naturales, mostrando el resultado en pantalla.");
                    Console.WriteLine("6. Dados dos números naturales, el primero menor que el segundo, generar y mostrar todos los números comprendidos entre ellos en secuencia ascendente.");
                    Console.WriteLine("7. Sumar todos los números que se digitan por teclado mientras no sea cero.");


                    seleccion = char.Parse(Console.ReadLine());

                    switch (seleccion)
                    {
                        case '1':
                            MultiplosdeTres(); break;
                        case '2':
                            Impares(); break;
                        case '3':
                            NumerosPares(); break;
                            case '4':
                            CuadradosTreinta(); break;
                            case '5':
                            sumacuadrados(); break;
                            case '6':
                            sumanegativos(); break;
                            case '7':
                            sumacero(); break;
                        case '0': Environment.Exit(0); break;
                        default: Console.WriteLine("Selecciona una opcion"); break;

                    }
                }catch(FormatException ex)
                {
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Ciclos ciclos = new Ciclos();
                    ciclos.ciclos();
                }
            } while (seleccion == 1 || seleccion == 2 || seleccion == 3 || seleccion == 4 || seleccion == 5 || seleccion == 6 || seleccion == 7 || seleccion == 0);
        }
         public double MultiplosdeTres()
        {
                for (int i= 1; i < 100; i += 1)
                {
                    if (i % 3 == 0)
                    {
                        Console.Write("{0}|", i);
                    }
                }
                return 0;
            }
        public double Impares()
        {
            Console.WriteLine("Los numeros impares del 1 al 100 son: ");
            for (int i = 1; i < 101; i += 2)
            {
                Console.Write(" | " + i);
            }
            return 0;
        }
        public double NumerosPares()
        {
            Console.WriteLine("Los numeros pares del 1 al 100 son: ");
            {
                for (int i = 0; i < 101; i +=2)
                {
                    Console.Write(" | " + i);
                }
            }
            return 0;
        }
        public double CuadradosTreinta()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 30 son: ");
            for (int i = 1; i < 30; i ++)
            {
                Console.WriteLine(i * i);
            }
            Console.ReadLine();
           return 0;
     
        }
        public double sumacuadrados()
        {
            Console.WriteLine("Los cuadrados de los numeros del 1 al 100 son: ");
            for (int i = 1; i < 101; i++)
            {
                Console.WriteLine("El numero" + i);
                c = c + i * i;
                Console.WriteLine("el cuadrado es:" + Math.Pow(i, 2));
            }
            Console.WriteLine("la suma total de los cuadrados es: " + c);
            Console.ReadLine();
            return 0;

        }
        public double sumanegativos()
        {
            Console.WriteLine("Ingrese 2 numeros");
            Console.WriteLine("Ingrese el primer numero");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            b = double.Parse(Console.ReadLine());
            if (a < b)
            {
                for (double i = a; i < b; i++)
                {
                    Console.WriteLine(i);
                }
             }
            else
            {
                Console.WriteLine("No especifico nada");
            }
            return 0;
        }
        
        public double sumacero()
            {
            do
            {
                Console.WriteLine("Digite numeros para sumar(0 para finalizar)");
                a = double.Parse(Console.ReadLine());
                b = b + a;
        
                Console.WriteLine("La suma de los numeros es igual a: " + b);
            }while (a > 0);
            return 0;
            }
}
}



