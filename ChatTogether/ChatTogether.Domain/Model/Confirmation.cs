using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTogether.Domain.Model
{
    public class Confirmation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public bool Confirmed { get; set; }
        public String Link { get; set; }

        public virtual User User { get; set; }
    }
}
