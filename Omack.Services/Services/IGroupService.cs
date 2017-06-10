using Omack.Data.Models;
using Omack.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Omack.Services.Services
{
    public interface IGroupService
    {
        IEnumerable<GroupServiceModel> GetAll();
        IEnumerable<GroupServiceModel> GetAll(Expression<Func<GroupServiceModel, bool>> where);
        GroupServiceModel GetById(int id);
        void Add(GroupServiceModel group);
        void Update(GroupServiceModel group);
        void Delete(int Id);
    }
}
