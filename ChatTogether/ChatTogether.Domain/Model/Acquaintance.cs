using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTogether.Domain.Model
{
    public class Acquaintance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AcquaintanceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ConfirmationDate { get; set; }
        
        public virtual User User { get; set; }
    }
}
