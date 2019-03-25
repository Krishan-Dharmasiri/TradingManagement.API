using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace TradingManagement.API.Controllers
{
    [Route("api/v1/portfolios")]
    public class ConstituentController:Controller
    {
        [HttpGet("{portfolioId}/constituents")]
        public IActionResult GetConstituents(int portfolioId)
        {
            var portfolio = TradingDataStore.Current.Portfolios.FirstOrDefault(p => p.Id == portfolioId);
            if (portfolio == null)
                return NotFound("The requested portfolio does not exist");

            if (portfolio.Constituents == null || portfolio.Constituents.Count == 0)
                return Ok("This portfolio does not have constituents associated with it");

            return Ok(portfolio.Constituents);
        }

        [HttpGet("{portfolioId}/constituents/{constituentId}")]
        public IActionResult GetConstituent(int portfolioId,int constituentId)
        {
            var portfolio = TradingDataStore.Current.Portfolios.FirstOrDefault(p => p.Id == portfolioId);
            if (portfolio == null)
                return NotFound("The requested portfolio does not exist");

            if (portfolio.Constituents == null || portfolio.Constituents.Count == 0)
                return Ok("This portfolio does not have constituents associated with it");

            var constituent = portfolio.Constituents.FirstOrDefault(c => c.Id == constituentId);

            if (constituent == null)
                return NotFound("The constituent does not exist with the given portfolio");

            return Ok(constituent);
        }
    }
}
