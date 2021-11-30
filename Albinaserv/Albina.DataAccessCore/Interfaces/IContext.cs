using Albina.DataAccessCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Albina.DataAccessCore.Interfaces
{
    public interface IContext : IDisposable, IAsyncDisposable
    {
        DbSet<UserRto> Users { get; set; }
        DbSet<VirtualExpenseRto> VirtualExpenses { get; set; }
        DbSet<RejectExpenseRto> RejectExpenses { get; set; }
        DbSet<AcceptExpenseRto> AcceptExpenses { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
