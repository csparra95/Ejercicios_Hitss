using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Prueba
    {
        private static void Main(string[] args)
        {
            Singleton s1 = Singleton.Instance;

            Console.WriteLine(s1.Metodo2());
                Console.ReadKey();
            

        }
    }
}
