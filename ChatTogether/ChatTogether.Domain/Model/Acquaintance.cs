using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatTogether.Domain.Model
{
    public class Acquaintance
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int AcquaintanceId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        
        [ForeignKey("UserId")]
        [InverseProperty("Acquaintances")]
        public virtual User User { get; set; }
        [ForeignKey("AcquaintanceId")]
        public virtual User AcqUser { get; set; }
    }
}
