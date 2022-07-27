using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Abstract
{
    public interface IUserValidationService
    {

        bool Validate(User user);
    }
}
