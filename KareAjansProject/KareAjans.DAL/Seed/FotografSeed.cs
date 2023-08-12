using KareAjans.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.DAL.Seed
{
    internal class FotografSeed
    {
        public static List<Fotograf> fotograflar=new List<Fotograf>() 
        {
                new Fotograf{Id=1,MankenId=1},
                new Fotograf{Id=2,MankenId=2},
                new Fotograf{Id=3,MankenId=2},

        };
    }
}
