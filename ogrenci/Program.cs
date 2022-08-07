using ogrenci;
using System.Linq;

List<student> stu = new List<student>();


while (true)
{
    Console.WriteLine("Öğrenci Yönetim Uygulaması\n" +
    "1- Öğrenci Ekle (E)\n" +
    "2- Öğrenci Listele (L)\n" +
    "3- Öğrenci Sil (S)\n" +
    "4- Çıkış (X)\n");
    Console.Write("Seçim yapın: ");
    string secim = Console.ReadLine();
    Console.WriteLine("Seçiminiz: " + secim);
    if (secim == "1" || secim.ToUpper() == "E")
    {
        stu.Add(new student());
        Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? E/H"); string check = Console.ReadLine(); if (check == "1" || check.ToUpper() == "E")
        {
            Console.WriteLine("Öğrenci eklendi");
        }
        else
        { stu.Remove(stu.Last()); Console.WriteLine("Öğrenci eklenmedi"); }
    }
    //case "1": case "E": student ogrenci = new student(); //ogrenci.ogrenciEkle(); break; NORMAL YOL
    else if (secim == "2" || secim.ToUpper() == "L")
    {
        Console.WriteLine(stu.Count());
        stu.ForEach(
            studen => Console.WriteLine($"Öğrenci adı: {studen.ad}, öğrenci no: {studen.no}, soyadı: {studen.soyAd}, şube:{studen.sube}"));
    }

    else if (secim == "3" || secim.ToUpper() == "S")
    {
        stu.ForEach(
          studen => Console.WriteLine($"Öğrenci adı: {studen.ad}, öğrenci no: {studen.no}, soyadı: {studen.soyAd}, şube:{studen.sube}"));
        Console.WriteLine("sil no: ");
        string sil = Console.ReadLine();
        bool a = stu.Exists(x => x.no.Equals(sil));
        if (  a ==true) 
        {
            stu.RemoveAll(x => x.no.Equals(sil));
               
                
            Console.WriteLine("Okkey"); 

        }
        else { Console.WriteLine("yok"); }
    }
}