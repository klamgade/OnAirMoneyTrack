using Omack.Services.Services;
using System;
using System.Collections.Generic;
using System.Text;
using Omack.Data.Models;
using System.Linq;
using System.Linq.Expressions;
using Omack.Data.Infrastructure;

namespace Omack.Services.ServiceImplementations
{
    public class ItemService: IItemService
    {
        private UnitOfWork _unitOfWork;
        public ItemService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Item> GetAll()
        {
           return _unitOfWork.itemRepository.GetAll().ToList();
        }

        public IEnumerable<Item> GetAll(Expression<Func<Item, bool>> where)
        {
            return _unitOfWork.itemRepository.GetAll(i => i.Name.Equals("Test")).ToList();
        }

        public Item GetById(int id)
        {
            return _unitOfWork.itemRepository.GetById(id);
        }
    }
}
