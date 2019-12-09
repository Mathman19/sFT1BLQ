using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pilih 1 atau 2");
            Console.WriteLine("1. Player main dahulu \t 2. Computer main dahulu");
            int pilih = int.Parse(Console.ReadLine());

            if (pilih == 1)
            {
                bermain1();
            }
            if (pilih == 2)
            {
                Random rnd = new Random();
                int angka2 = rnd.Next(0, 9);
                Console.WriteLine("Computer sudah memilih");
                bermain2(angka2);
            }

        }
        static void bermain1()
        {
            Console.WriteLine("Masukkan angka antara 0 - 9: ");
            int angka = int.Parse(Console.ReadLine());
            Random rnd = new Random();
            int angka2 = rnd.Next(angka-1, 9);

            Console.WriteLine("Angka komputer " + angka2);
            if (angka > angka2)
            {
                Console.Write("You Win");
            }
            else if (angka == angka2)
            {
                Console.WriteLine("Permainan seri");
            }
            else
            {
                Console.Write("You Lose");
            }
            Console.ReadKey();
        }
        static void bermain2(int com)
        {
            Console.WriteLine("Masukkan angka antara 0 - 9: ");
            int angka = int.Parse(Console.ReadLine());
            

            Console.WriteLine("Angka komputer " + com);
            if (angka > com)
            {
                Console.Write("You Win");
            }
            else if (angka == com)
            {
                Console.WriteLine("Permainan seri");
            }
            else
            {
                Console.Write("You Lose");
            }
            Console.ReadKey();
        }
    }
}
