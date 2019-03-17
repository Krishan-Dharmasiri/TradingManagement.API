using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TradingManagement.API.DTOs
{
    public class PortfolioDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public decimal Return { get; set; }
    }
}
