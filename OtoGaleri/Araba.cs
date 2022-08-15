using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri
{
    public class Araba
    {
       
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public float KiralamaBedeli { get; set; }
        public int KiralamaSayisi { get; set; }
        public ARABA_TIPI Araba_Tipi ;
        public DURUM Durum;
        public Araba()
        {
            Console.WriteLine("Plaka: ");
            this.Plaka = Console.ReadLine();
            Console.WriteLine("Marka: ");
            this.Marka = Console.ReadLine();
            Console.WriteLine("Kiralama Bedeli: ");
            this.KiralamaBedeli = float.Parse(Console.ReadLine());
            Console.WriteLine("Araba Tipi: \nSuv 1\nHatchback 2\nSedan 3");
            this.Araba_Tipi = (ARABA_TIPI)int.Parse(Console.ReadLine()) ; 
            
        }
    }
    public enum ARABA_TIPI
    {
        Empty, SUV, Hatchback, Sedan
    }
    public enum DURUM
    {
        Empty, Kirada, Galeride
    }
}
