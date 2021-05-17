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

        public User GetUserById(int id)
        {
            return _context.AppUsers.FirstOrDefault(x => x.Id == id);
        }

        public string GetSalt(string nickName)
        {
            return _context.AppUsers.FirstOrDefault(x => x.Nickname == nickName).Salt;
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.AppUsers.Include(x => x.Acquaintances);
        }

        public IEnumerable<Acquaintance> GetAcquaintances()
        {
            return _context.Acquaintances.Include(x=>x.AcqUser).Include(x=>x.User);
        }

        public void AcceptFriend(int userId, int friendId)
        {
            var acquaintances = _context.Acquaintances.FirstOrDefault(x => x.UserId == friendId && x.AcquaintanceId == userId);

            if (acquaintances != null)
            {
                acquaintances.ConfirmationDate = DateTime.Now;
                Acquaintance newAcquaintances = new Acquaintance()
                {
                    UserId = userId,
                    AcquaintanceId = friendId,
                    CreationDate = acquaintances.CreationDate,
                    ConfirmationDate = acquaintances.ConfirmationDate
                };
                _context.Acquaintances.Add(newAcquaintances);
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

        public void AddFriend(int userId, int friendId)
        {
            var acquaintances = _context.Acquaintances.FirstOrDefault(x => x.UserId == userId && x.AcquaintanceId == friendId);
            var isAcq = _context.Acquaintances.FirstOrDefault(x => x.UserId == friendId && x.AcquaintanceId == userId);

            if (acquaintances == null && isAcq == null)
            {
                Acquaintance newAcquaintances = new Acquaintance()
                {
                    UserId = userId,
                    AcquaintanceId = friendId,
                    CreationDate = DateTime.Now,
                    ConfirmationDate = null
                };
                _context.Acquaintances.Add(newAcquaintances);
                _context.SaveChanges();
            }
        }

        public void RemoveFriend(int userId, int friendId)
        {
            var acquaintances = _context.Acquaintances.FirstOrDefault(x => x.UserId == userId && x.AcquaintanceId == friendId);
            var isAcq = _context.Acquaintances.FirstOrDefault(x => x.UserId == friendId && x.AcquaintanceId == userId);

            if (acquaintances != null && isAcq != null)
            {
                _context.Acquaintances.Remove(acquaintances);
                _context.Acquaintances.Remove(isAcq);
                _context.SaveChanges();
            }
        }

        public void SetToken(string nickName, string token)
        {
            var user = _context.AppUsers.FirstOrDefault(x => x.Nickname == nickName);

            if (user != null)
            {
                user.Token = token;
                _context.SaveChanges();
            }
        }

        public void AddConfirmation(Confirmation confirmation)
        {
            _context.Confirmations.Add(confirmation);
            _context.SaveChanges();
        }

        public void AccountConfirmation(string link)
        {
            var confirmation = _context.Confirmations.FirstOrDefault(x => x.Link == link);
            
            if (confirmation != null)
            {
                confirmation.ConfirmationDate = DateTime.Now;
                var user = _context.AppUsers.FirstOrDefault(x => x.Id == confirmation.UserId);
                if (user != null)
                {
                    user.Active = true;
                }
                _context.SaveChanges();
            }
        }

        public IEnumerable<Acquaintance> GetUserFriends(int id)
        {
            return _context.Acquaintances.Where(x => x.UserId == id && !string.IsNullOrEmpty(x.ConfirmationDate.ToString()));
        }

        public IEnumerable<Acquaintance> GetPendingFriends(int id)
        {
            return _context.Acquaintances.Where(x => x.AcquaintanceId == id && string.IsNullOrEmpty(x.ConfirmationDate.ToString()));
        }

    }
}
