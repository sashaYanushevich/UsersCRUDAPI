using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using UsersCRUDAPI.EFCore;
using UsersCRUDAPI.Models;

namespace UsersCRUDAPI.Helpers
{
	public class DbHelpers
	{
        private readonly EFDataContext _context;

        public DbHelpers(EFDataContext context)
        {
            _context = context;
        }

        public List<User> GetUsers()
        {
            return _context.Users.Include(x => x.UserRoles).ThenInclude(ur => ur.Role).ToList();
        }

        public User GetUser(int id)
        {
            return _context.Users.Where(p => p.Id == id).FirstOrDefault();
        }

        public bool UserExists(int id)
        {
            return _context.Users.Any(u => u.Id == id);
        }

        public bool CreateUser(User user)
        {
            _context.Add(user);
            return Save();
        }

        public bool UpdateUser(User user)
        {
            _context.Update(user);
            return Save();
        }

        public bool DeleteUser(User user)
        {
            _context.Remove(user);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}


