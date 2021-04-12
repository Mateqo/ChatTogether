using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTogether.Domain.Model
{
    public class User
    {
        public int Id { get; set; }
        public String Nickname { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String EmailAddress { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Acquaintance> Acquaintances { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Confirmation> Confirmations { get; set; }
        public virtual ICollection<UserRole> AppUserRoles { get; set; }
    }
}
