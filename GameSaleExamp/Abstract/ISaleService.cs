using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Abstract
{
    public interface ISaleService
    {
             void Sale(User user, Game game, Campaign campaign);   

    }
}
