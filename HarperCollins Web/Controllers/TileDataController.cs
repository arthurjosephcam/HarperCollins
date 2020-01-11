using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using HarperCollins.WebApplication;
using HarperCollins.WebApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HarperCollins.Controllers
{
    //[Authorize] //we would use that, if we wanted to authorize.
    [Route("api/[controller]")]
    public class TileDataController : Controller
    {
        ITileDataService TileDataService;
        public TileDataController(ITileDataService TileDataService)
        {
            this.TileDataService = TileDataService;
        }


        [HttpGet("[action]")]
        public async Task<IEnumerable<TileData>> GetAllTiles()
        {
            var tileDatas = await TileDataService.GetTileDatas();

            try
            {
                return Mapper.Map<IEnumerable<TileData>>(tileDatas);
            }
            catch (Exception ex) { throw ex; }


        }

        [HttpGet("[action]")]
        public async Task<IEnumerable<TileData>> SearchTiles(String Keyword)
        {
            var tileDatas = await TileDataService.SearchTile(Keyword);

            try
            {
                return Mapper.Map<IEnumerable<TileData>>(tileDatas);
            }
            catch (Exception ex) { throw ex; }


        }
    }
}