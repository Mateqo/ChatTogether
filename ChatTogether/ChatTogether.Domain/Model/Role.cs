using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatTogether.Domain.Model
{
    public class Role
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public ICollection<UserRole> AppUserRoles { get; set; }
    }
}
