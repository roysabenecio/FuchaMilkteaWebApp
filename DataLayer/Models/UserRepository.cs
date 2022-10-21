using Fucha.DomainClasses;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.Models
{
    public class UserRepository : IDisposable // implement an interface that also implement IDisposable
    {
        // modifier subject to change
        readonly FuchaMilkteaContext _context = new FuchaMilkteaContext();
        
        public List<User> GetUsers()
        {
            return _context.Users.ToList();
        }







        public IQueryable<User> All
        {
            get { return _context.Users; }
        }
        public User Find(int id)
        {
            return _context.Users.Find(id);
        }
        public void InsertOrUpdate(User user)
        {
            if(user.Id == default(int))
            {
                _context.Users.Add(user);
            } else
            {
                _context.Entry(user).State = EntityState.Modified;
            }
        }
        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
        }
        //public void Save()
        //{
            
        //}
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
