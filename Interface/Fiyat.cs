using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppodev_1
{
    public abstract class Fiyat
    {
      public abstract  void urunler();
    }
    public class Kalem: Fiyat
    {
        public override void urunler()
        {
            int fiyat, adet,tutar;
            Console.Write("Ürün Fiyatını Girin :");
            fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ürün Adet:");
            adet = Convert.ToInt32(Console.ReadLine());
            tutar = fiyat * adet;
            Console.WriteLine("Ürün Fiyatı:{0}", tutar);
            Console.ReadKey();
        }
    }

}
