using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jika harga kopi 18.000");
            int kopi = 18000;
            //int opo = int.Parse(Console.ReadLine());
            int diskon1 = 0;
            int n = 0;
            while (diskon1<100000)
            {
                n++;
                diskon1 = kopi*n*1/2;
            }
            if (diskon1 > 100000)
            {
                diskon1 = 100000;
                n = n - 1;
            }
            Console.WriteLine(n);
            Console.ReadKey();
        }
    }
}
