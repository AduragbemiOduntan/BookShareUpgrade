using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Domain.Model
{
    public class BaseEntity
    {
        public DateTime DateAdded { get; set; } = DateTime.UtcNow.AddHours(1);
        public DateTime DateModified { get; set; }
        public bool IsDeleted { get; set; }
        //public string CreatorId { get; set; }
    }
}
