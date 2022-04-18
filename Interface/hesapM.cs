using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppodev_1
{
    public interface  Iislem
    {
        void topla();
        void carp();
    }
    public class Hesap : Iislem
    {
        public void carp()
        {
            Console.Write("Birinci Sayıyı Gir: ");
            int carpim;
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Gir: ");

            int sayi2 = Convert.ToInt32(Console.ReadLine());

            carpim = Convert.ToInt16(sayi1) * Convert.ToInt16(sayi2);
            Console.WriteLine("iki Sayının Çarpımı :" + carpim);
            Console.ReadKey();
         
        }

        public void topla()
        {
            Console.Write("Birinci Sayıyı Gir: ");
            int topla;
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci Sayıyı Gir: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            topla = Convert.ToInt16(sayi1) + Convert.ToInt16(sayi2);

            Console.WriteLine("iKİ SAYININ TOPLAMI:" + topla);
            Console.ReadKey();
            

        }
    }
}
