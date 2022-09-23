using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace kubra
{
    class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public char Cins { get; set; }
        public DateTime DogumTarih { get; set; }
        public string Cadde { get; set; }
        public int KapiNo { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public int Maas { get; set; }
        public string GetTitle()
        {
            if (Cins=='E')
            {
                return "Sn Bay " + Ad + " " + Soyad;

            }
            else
            {
                return "Sn Bayan" + Ad + " " + Soyad;
            }
        }
        public int GetAge()
        {
            DateTime today= DateTime.Now;
            int yas = today.Year-DogumTarih.Year;
            DateTime DogumGunu=DogumTarih.AddYears(yas);
            if(DogumGunu<today)
            {
                yas = yas + 1;

            }

            return yas;


        }
        public List<String> GetAdres()
        {
            List<String> adress = new List<String>();
            adress.Add(Cadde);
            adress.Add(KapiNo.ToString());
            adress.Add(Ilce + "/" + Sehir);
            return adress;
        }
        public String GetAdres2()
        {
            return $" Şehir {Sehir}\n No {KapiNo}\n" +  $"{Ilce + Sehir}";


        }
        public string[] GetAdres3()
        {
            string[] adress= {Cadde, KapiNo.ToString(), Ilce + "%"+ Sehir};
            return adress;
        }
    }
}
