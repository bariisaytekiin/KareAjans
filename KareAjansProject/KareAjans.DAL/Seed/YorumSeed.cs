using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class YorumSeed
    {
        public static List<Yorum> yorumlar=new List<Yorum>() 
        {
            new Yorum(){Id=1,Mesaj="İlerlemesi güzel",MankenId=1 },
            new Yorum(){Id=2,Mesaj="Çok sessiz",MankenId=2 },
            new Yorum(){Id=3,Mesaj="Çok sessiz",MankenId=2 },
        };

    }
}
