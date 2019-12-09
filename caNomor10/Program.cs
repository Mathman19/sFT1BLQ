using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan range ");
            int range = int.Parse(Console.ReadLine());
            int[] arrPrim = new int[range];
            arrPrim[0] = 2;
            int tmp=0;

            for (int i = 1; i < range; i++)
            {
                for (int j = arrPrim[i-1]+1; j < range*range; j++)
                {
                    for (int k = 1; k <= j; k++)
                    {
                        if (j%k==0)
                        {
                            tmp++;
                        }
                    }
                    if (tmp == 2)
                    {
                        arrPrim[i] = j;
                        break;
                    }
                    tmp = 0;
                }
            }
            foreach (var item in arrPrim)
            {
                Console.Write(item+"\t");
            }
            Console.WriteLine();

            int[] arrFib = new int[range+1];
            arrFib[0] = 0;
            arrFib[1] = 1;
            for (int m = 1; m < range; m++)
            {
                arrFib[m + 1] = arrFib[m] + arrFib[m - 1]; ;
            }

            for (int o = 0; o < range; o++)
            {
                Console.Write(arrFib[o] + "\t");
            }

            int sum = 0;
            int sum1 = 0;
            Console.WriteLine();
            int[] hasil = new int[range];
            for (int n = 0; n < range; n++)
            {
                hasil[n] = arrPrim[n] + arrFib[n];
                Console.Write(hasil[n] + "\t");
            }
            Console.ReadKey();
        }
    }
}
