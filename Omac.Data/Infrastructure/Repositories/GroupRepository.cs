using Omack.Data.DAL;
using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.Infrastructure.Repositories
{
    public class GroupRepository: GenericRepository<Group> , IGroupRepository
    {
        public GroupRepository(OmackContext context): base(context)
        {
                
        }
    }

    public interface IGroupRepository: IGenericRepository<Group>
    {

    }
}
