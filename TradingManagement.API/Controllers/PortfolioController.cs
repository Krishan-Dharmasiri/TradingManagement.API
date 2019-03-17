using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingManagement.API.Controllers
{
    [Route("api/v1/portfolios")]
    public class PortfolioController:Controller
    {
        [HttpGet]
        public JsonResult GetPortfolios()
        {
            return new JsonResult(TradingDataStore.Current.Portfolios);
        }

        [HttpGet("{id}")]
        public JsonResult GetPortfolioById(int id)
        {
            return new JsonResult(TradingDataStore.Current.Portfolios.FirstOrDefault(p => p.Id == id));
        }


    }
}
