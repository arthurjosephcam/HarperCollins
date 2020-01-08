using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Repository
{
    public interface IUnitOfWork
    {
        ITileDataRepository TileDataRepository { get; }
        ISalesDataRepository SalesDataRepository { get; }
        ICustomerDataRepository CustomerDataRepository { get; }

        Task SaveChangesAsync();

        void SaveChanges();
    }
}
