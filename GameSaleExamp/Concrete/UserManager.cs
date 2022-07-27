using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concrete
{
    public class UserManager : IUserService
    {
        IUserValidationService _userValidationService;

        public UserManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(User user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine(user.FirstName+" kayıt oldu.");
            }
            else
            {
                Console.WriteLine("Kayıt başarısız.");
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
