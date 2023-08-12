using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class AdresSeed
    {
        public static List<Adres> adresler=new List<Adres>() 
        { 
            new Adres{Id=1,AcikAdres="Yeni Mah. No:89 D:4 Pendik",Sehir="İstanbul"},
            new Adres{Id=2,AcikAdres="Cumhuriyet Mah. No:8 D:9 Kartal",Sehir="İstanbul"},
            new Adres{Id=3,AcikAdres="Zaman Mah. No:30 Kızılay",Sehir="Ankara"}
        };
    }
}
