using GameSaleProject.Abstract;
using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Concrete
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(User user)
        {
            if (user.FirstName == "Uğurcan" && user.LastName == "KURT" && user.TcNo == "123456")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
