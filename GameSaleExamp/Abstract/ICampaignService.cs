﻿using GameSaleProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSaleProject.Abstract
{
    public interface ICampaignService
    {
        void Add(Campaign campaign);

        void Delete(Campaign campaign);

        void Update(Campaign campaign);

    }
}
