using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<IEnumerable<TileData>> GetTileDatas()
        {
            return await Context.TileDatas
                 .AsNoTracking()
                 .ToArrayAsync()
                 ;
        }

        public TileData UpdateTileData(TileData TileData)
        {
            Context.TileDatas.Attach(TileData);
            Context.Entry(TileData).State = EntityState.Modified;
            return TileData;
        }

        public TileData AddTileData(TileData TileData)
        {
            return Context.TileDatas.Add(TileData);

        }

        public void DeleteTileData(TileData TileData)
        {
            Context.TileDatas.Attach(TileData);
            Context.Entry(TileData).State = EntityState.Deleted;
        }

        public async Task<TileData> GetTileData(string ISBN)
        {
            return await Context.TileDatas
                .Where(td => td.ISBN == ISBN)
                .FirstOrDefaultAsync()
               ;
        }
    }
}
