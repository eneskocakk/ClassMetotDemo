using System;

namespace Musteri
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1000;
            musteri1.MusteriAdi = "Enes Koçak";
            musteri1.MusteriYasi = 26;
            musteri1.CalistigiKurum = "özel sektör";
            musteri1.SigortaGunu = 1000;
            
            

            Musteri musteri2 = new Musteri();
            musteri2.Id = 1001;
            musteri2.MusteriAdi = "Yusuf Ziyagil";
            musteri2.MusteriYasi = 35;
            musteri2.CalistigiKurum = "devlet memuru";
            musteri2.SigortaGunu = 2000;
           
            
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 1002;
            musteri3.MusteriAdi = "Yasin Yılmaz";
            musteri3.MusteriYasi = 28;
            musteri3.CalistigiKurum = "çalışmıyor";
            musteri3.SigortaGunu = 1900;
            




            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            
            foreach (var musteri in musteriler)
            {

                Console.WriteLine(musteri.Id+ " "+ musteri.MusteriAdi+" "  + musteri.MusteriYasi+ " "+ musteri.CalistigiKurum+ " " + musteri.SigortaGunu) ;

                Console.WriteLine("*************");
            }

            MusteriManager musteriManager = new MusteriManager();

            {
                musteriManager.Listele(musteri1);
                musteriManager.Listele(musteri2);
                musteriManager.Listele(musteri3);

            }
            Console.WriteLine("**************");

            if (musteri1.SigortaGunu<2000 )
            {
                Console.WriteLine(musteri1.MusteriAdi +" " +"bankamız müşterisi olamazsınız");
            }
             if (musteri2.SigortaGunu<2000)
            {
                Console.WriteLine(musteri2.MusteriAdi +" " + "bankamız müşterisi olamazsınız");
            }
            if (musteri3.SigortaGunu<2000)
            {
                Console.WriteLine(musteri3.MusteriAdi + " " +"bankamız müşterisi olamazsınız");
            }

            MusteriManager musteriManager1 = new MusteriManager();

            musteriManager1.Sil(musteri1);
            musteriManager1.Sil(musteri3);
            // yeni müşteri eklendi
            Console.WriteLine("***************");
            Musteri musteri4 = new Musteri();
            musteri4.Id = 1003;
            musteri4.MusteriAdi = "Hasan Yıldırım";
            musteri4.MusteriYasi = 25;
            musteri4.CalistigiKurum = "tüccar";
            musteri4.SigortaGunu = 3500;
           
            Console.WriteLine(musteri4.Id + musteri4.MusteriAdi + musteri4.MusteriYasi + musteri4.CalistigiKurum + musteri4.SigortaGunu);
            
            Console.WriteLine("***************");
            if (musteri4.SigortaGunu < 2000)
            {
                Console.WriteLine(musteri4.MusteriAdi + " " + "bankamız müşterisi olamazsınız");
            }
            else
            {
                Console.WriteLine(musteri4.MusteriAdi +" :"+"Bankamıza hoşgeldiniz");
            }
            Console.WriteLine("***************");

            MusteriManager musteriManager2 = new MusteriManager();
            musteriManager2.Ekle(musteri4);
            Console.WriteLine("***************");
            musteriManager.Listele(musteri4);
            musteriManager.Listele(musteri2);

            Console.WriteLine("Program Bitti");








        }
    }
}
