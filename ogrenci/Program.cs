

using ogrenci;
using System.Linq;

List<student> stu = new List<student>();
student stuMethod = new student(1);
int say = 0;
while (say < 10)
{
    say++;
    Console.WriteLine("Öğrenci Yönetim Uygulaması\n" +
    "1- Öğrenci Ekle (E)\n" +
    "2- Öğrenci Listele (L)\n" +
    "3- Öğrenci Sil (S)\n" +
    "4- Çıkış (X)\n");
 
    string secim = Console.ReadLine();
    //Console.WriteLine("Seçiminiz: " + secim);
    if (secim == "1" || secim.ToUpper() == "E")
    {
        Console.WriteLine("Öğrenci ekle ----------");


        stu.Add(new student(stu));
        Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? E/H"); string check = Console.ReadLine(); if (check == "1" || check.ToUpper() == "E")
        {
            student.sayac++;
            Console.WriteLine("Öğrenci eklendi");
        }
        else
        { stu.Remove(stu.Last()); Console.WriteLine("Öğrenci eklenmedi"); }
    }
    //case "1": case "E": student ogrenci = new student(); //ogrenci.ogrenciEkle(); break; NORMAL YOL
    else if (secim == "2" || secim.ToUpper() == "L")
    {

        stuMethod.ogrenciListele(stu);

    }

    else if (secim == "3" || secim.ToUpper() == "S")
    {
        if (stu.Count() == 0)
        {
            Console.Clear();
            Console.WriteLine("Listede silinecek öğrenci yok.\n\n");


        }
        else { stuMethod.ogrenciSil(stu); }
    }
    else if (secim == "4" || secim.ToUpper() == "X")
    {

        break;
    }

}