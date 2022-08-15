using OtoGaleri;
using System.Text.RegularExpressions;

Galeri Galeri = new Galeri();

Uygulama();
void Uygulama() {
    while (true)
    {
        Menu();
        string secim = Console.ReadLine();
        switch (secim)
        {
            case "1": case "K": ArabaKirala(); break;
            //case "2": case "T": ArabaTeslimAl();              break;          
            //case "3": case "R": KiradakiArabalarıListele();   break;
            //case "4": case "M": GaleridekiArabalarıListele(); break;
            case "5": case "A": TumArabalariListele(); break;
            //case "6": case "I": Kiralamaİptali();             break;
            case "7": case "Y": Galeri.ArabaEkle(); break;
            case "8": case "S": ArabaSil(); break;
            case "9": case "G": BilgileriGoster();            break;
            default: break;

        }

    }
     }







void Menu()
{
    Console.WriteLine("Galeri Otomasyon");
    Console.WriteLine("1 - Araba Kirala(K)");
    Console.WriteLine("2 - Araba Teslim Al(T)");
    Console.WriteLine("3 - Kiradaki Arabaları Listele(R)");
    Console.WriteLine("4 - Galerideki Arabaları Listele(M)");
    Console.WriteLine("5 - Tüm Arabaları Listele(A)");
    Console.WriteLine("6 - Kiralama İptali(I)");
    Console.WriteLine("7 - Araba Ekle(Y)");
    Console.WriteLine("8 - Araba Sil(S)");
    Console.WriteLine("9 - Bilgileri Göster(G)");

}
void TumArabalariListele()
{
    Galeri.Arabalar.ForEach(x => Console.WriteLine($"{x.Plaka} {x.Marka} {x.KiralamaBedeli} {x.KiralamaSayisi} {x.Araba_Tipi}"));
}


















void ArabaKirala()
{
    
    Regex regex = new Regex("([0-9]{1,2})([a-zA-Z]{1,3})([0-9]{1,4})$");
     // saatler verdim regex için, 00 ile başlayan plaka sorunu var.
    Console.Write("Kiralanacak arabanın plakası: ");
    string kiralanacakArabaPlakasi = Console.ReadLine();
    byte byteKAP;
    if(  regex.IsMatch(kiralanacakArabaPlakasi) == true)
    { 
        Console.WriteLine("DOruğ");
        if (Galeri.Arabalar.Exists(x => x.Plaka.Equals(kiralanacakArabaPlakasi))) { Console.WriteLine("Var lan bu araba"); }
        else { Console.WriteLine("Yokmuş lan"); }
    }
    regex.Match(kiralanacakArabaPlakasi);
    if(regex.IsMatch(kiralanacakArabaPlakasi)== false) 
    { 
        Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin."); 
    }
    //try 
    //{
    //    string kAP = kiralanacakArabaPlakasi.Substring(0, 2);
    //    byte.TryParse(kAP, out byteKAP);
    //    if (kiralanacakArabaPlakasi.Length < 9 && kiralanacakArabaPlakasi.Length > 4)
    //    {

    //        Console.WriteLine("9 haneden küçük 4 haneden büyük");
    //        if (byteKAP >= 01 && byteKAP <= 99)
    //        {
    //            Console.WriteLine("Başarılı");
    //        }
    //    }

    //    else { Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin."); }
    //}
    //catch (System.ArgumentOutOfRangeException) 
    //{ 
    //    Console.WriteLine("Bu şekilde plaka girişi yapamazsınız. Tekrar deneyin."); 
    //}
    
    
     
   
}



























void ArabaSil()
{
    Console.Write("Silmek istediğiniz arabanın plakasını giriniz: ");
    string sil = Console.ReadLine();
    bool silKontrol = Galeri.Arabalar.Exists(x => x.Plaka.Equals(sil));
    if (silKontrol)
    {
        Galeri.Arabalar.RemoveAll(x => x.Plaka.Equals(sil));
        Console.WriteLine("Araba silindi.");
    }
}
void BilgileriGoster()
{
    Console.WriteLine("Toplam araba sayısı: " + Galeri.Arabalar.Count());
    //Console.WriteLine("Kiradaki araba sayısı: " + Galeri.Arabalar.Count());
    //Console.WriteLine("Bekleyen araba sayısı: " );
    //Console.WriteLine("Toplam araba kiralama süresi: ");
    //Console.WriteLine("Toplam araba kiralama adedi: ");
    //Console.WriteLine("Ciro: ");
}