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
        public static int sayac = 1;
        public int ID;
        public string no;
        public string ad;
        public string soyAd;
        public string sube;

        public student(List<student> stu)
        {


            ogrenciEkle(stu);

        }
        public student(int a) { }
        public void ogrenciEkle(List<student> stu)
        {


            ID = random.Next();
            Console.WriteLine("ID: " + ID);

            Console.WriteLine(sayac + ". Öğrencinin");
            Console.Write("No: ");
            no = Console.ReadLine();
            int noInt = int.Parse(no);
            stu.Exists(x=> x.no.Equals(noInt)); 
              
            //if (noInt == check) { }
            Console.Write("Adı: ");
            ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            soyAd = Console.ReadLine();
            Console.Write("Şubesi: ");
            sube = Console.ReadLine();


        }
        public void ogrenciListele(List<student> stu)
        {
            Console.Clear();
            if (stu.Count == 0) { Console.WriteLine("Gösterilecek öğrenci yok.\n\n"); }
            else
            {
                Console.WriteLine("Seçiminiz: 2");
                Console.WriteLine("Şube    " + "No    " + "Ad Soyad");
                Console.WriteLine("----------------------------------");
                stu.ForEach(
                    studen => Console.WriteLine($"{studen.sube} {studen.no,7} {studen.ad[0].ToString().ToUpper(),7}{studen.ad.Substring(1).ToLower()} {studen.soyAd[0].ToString().ToUpper()}{studen.soyAd.Substring(1).ToLower()}"));

                Console.WriteLine();
            }
        }
        public void ogrenciSil(List<student> stu)
        {


            Console.Clear();
            Console.WriteLine("Seçiminiz: 3");
            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No: ");
            string sil = Console.ReadLine();
            int silInt = int.Parse(sil);
            //stu.Exists(x => x.no.Equals(sil));
            //stu.ForEach(studen => Console.WriteLine("Senin öğrencin" + stu.FindIndex(x=> x.no==sil)));
            Console.WriteLine("Şube    " + "No    " + "Ad Soyad");
            Console.WriteLine("----------------------------------");
            stu.ForEach(
              studen =>
              Console.WriteLine($"{studen.sube} {studen.no,7} {studen.ad,7} {studen.soyAd}"));
            Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
            string check = Console.ReadLine();
            if (check.ToUpper() == "E")
            {
                //  stu.ForEach(
                //studen => 
                //Console.WriteLine($"{studen.sube} {studen.no,7} {studen.ad,7} {studen.soyAd}"));
                bool a = stu.Exists(x => x.no.Equals(sil));
                if (a == true)
                {
                    stu.RemoveAll(x => x.no.Equals(sil));


                    Console.WriteLine("Öğrenci silindi");

                }
                else if (a == false) { Console.WriteLine("Böyle bir öğrenci bulunamadı."); }
            }
            if (check.ToUpper() == "H") { Console.WriteLine("Öğrenci silinmedi."); }

        }
        public void SecimAl(string secim)
        {

            secim = Console.ReadLine();
        }
    }
}
