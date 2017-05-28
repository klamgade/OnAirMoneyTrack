using System;
using System.Collections.Generic;
using System.Text;

namespace Omack.Data.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        void Save();
    }
}
