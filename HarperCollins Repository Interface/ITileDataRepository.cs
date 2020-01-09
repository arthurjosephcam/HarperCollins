using HarperCollins.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarperCollins.Repository
{
    public interface ITileDataRepository
    {
        Task<IEnumerable<TileData>> GetTileDatas();
        TileData UpdateTileData(TileData TileData);
        TileData AddTileData(TileData TileData);
        void DeleteTileData(TileData TileData);

        Task<TileData> GetTileData(String ISBN);
    }

}
