using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Beli pulsa berapa? ");
            int pulsa = int.Parse(Console.ReadLine());
            
                       

            if (pulsa > 30000)
            {
                point2(pulsa);
            }
            if (pulsa > 10000 && pulsa <= 30000)
            {
                point1(pulsa);
            }
            if (pulsa < 10000)
            {
                Console.WriteLine("0 point");
            }

            Console.ReadKey();
        }
        static void point2(int n)
        {
            int poin = 0;
            int hasil = 0;
            poin = n - 30000;
            hasil = 2*(poin / 1000);

            point1(30000, hasil);
        }
        static void point1(int x, int y)
        {
            int poin = 0;
            int hasil = 0;
            poin = x - 10000;
            hasil = poin / 1000;

            Console.WriteLine("Anda dapat {0} point",hasil + y);
            
        }
        static void point1(int x)
        {
            int poin = 0;
            int hasil = 0;
            poin = x - 10000;
            hasil = poin / 1000;

            Console.WriteLine("Anda dapat {0} point",hasil);   
        }
    }
}
