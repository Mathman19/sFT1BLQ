using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caNomor9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jumlah kartu/gambaran? ");
            int kartu = int.Parse(Console.ReadLine());
            int kartuCom = kartu;
            Random rnd = new Random();

            while (kartu>0 && kartuCom>0)
            {
                ulang:
                Console.Write("Jummlah tawaran? ");
                int twr = int.Parse(Console.ReadLine());
                if (twr > kartu)
                {
                    Console.WriteLine("Tawaran tidak boleh lebih dari jumlah kartu");
                    goto ulang;
                }
                int ang1 = rnd.Next(0, 9);
                int A = ang1;
                int ang2 = rnd.Next(0, 9);
                int B = ang2;
                Console.Write("Ada dua kotak, A atau B, pilih mana? ");
                string ktk = Console.ReadLine().ToUpper();
                if (A==B)
                { 
                    Console.WriteLine("Kotak A : " + A);
                    Console.WriteLine("Kotak B : " + B);
                    Console.WriteLine("Pertandingan seri");
                }
                if (ktk=="A")
                {
                    if (A>B)
                    {
                        Console.WriteLine("Anda menang\nKotak A :" + A);
                        Console.WriteLine("Kotak B :" + B);
                        kartu = kartu + twr;
                        kartuCom = kartuCom - twr;                
                    }
                    if (A<B)
                    {
                        Console.WriteLine("Anda kalah\nKotak A : " + A);
                        Console.WriteLine("Kotak B : " + B);
                        kartu = kartu - twr;
                    }                    
                }
                if (ktk == "B")
                {
                    if (A > B)
                    {
                        Console.WriteLine("Anda kalah\nKotak A : " + A);
                        Console.WriteLine("Kotak B : " + B);
                        kartu = kartu - twr;
                    }
                    if (A < B)
                    {
                        Console.WriteLine("Anda menang\nKotak A : " + A);
                        Console.WriteLine("Kotak B : " + B);
                        kartu = kartu + twr;
                    }
                }
                Console.WriteLine("Kartu Anda sekarang " + kartu);
                Console.WriteLine("Kartu Computer sekarang " + kartuCom);
                Console.Write("Masih mau main lagi?(y/n)");
                string nyr = Console.ReadLine();
                if (nyr=="n")
                {
                    Console.WriteLine("Anda kalah karena menyerah");
                    Console.ReadKey();
                    return;
                }
            }
            if (kartu == 0)
            {
                Console.WriteLine("Anda kalah dalam permainan");
            }
            if (kartuCom == 0)
            {
                Console.WriteLine("SELAMAT Anda menang!");
            }
            Console.ReadKey();
        }
    }
}
