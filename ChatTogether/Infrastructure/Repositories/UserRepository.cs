using ChatTogether.Domain.Interface;
using ChatTogether.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
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

        public string GetSalt(string nickName)
        {
            return _context.AppUsers.FirstOrDefault(x => x.Nickname == nickName).Salt;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.AppUsers.Include(x=>x.Acquaintances);
        }

        public IEnumerable<Acquaintance> GetAcquaintances()
        {
            return _context.Acquaintances;
        }

        public void AcceptFriend(int userId, int friendId)
        {
            var acquaintances = _context.Acquaintances.FirstOrDefault(x => x.UserId == friendId && x.AcquaintanceId == userId);

            if(acquaintances !=null)
            {
                acquaintances.ConfirmationDate = DateTime.Now;
                Acquaintance newAcquaintances = new Acquaintance()
                {
                    UserId = userId,
                    AcquaintanceId = friendId,
                    CreationDate = acquaintances.CreationDate,
                    ConfirmationDate = acquaintances.ConfirmationDate
                };

                _context.SaveChanges();
            }          
        }

        public void RejectFriend(int userId, int friendId)
        {
            var acquaintances = _context.Acquaintances.FirstOrDefault(x => x.UserId == friendId && x.AcquaintanceId == userId);

            if (acquaintances != null)
            {
                _context.Acquaintances.Remove(acquaintances);

                _context.SaveChanges();
            }
        }

    }
}
