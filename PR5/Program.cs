using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using PR5.Models;
using HashPassword;
namespace PR5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Helper.GetContext();
            Helper helper = new Helper();
            HashPassword.Hash hash = new HashPassword.Hash();

            Console.WriteLine("Введите логин: ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль: ");
            string password = Console.ReadLine();
            Console.WriteLine("Введите ID сотрудника: ");
            int EmployeeID = int.Parse(Console.ReadLine());

            string hashPassw = hash.hashPassword(password);
            Console.WriteLine($"Хэшированный пароль: {hashPassw}");

            Users users = new Users();
            users.Login = login;
            users.Password = hashPassw;
            users.EmployeeID = EmployeeID;

            helper.CreateUser(users);

            Console.WriteLine("Учетная запись добавлена");

            Console.ReadLine();
        }
    }
}
