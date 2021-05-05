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
        public string Nickname { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string EmailAddress { get; set; }
        public string EncryptedPassword { get; set; }
        public string Salt { get; set; }
        public DateTime CreationDate { get; set; }
        public bool Active { get; set; }

        public string Token { get; set; }

        public Confirmation Confirmation { get; set; }
        public virtual ICollection<Acquaintance> Acquaintances { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<UserRole> AppUserRoles { get; set; }
    }
}
