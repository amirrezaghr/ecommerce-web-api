using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entites.Base;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        Task<int> Save(CancellationToken cancellationToken);
        IGenericRepository<T> Repository<T>() where T : BaseEntity;
    }
}
