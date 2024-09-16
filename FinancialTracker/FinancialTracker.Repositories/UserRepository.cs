using FinancialTracker.Core.Context;
using FinancialTracker.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialTracker.Repositories
{
    public class UserRepository
    {

        private FinancialTrackerContext ctx;
        public UserRepository(FinancialTrackerContext ctx) 
        { 
            this.ctx = ctx; 
        }
        public IEnumerable<User> GetAll()
        {
            return ctx.Users.ToList();
        }
        public User Get(int id)
        {
            return ctx.Users.Find(id);
        }

        public int Add(User user)
        {
            var obj = ctx.Users.Add(user);
            ctx.SaveChanges();
            return obj.Entity.Id_user;
        }
        public void Update(int Id, User updUser)
        {
            var users = ctx.Users.Find(Id);

            if (users.Name != updUser.Name || users.Email != updUser.Email || users.Password != updUser.Password)
            {
                users.Name = updUser.Name;
                users.Email = updUser.Email;
                users.Password = updUser.Password;

                ctx.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            ctx.Users.Remove(ctx.Users.Find(id));
            ctx.SaveChanges();
        }
        public User GetUserByUsername(string username)
        {
            return ctx.Users.FirstOrDefault(u => u.Name == username);
        }
    }
}
