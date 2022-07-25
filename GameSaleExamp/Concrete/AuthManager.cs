using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concrete
{
    public class AuthManager : IAuthService
    {
        public void Add(User user)
        {
            if (user ==null)
            {
                Console.WriteLine("Kullanıcı eklemesi başarısız.");
            }

            else
            {
                Console.WriteLine(user.FirstName + " adlı kullanıcı eklendi.");
            }

        }


        public void Delete(User user)
        {
            Console.WriteLine(user.FirstName + " adlı kullanıcı silindi.");
        }

        public void Update(User user)
        {
            Console.WriteLine(user.FirstName + " adlı kullanıcı güncellendi.");
        }
    }
}
