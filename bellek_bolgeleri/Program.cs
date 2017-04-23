using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bellek_bolgeleri
{
    class Program
    {
        public static void Main(string[] args)
        {
            //araba class ından iki tane farklı nesne oluşturduk
            //nesneler değer tipinde olduğu için stack alanında tutulur
            araba arb1 = new araba();
            //aşağıdaki veri tiplerine aktarılan değerler ise bellek bölgesinin heap alanında tutulur. Çünkü "arb1" ve "arb2", araba class ının birer kopyasıdır ve referans tipli olmaktadır. Böylece bu referans tiplerine aktarılan tüm değerlerde,doğal olarak heap bölgesinde tutulur.
            arb1.ad = "BMW";
            arb1.beygir_gucu = 300;
            arb1.modeli = 2017;

            araba arb2 = new araba();
            arb2 = arb1; //arb1 nesne örneğinin değeri arb2 nesne örneğine aktarılır. 
            arb2.ad = "fiat";
            arb2.beygir_gucu = 90;
            arb2.modeli = 2005;

            Console.WriteLine("arb1 nesne örneğine ait arabanın adı: {0}",arb1.ad);
            Console.WriteLine("arb1 nesne örneğine ait arabanın beygir gücü: {0}", arb1.beygir_gucu);
            Console.WriteLine("arb2 nesne örneğine ait arabanın modeli: {0}", arb2.modeli+"\n");
            Console.WriteLine("arb2 nesne örneğine ait arabanın adı: {0}", arb2.ad);
            Console.WriteLine("arb2 nesne örneğine ait arabanın beygir gücü: {0}", arb2.beygir_gucu);
            Console.WriteLine("arb1 nesne örneğine ait arabanın modeli: {0}", arb1.modeli);
            Console.WriteLine("**********************************************************\n");
            //sonuç: arb1 nesnesinin değerleri yerine arb2 nesnesinin değerlerini ekrana yazar

            //NEDEN?: Çünkü 22.satırda referans tipli değişkenlerden arb1, arb2 ye aktarılmıştır(eşitlenmiştir).Böylece stack alanındaki iki nesne nin adresleride birbirine eşitlenmiştir. Adresler eşit oluncada arb1 ye ait ilk değerler heap ten silinip yerine arb2 nin değerlerini alır.(bellek için heap alanında değerler kalıcı değildir!,stack bölgesindeki değer ve veri tipleri kalıcıdır)

            //**********************************************************************************

            //Şimdi bunun birde stack alanında iki farklı oluşturulan nesne için deneyelim

            kitap kp1 = new kitap();
            kp1.kitap_Adi = "Feynman Fizik Dersleri 1 - Mekanik, Işınım, Isı";
            kp1.basim_tarihi = 2016;
            kp1.sayfa_sayisi = 560;

            kitap kp2 = new kitap();
            kp2.kitap_Adi = "Albert Einstein";
            kp2.basim_tarihi = 2015;
            kp2.sayfa_sayisi = 149;

            //şimdi başta yaptığımız gibi ilk nesne örneğini ekrana yazdıralım ve farkı görelim
            Console.WriteLine("kp1 nesne örneğine ait kitabın adı: {0}",kp1.kitap_Adi);
            Console.WriteLine("kp1 nesne örneğine ait kitabın basım tarihi: {0}", kp1.basim_tarihi);
            Console.WriteLine("kp1 nesne örneğine ait kitabın sayfa sayısı: {0}", kp1.sayfa_sayisi+"\n");
            Console.WriteLine("kp2 nesne örneğine ait kitabın adı: {0}", kp2.kitap_Adi);
            Console.WriteLine("kp2 nesne örneğine ait kitabın basım tarihi: {0}", kp2.basim_tarihi);
            Console.WriteLine("kp2 nesne örneğine ait kitabın sayfa sayısı: {0}", kp2.sayfa_sayisi + "\n");


            //yukarıdaki iki kitap nesne örneği de stack alanında farklı iki adres belirttiğinden ikisi de kendi değerlerini tutar
            Console.ReadKey(true);
        }
    }
}
