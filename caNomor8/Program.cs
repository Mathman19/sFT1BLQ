using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor8
{
    class Program
    {
        static void Main(string[] args)
        {
            ulang:
            Console.Write("Masukkan PIN: ");
            int pin = int.Parse(Console.ReadLine());
            if (pin == 123456)
            {
                Console.WriteLine("Uang yang ingin disetor? ");
                int saldo = int.Parse(Console.ReadLine());

                Console.WriteLine("Pilihan tranfer?\n 1. Antar rekening\t2.Antar Bank");
                int input = int.Parse(Console.ReadLine().ToUpper());

                if (input == 1)
                {
                    rek(saldo);
                }
            }
            else
            {
                Console.Write("PIN salah");
                goto ulang;
            }
            Console.ReadKey();
        }
        static void rek(int saldo)
        {
            ulang:
            Console.Write("Masukkan rekening tujuan: ");
            string rekLain = Console.ReadLine();
            if (rekLain.Length!=10)
            {
                Console.WriteLine("Panjang rekening harus 10 digit");
                goto ulang;
            }
        }
    }
}
