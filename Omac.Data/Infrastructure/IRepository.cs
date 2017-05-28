using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Omack.Data.Infrastructure
{
    public interface IRepository
    {
        //why not IEnumerable?? Because We can further refine our query on an IQueryable, and will be executed in db not in server memory. 
        //But in case of IEnumerable, all the result will be returned to in memory and further query is executed, which slows down the server.
        IQueryable<Item> GetItems(Expression<Func<Item, bool>> filter);
        void GetItemById(int id);
    }
}
