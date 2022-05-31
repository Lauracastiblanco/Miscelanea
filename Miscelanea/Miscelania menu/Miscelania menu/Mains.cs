using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miscelania_menu
{
    internal class Mains

    {
        public static void Main(string[] args)
        {

            try
            {
                Menu menu = new Menu();
                menu.menu();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("-----[Ingresa un numero valido]-----");
            }
        }
    }
}

