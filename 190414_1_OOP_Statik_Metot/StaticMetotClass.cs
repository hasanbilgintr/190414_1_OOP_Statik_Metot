using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _190414_1_OOP_Statik_Metot
{
    class StaticMetotClass
    {
        public static string[] isimListesi() //statik sadece sayfada görünür
        {
            string[] isimler = { "Ali", "Samet", "Sevgi", "Rüya" };
            return isimler;
        }
        public static int c = 100;

    }
}
