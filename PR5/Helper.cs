    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PR5.Models;
namespace PR5
{
    internal class Helper
    {
        private static AutobaseEntities1 _context;
        public static AutobaseEntities1 GetContext()
        {
            if (_context == null)
            {
                _context = new AutobaseEntities1();
            }
            return _context;
        }
        public void CreateUser(Users user)
        {
                _context.Users.Add(user);
                _context.SaveChanges();
            
           
        }
        private void UpdateUser(Users users)
        {
            _context.Entry(users).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
        }

        public void RemoveUser(int UserID)
        {
            var users = _context.Users.Find(UserID);
            _context.Users.Remove(users);
            _context.SaveChanges();
        }

        public List<Users> FiltrUsers()
        {
            return _context.Users.OrderBy(x => x.Login.StartsWith("M") || x.Login.StartsWith("A")).ToList();
        }

        public List<Users> SortUsers()
        {
            return _context.Users.OrderBy(x => x.Login).ToList();
        }

        public string GetUserTypes(Employees employee)
        {

            return employee.Positions.PositionID.ToString();
        }
    }
}
