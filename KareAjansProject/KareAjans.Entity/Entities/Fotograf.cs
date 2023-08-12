using KareAjans.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Entities
{
    public class Fotograf:BaseEntity
    {
        

        public string? Url { get; set; }

        public int MankenId { get; set; }

        //Mapping
        public Manken Manken { get; set; }
    }
}
