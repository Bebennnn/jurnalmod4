using System;

//namespace jurnalmodul4_103022330122
//{
//    class kodeproduk
//    {
//        static void Main()
//        {
//            KodeProduk kodeproduk = new KodeProduk();

//            Console.WriteLine("Input Produk Elektronik: ");
//            String Produk = Console.ReadLine();
//            String KodeProduk = kodeproduk.GetKodeProduk(Produk);    
//            Console.WriteLine($"{Produk}: {kodeproduk.GetKodeProduk(Produk)}");

//        }
//    } 
//}

namespace jurnalmodul4_103022330122
{
    class Mfanlaptop
    {
        static void Main()
        {
            FanLaptop fan = new FanLaptop();

            while (true)
            {
                Console.WriteLine("\nMasukkan perintah (Balanced, Performance, Turbo): ");
                String input = Console.ReadLine().ToLower();

                if (input == "Balanced")
                {
                    fan.Balanced();
                }
                else if (input == "Performance")
                {
                    fan.Performance();
                }
                else if (input == "Turbo")
                {
                    fan.Turbo();
                }
            }
        }
    }
}