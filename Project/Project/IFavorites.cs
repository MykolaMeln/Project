﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    interface IFavorites
    {
        string AddFavorite(Favorite favorite);
        void DeleteFavorite(Favorite favorite);
    }
}
