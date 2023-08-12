using KareAjans.Entity.Enums;
using KareAjans.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KareAjans.Entity.Base
{
    public abstract class BaseEntity : IEntity//MasterId guid tipinde olucak.
    {
        public BaseEntity()
        {
            IsActive = true;
            Status = Status.Created;
            CreatedDate = DateTime.Now;
        }

        public int Id { get ; set ; }
        public DateTime CreatedDate { get ; set ; }
        public DateTime UpdatedDate { get ; set ; }
        public bool IsActive { get ; set ; }
        public Status Status { get ; set ; }
    }
}
