using Omack.Data.Infrastructure;
using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Omack.Services.Services
{
    public interface IItemService
    {
        IEnumerable<Item> GetAll();
        IEnumerable<Item> GetAll(Expression<Func<Item, bool>> where);
        Item GetById(int id);
    }
}
