using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)

        {
            while (true) // Tüm işlemlerin birleştiği main kısmı ben genelde programı tekrar tekrar F5 atıp açmaktansa döngüye almayı tercih ediyorum çalışmalarımda. 

            {
                int oklno = OgrNo();
                Console.WriteLine("\0");
                int randsayi = rndSayi();
                Console.WriteLine("\0");
                asalKontrol(oklno, randsayi);
                Console.WriteLine("\0");
                Console.ReadKey();
            }
        }

        static int OgrNo() // Kullanıcımızdan okul numarasının son 3 hanesini aldığımız fonksiyon. 

        {

            Console.Write("Okul numaranızın son 3 hanesini giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi > 999)
            {
                Console.WriteLine("Hatalı Giriş Sistem Kapatılacaktır.");
            }
            else
            {
                return sayi;
            }
        }

        static int rndSayi() // Sistemin random sayı ürettiği fonksiyon. 

        {
            Random rnd = new Random();
            int rastgeleSayi = rnd.Next(100, 1000);
            Console.WriteLine("Sistemin belirlediği random sayı: " + rastgeleSayi);
            return rastgeleSayi;
        }

        static void asalKontrol(int sayi1, int sayi2) // Okul numarası ile Random sayımızın aralarında asal olup olmadığını kontrol eden döngüyü içeren fonksiyon. 

        {
            int kucukolan = 0;
            if (sayi1 > sayi2)
            {
                kucukolan = sayi2;
            }
            else
            {
                kucukolan = sayi2;
            }
            for (int i = 2; i < kucukolan; i++)
            {
                if (sayi1 % i == 0 && sayi2 % i == 0)
                {
                    Console.WriteLine("Aralarında Asal Değildir.");
                    break;
                }
                if (i == kucukolan - 1)
                {
                    Console.WriteLine("Aralarında Asaldır");
                }
            }

        }
    }
}
