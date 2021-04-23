using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using System.Collections.Generic;
using System.Linq;

namespace ChatTogether.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;

        public UserRepository(Context context)
        {
            _context = context;
        }

        // Tutaj dodajemy definicje naszego repozytorium

        //Przykład
        //IQueryable<User> GetAllUsers();

        public int AddUser(User newUser)
        {
            _context.AppUsers.Add(newUser);
            _context.SaveChanges();

            return newUser.Id;
        }

        public User GetUser(string nickName)
        {           
            return _context.AppUsers.FirstOrDefault(x => x.Nickname == nickName);
        }

        public IEnumerable<User> GetUsers(string input)
        {
            return _context.AppUsers.Where(x=>x.Nickname.Contains(input));
        }

    }
}
