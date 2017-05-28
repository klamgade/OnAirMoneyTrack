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
        
        public ItemRepository itemRepository { get; set; }
        public UnitOfWork()
        {
            if(this.itemRepository == null)
            {
                this.itemRepository = new ItemRepository(context);
            }
        }
        public void Save()
        {
            context.SaveChanges(); //save changes to the db.
        }
        private bool disposed = false;  //initially set disposed to false.

        protected virtual void Dispose(bool disposing)
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

        public void Dispose()
        {
            Dispose(true); //call above method Dispose(bool disposing). Remember that method is valid because it has different methods. AKA overload methods.
            GC.SuppressFinalize(this);
        }       
    }
}
