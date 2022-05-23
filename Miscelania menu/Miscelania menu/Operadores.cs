using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Operadores
    {
        private double a = 0;
        private double b = 0;
        private double c = 0;
        private double d = 0;

        public double geta()
        {
            return this.a;
        }
        public void seta(double a)
            { this.a = a; }
        public double getb()
        {
            return this.b;
        }
        public void setb (double b)
            { this.b = b; }
        public double getc()
        {
            return this.c;
        }
        public void setc (double c)
        { this.c = c; }
        public double getd()
        {
            return this.d;
        }
        public void setd (double d)
            { this.d = d; }

        public void operadores()
        {
            int opcion = 0;
            do
            {
                try
                {
                    Console.WriteLine("Por favor, elige una operacion:");
                    Console.WriteLine(" 1. Area de un triangulo");
                    Console.WriteLine(" 2. Suma ");
                    Console.WriteLine(" 3. Potencia al cuadrado");
                    Console.WriteLine(" 4. Conversion euros a dolares");
                    Console.WriteLine(" 5. Area y perimetro de un cuadrado");
                    Console.WriteLine(" 6. Area y volumen de un cilindro");
                    Console.WriteLine(" 7. Area y perimetro de un circulo");
                    Console.WriteLine(" 8. Promedio de 3 numeros");
                    Console.WriteLine("Elija 0 para salir");
                    opcion = char.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case '1':
                            AreaTriangulo(); break;
                        case '2':
                            SumaEnteros(); break;
                        case '3':
                            PotenciaEnteros(); break;
                        case '4':
                            Conversion(); break;
                        case '5':
                            AreaPerimetroCuadrado(); break;
                        case '6':
                            AreaVolumenCilindro(); break;
                        case '7':
                            AreaPerimetroCirculo(); break;
                        case '8':
                            PromedioTres(); break;
                        case '0':
                            Environment.Exit(0); break;
                        default: break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("No especifico ninguna opcion valida");
                    Operadores operadores = new Operadores();
                    operadores.operadores();
                }
            }while (opcion == 1 || opcion == 2|| opcion == 3 || opcion == 4 || opcion == 5 || opcion ==6 || opcion ==7 || opcion == 8 || opcion == 0);
        }    


            public double AreaTriangulo()

            {
                Console.WriteLine("Por favor, digite la base del triangulo");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Ahora, por favor, digite la altura");
                a = double.Parse(Console.ReadLine());
                c = b * a / 2;
                Console.WriteLine("El area del tringulo es: " + c);
                return  0;
            }
            public double SumaEnteros()
            {
                Console.WriteLine("Por favor digite el primer numero para realizar la suma");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite el segundo numero para completar la suma");
                b = double.Parse(Console.ReadLine());
                c = a + b;
                Console.WriteLine("El resultado de la suma es: " + c);
            return 0;
            }
            public double PotenciaEnteros()
            {
                Console.WriteLine("Por favor digite un numero para saber el cuadrado");
                a = double.Parse(Console.ReadLine());
                b = a * a;
                Console.WriteLine("El resultado de la potencia es: " + b);
            return 0;
            }

            public double Conversion()
            {
                Console.WriteLine("Digite el numero en Euros");
                a = double.Parse(Console.ReadLine());
                d = (a * 1.0831);
                Console.WriteLine(a + " en doloares es " + d);
            return 0;
            }
            public double  AreaPerimetroCuadrado()
            {
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                c = Convert.ToInt32(Console.ReadLine());
                b = c * 4;
                a = c * c;
                Console.WriteLine("El perimetro de su cuadrado es: " + b);
                Console.WriteLine("El area de su cuadrado es: " + a);
            return 0;
            }
            public double AreaVolumenCilindro()
            {
                Console.WriteLine("Digite el radio de su cilindro");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite la altura del cilindro");
                b = Convert.ToInt32(Console.ReadLine());
                c = (System.Math.PI * 2 * a + b + System.Math.PI * 2 * a * a);
                d = (System.Math.PI * a * a * b);
                Console.WriteLine("El area de su cilindro es: " + c);
                Console.WriteLine("El volumen de su cilindro es " + d);
            return 0;
            }
            public double AreaPerimetroCirculo()
            {
                Console.WriteLine("Digite el radio de la circunferencia");
                c = double.Parse(Console.ReadLine());
                b = (c * 2 * System.Math.PI);
                a = (System.Math.PI * c * c);
                Console.WriteLine("El area del circulo es: " + a);
                Console.WriteLine("La longitud de la circunferencia es: " + b);
            return 0;
            }
            public double PromedioTres()
            {
                Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
                Console.WriteLine("Digite el primer numero");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero");
                b = double. Parse(Console.ReadLine());
                Console.WriteLine("Digite el tercer numero");
                c = double.Parse(Console.ReadLine());
                d = a + b + c / 3;
                Console.WriteLine("El promedio de sus numeros es: " + d);
            return 0;
            }

        }
    }

