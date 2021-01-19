using System;
using System.Collections.Generic;
using System.Text;

namespace Musteri
{
    class MusteriManager

    {
        public void Listele(Musteri musteri)



        {
            Console.WriteLine("Listelenen Müşteriler:" +musteri.MusteriAdi );
        }

        public void Sil(Musteri musteri) 
        {
            Console.WriteLine("Silinen Müşteriler:" + musteri.MusteriAdi);

        }

        public void Ekle (Musteri musteri)
        {
            Console.WriteLine("Eklenen Müşteriler:" + musteri.MusteriAdi);
        }
    }
}

