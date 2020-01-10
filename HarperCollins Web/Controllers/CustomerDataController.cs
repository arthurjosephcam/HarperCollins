using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarperCollins.Service;
using Microsoft.AspNetCore.Mvc;

namespace HarperCollins.Controllers
{
    public class CustomerDataController : Controller
    {
        ICustomerDataService CustomerDataService;
        public CustomerDataController(ICustomerDataService CustomerDataService)
        {
            this.CustomerDataService = CustomerDataService;
        }
    }
}