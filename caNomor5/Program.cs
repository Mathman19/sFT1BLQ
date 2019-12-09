using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Laki-laki dewasa: ");
            int lk = int.Parse(Console.ReadLine());
            Console.Write("Perempuan dewasa: ");
            int prm = int.Parse(Console.ReadLine());
            Console.Write("Remaja: ");
            int rmj = int.Parse(Console.ReadLine());
            Console.Write("Anak-anak: ");
            decimal ank = decimal.Parse(Console.ReadLine());
            Console.Write("Balita: ");
            int blt = int.Parse(Console.ReadLine());
            decimal jml = lk + prm + rmj + ank + blt;

            if (jml % 2 == 1 && jml > 5)
            {
                Console.WriteLine(2 * lk + 2 * prm + rmj + 1/2 * ank + blt);
            }
            else
            {
                Console.WriteLine(2 * lk + prm + rmj + 1/2 * ank + blt);
            }
            Console.ReadKey();
        }
    }
}
