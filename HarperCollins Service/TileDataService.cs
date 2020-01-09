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
            var result = UnitOfWork.TileDataRepository.AddTileData(Mapper.Map<Repository.Models.TileData>(TileData));
            return Mapper.Map<TileData>(result);
        }

        public void DeleteTileData(TileData TileData)
        {
           UnitOfWork.TileDataRepository.DeleteTileData(Mapper.Map<Repository.Models.TileData>(TileData));

        }

        public async Task<TileData> GetTileData(string ISBN)
        {
            var result = await UnitOfWork.TileDataRepository.GetTileData(ISBN);
            return Mapper.Map<TileData>(result);
        }

        public async Task<IEnumerable<TileData>> GetTileDatas()
        {
            var result = await UnitOfWork.TileDataRepository.GetTileDatas();
            return Mapper.Map<IEnumerable<TileData>>(result);
        }

        public TileData UpdateTileData(TileData TileData)
        {
            var result = UnitOfWork.TileDataRepository.UpdateTileData(Mapper.Map<Repository.Models.TileData>(TileData));
            return Mapper.Map<TileData>(result);
        }
    }
}
