﻿using System.Linq;

namespace DvdFormApp.Repositories
{
    public interface IItemRepository
    {
        IQueryable<Item> GetItems();
    }
}
