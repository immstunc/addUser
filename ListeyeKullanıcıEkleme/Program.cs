using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListeyeKullanıcıEkleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Listeye kullanıcı ekleme uygulaması 
            //listeye eklenecek kullanıcı sayısı dışarıdan alınacak
            //alındıktan sonra kişiler listeye  eklencek
            //liste dolduktan sonra liste ekrana yazılacak

            Console.WriteLine("-----Kullanıcı Listesi Oluşturma-----");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("----Listede Kaç Kullanıcı Olacak?----");
            Console.Write("Kişi Sayısı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            string[] kullanicilar = new string[sayi];
            Console.WriteLine("----{0} Kişilik Liste Oluşturuldu----", sayi);
            Console.WriteLine("----" + sayi + " Kişilik Liste Oluşturuldu----");
            Console.WriteLine("-------Listeye Kullanıcı Ekle-------");

            for (int i = 0; i < sayi; i++)
            {
                Console.Write((i + 1) + ". Kişiyi Ekle: ");
                kullanicilar[i] = Console.ReadLine();
            }

            Console.WriteLine("-------Kullanıcılar Listesi-------");

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine((i + 1) + ". " + kullanicilar[i]);
            }

            Console.ReadKey();

        }
    }
}
