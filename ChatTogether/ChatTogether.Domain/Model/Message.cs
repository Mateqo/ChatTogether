using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatTogether.Domain.Model
{
    public class Message
    {
        public int Id { get; set; }
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReceivementDate { get; set; }
        public string Content { get; set; }

        [ForeignKey("SenderId")]
        [InverseProperty("Messages")]
        public virtual User Sender { get; set; }
        [ForeignKey("ReceiverId")]
        public virtual User Receiver { get; set; }
    }
}
