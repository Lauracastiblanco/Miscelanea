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

        public double geta() { return this.a;}
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
                setb (double.Parse(Console.ReadLine()));
                Console.WriteLine("Ahora, por favor, digite la altura");
                seta (double.Parse(Console.ReadLine()));
                setc (getb() * geta() / 2);
                Console.WriteLine("El area del tringulo es: " + c);
                return  getc();
            }
            public double SumaEnteros()
            {
                Console.WriteLine("Por favor digite el primer numero para realizar la suma");
                seta(double.Parse(Console.ReadLine()));
                Console.WriteLine("Por favor digite el segundo numero para completar la suma");
                setb(double.Parse(Console.ReadLine()));
                setc(geta() + getb());
                Console.WriteLine("El resultado de la suma es: " + c);
            return getc();
            }
            public double PotenciaEnteros()
            {
                Console.WriteLine("Por favor digite un numero para saber el cuadrado");
                seta(double.Parse(Console.ReadLine()));
                setb (geta() * geta());
                Console.WriteLine("El resultado de la potencia es: " + getb());
            return getb();
            }

            public double Conversion()
            {
                Console.WriteLine("Digite el numero en Euros");
                seta(double.Parse(Console.ReadLine()));
                setd(geta() * 1.0831);
                Console.WriteLine(geta() + " en doloares es " + getd());
            return 0;
            }
            public double  AreaPerimetroCuadrado()
            {
                Console.WriteLine("Digite la medida de un lado del cuadrado");
                setc(double.Parse(Console.ReadLine()));
                setb (getc() * 4);
                seta (getc() * getc());
                Console.WriteLine("El perimetro de su cuadrado es: " + setb);
                Console.WriteLine("El area de su cuadrado es: " + seta);
            return 0;
            }
            public double AreaVolumenCilindro()
            {
                Console.WriteLine("Digite el radio de su cilindro");
                seta(double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite la altura del cilindro");
                setb(double.Parse(Console.ReadLine()));
                setc (System.Math.PI * 2 * geta() + getb() + System.Math.PI * 2 * geta() * getb());
                setd (System.Math.PI * geta() * geta() * getb());
                Console.WriteLine("El area de su cilindro es: " + getc());
                Console.WriteLine("El volumen de su cilindro es " + getd());
            return 0;
            }
            public double AreaPerimetroCirculo()
            {
                Console.WriteLine("Digite el radio de la circunferencia");
                setc(double.Parse(Console.ReadLine()));
                setb(getc() * 2 * System.Math.PI);
                seta (System.Math.PI * getc() * getc());
                Console.WriteLine("El area del circulo es: " + geta());
                Console.WriteLine("La longitud de la circunferencia es: " + getb());
            return 0;
            }
            public double PromedioTres()
            {
                Console.WriteLine("Digite 3 numeros enteros para saber su promedio");
                Console.WriteLine("Digite el primer numero");
                seta (double.Parse(Console.ReadLine()));
                Console.WriteLine("Digite el segundo numero");
                setb (double. Parse(Console.ReadLine()));
                Console.WriteLine("Digite el tercer numero");
                setc (double.Parse(Console.ReadLine()));
                setc (geta() + getb() + getc() / 3);
                Console.WriteLine("El promedio de sus numeros es: " + d);
            return 0;
            }

        }
    }

