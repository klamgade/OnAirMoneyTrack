using Omack.Data.DAL;
using Omack.Data.Infrastructure.Repositories;
using Omack.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.Infrastructure
{
    public class UnitOfWork : IDisposable
    {
        private OmackContext context = new OmackContext();       
        public GroupRepository groupRepository { get; set; }
        public UnitOfWork()
        {
            groupRepository = new GroupRepository(context);
            //if(this.itemRepository == null)
            //{
            //    itemRepository = new ItemRepository(context);
            //    this.groupRepository = new GroupRepository(context);

            //}
        }
        public void Save()
        {
            context.SaveChanges(); //save changes to the db.
        }
        private bool disposed = false;  //initially set disposed to false.
        void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;   //changed it to true once it is disposed
        }

        public void Dispose() //gets called everytime the unitofwork is called. Because it is of IDisposable type
        {
            Dispose(true); //call above method Dispose(bool disposing). Remember that method is valid because it has different methods. AKA overload methods.
            GC.SuppressFinalize(this);
        }       
    }
}
