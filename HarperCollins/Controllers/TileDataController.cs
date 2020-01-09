using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using Microsoft.AspNetCore.Mvc;

namespace HarperCollins.Controllers
{
    public class TileDataController : Controller
    {
        ITileDataService TileDataService;
        public TileDataController(ITileDataService TileDataService)
        {
            this.TileDataService = TileDataService;
        }
    }
}