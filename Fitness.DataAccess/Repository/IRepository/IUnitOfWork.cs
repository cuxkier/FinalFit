﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        IDietsCategoryRepository DietsCategory { get; }
        IDietRepository Diet { get; }
        IShoppingCartRepository ShoppingCart { get; }
        IApplicationUserRepository ApplicationUser { get; }
        IOrderDetailRepository OrderDetail { get; }
        IOrderHeaderRepository OrderHeader { get; }

        IProgressRepository Progress { get; }

        void Save();
    }
}
