using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using Microsoft.AspNetCore.Mvc;

namespace HarperCollins.Controllers
{
    public class SalesDataController : Controller
    {
        ISalesDataService SalesDataService;
        public SalesDataController(ISalesDataService SalesDataService)
        {
            this.SalesDataService = SalesDataService;
        }
    }
}