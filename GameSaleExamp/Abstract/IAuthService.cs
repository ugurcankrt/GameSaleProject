using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Abstract
{
    public interface IAuthService
    {
        void Add(User user);

        void Delete(User user);

        void Update(User user);



    }
}
