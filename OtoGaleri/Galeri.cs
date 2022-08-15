using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoGaleri
{
    public class Galeri
    {
        public List<Araba> Arabalar = new List<Araba>();
        public void ArabaEkle()
        {
            Araba Araba = new Araba();
            this.Arabalar.Add(Araba);
            Console.WriteLine(Arabalar.Count);
            Arabalar.ForEach(x => Console.WriteLine($"{x.Plaka} { x.Marka} {x.KiralamaBedeli} {x.KiralamaSayisi} {x.Araba_Tipi}"));
        }







    }
    
}
