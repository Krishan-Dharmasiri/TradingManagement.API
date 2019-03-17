using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingManagement.API.DTOs;

namespace TradingManagement.API
{
    public class TradingDataStore
    {
        //Auto property initilizer
        //This is an immutaable instance as this is read only with only getter
        //the same oneis available as this is static and as long as we don't restart the application
        public static TradingDataStore Current { get; } = new TradingDataStore();

        public List<PortfolioDTO> Portfolios { get; set; }

        public TradingDataStore()
        {
            Portfolios = new List<PortfolioDTO>
            {
                new PortfolioDTO {Id =1, Name="Portfolio One",Type="Equity"},
                new PortfolioDTO {Id =2, Name="Portfolio Two",Type="FixedIncome"},
                new PortfolioDTO {Id =3, Name="Portfolio Three",Type="Currency"},
                new PortfolioDTO {Id =4, Name="Portfolio Four",Type="FixedIncome"},
                new PortfolioDTO {Id =5, Name="Portfolio Five",Type="Equity"},
            };
        }
    }
}
