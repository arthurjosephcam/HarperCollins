using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarperCollins.Repository;
using HarperCollins.Service.Models;

namespace HarperCollins.Service
{
    public class TileDataService : ITileDataService
    {
        private readonly IUnitOfWork UnitOfWork;
        public TileDataService(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
        public TileData AddTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }

        public void DeleteTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }

        public Task<TileData> GetTileData(string ISBN)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TileData>> GetTileDatas()
        {
            throw new NotImplementedException();
        }

        public TileData UpdateTileData(TileData TileData)
        {
            throw new NotImplementedException();
        }
    }
}
