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
        public IActionResult GetPortfolios()
        {
            //return new JsonResult(TradingDataStore.Current.Portfolios);
            
            /*
             *  KD:
             *  You can not use these HTTP Helper Status Code methods with JsonResult 
             *  Here you don't need to check whether the collection is empty because an empty collection is also a resource
             */
            return Ok(TradingDataStore.Current.Portfolios);
        }

        [HttpGet("{id}")]
        public IActionResult GetPortfolioById(int id)
        {
            //return new JsonResult(TradingDataStore.Current.Portfolios.FirstOrDefault(p => p.Id == id));
            var portfolioToReturn = TradingDataStore.Current.Portfolios.FirstOrDefault(p => p.Id == id);
            if (portfolioToReturn is null)
                return NotFound();
            else
                return Ok(portfolioToReturn);
        }
    }
}
