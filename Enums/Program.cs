using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kategoriler.Elektronik);
            Console.WriteLine((int)Kategoriler.Elektronik);

            Console.ReadKey();
        }

        enum Kategoriler
        {
            Elektronik = 3,
            Hırdavat = 2,
            Gıda = 1,
            Güzellik = 4,
            Giyim = 5
        }
    }
}
