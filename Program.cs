using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurnalmodul4_103022330122
{

    class KodeProduk
    {
        public static Dictionary<string, string> TKodeproduk = new Dictionary<string, string>
    {
            {"Laptop","E100"},
            {"Smartphone","E101"},
            {"Tablet","E102"},
            {"Headset","E103"},
            {"Keyoard","E104"},
            {"Mouse","E105"},
            {"Printer","E106"},
            {"Monitor","E107"},
            {"Smartwatch","E108"},
            {"Kamera","E109"}
    };
        public string GetKodeProduk(string produk)
        {
               if (TKodeproduk.ContainsKey(produk))
            {
                return TKodeproduk[produk];
            }
            return "Produk tidak ada";
        }

    }
}
