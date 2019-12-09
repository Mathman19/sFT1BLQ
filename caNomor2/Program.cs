using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor2
{
    class Program
    {
        static void Main(string[] args)
        {
            int toko = int.Parse(Console.ReadLine());
            decimal[] jar = new decimal[toko];

            for (int i = 0; i < toko; i++)
            {
                Console.Write("Toko ke-" + (i + 1)+"  ");
                jar[i] = decimal.Parse(Console.ReadLine());
            }
            decimal sum = 0;
            for (int j = 0; j < toko; j++)
            {
                sum = sum + jar[j];
            }
            
            Console.Write("Habis {0} liter", (decimal)2*sum/(decimal)2.5);
            Console.ReadKey();
            
        }
    }
}
