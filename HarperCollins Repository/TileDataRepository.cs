using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository.Models;

namespace HarperCollins.Repository
{
    public class TileDataRepository : ITileDataRepository
    {
        DbContext Context { get; set; }
        internal TileDataRepository(DbContext Context)
        {
            this.Context = Context;
        }

        public Task<IEnumerable<TileData>> GetTileDatas()
        {
            throw new NotImplementedException();
        }

        public TileData UpdateTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }

        public TileData AddTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }

        public void DeleteTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }

        public Task<CustomerData> GetTileData(string ISBN)
        {
            throw new NotImplementedException();
        }
    }
}
