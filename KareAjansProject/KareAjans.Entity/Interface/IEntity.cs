using KareAjans.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Interface
{
    public interface IEntity
    {
        public int Id { get; set; }//int tipindeki idmiz ise bizim sıralı idmiz olucak ve dışardan erişimi olmayacak.
        

        //Created 
        public DateTime CreatedDate { get; set; }
        

        //Update
        public DateTime UpdatedDate { get; set; }
        

        //IsActive
        public bool IsActive { get; set; }
        public Status Status { get; set; }
    }
}
