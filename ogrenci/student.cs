using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ogrenci
{
    public class student
    {
        Random random = new Random();
        public int ID;
        public string no;
        public string ad;
        public string soyAd;
        public string sube;
        public student()
        {


            ID = random.Next();
            Console.WriteLine("ID: " + ID);
            
            Console.Write("No: ");
            no = Console.ReadLine();
            Console.Write("Adı: ");
            ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            soyAd = Console.ReadLine();
            Console.Write("Şubesi: ");
            sube = Console.ReadLine();
        }
        public void ogrenciEkle()
        {
            Console.WriteLine("ÖĞRENCİ EKLE METHOD");
            Console.WriteLine("No gir: ");
            no = Console.ReadLine();
            Console.WriteLine("Ad gir: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyad gir: ");
            soyAd = Console.ReadLine();
            Console.WriteLine("Sube gir: ");
            sube = Console.ReadLine();
        }
    }
}
