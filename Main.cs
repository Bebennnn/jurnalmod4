using System;

namespace jurnalmodul4_103022330122
{
    class kodeproduk
    {
        static void Main()
        {
            KodeProduk kodeproduk = new KodeProduk();

            Console.WriteLine("Input Produk Elektronik: ");
            String Produk = Console.ReadLine();
            String KodeProduk = kodeproduk.GetKodeProduk(Produk);    
            Console.WriteLine($"{Produk}: {kodeproduk.GetKodeProduk(Produk)}");
           
        }
    } 
}

