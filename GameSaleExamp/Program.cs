using GameSaleProject.Abstract;
using GameSaleProject.Concrete;
using GameSaleProject.Entities;
using System;

namespace GameSaleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User() { FirstName = "Uğurcan", LastName = "KURT", TcNo = "123456"};

            UserManager userManager = new UserManager(new UserValidationManager());
            userManager.Add(user1);


        }
    }
}
