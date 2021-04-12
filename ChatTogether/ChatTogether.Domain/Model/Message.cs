using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTogether.Domain.Model
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime CreationDate { get; set; }
        public String Content { get; set; }
        public bool Read { get; set; }

        public virtual User User { get; set; }
    }
}
