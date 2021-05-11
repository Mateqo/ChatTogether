using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatTogether.Domain.Model
{
    public class Confirmation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime LinkSendingDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public string? Link { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
