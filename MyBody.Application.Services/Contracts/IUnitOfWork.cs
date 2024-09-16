using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBody.Application.Services.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        Task<bool> Commit();
        bool HasChanges();
    }
}
