using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TradingManagement.API.DTOs;
using TradingManagement.API.Enums;

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
            var constituentsOne = new List<ConstituentDTO>
            {
                new ConstituentDTO{Id = 1, ConstitunetType = ConstituentType.Stock.ToString(), CurrentPrice=153.4m, Name="JKH.N0000", Quantity=1000, Description= "John Keels Holdings"},
                new ConstituentDTO{Id = 2, ConstitunetType = ConstituentType.Stock.ToString(), CurrentPrice=189.0m, Name="SAMP.N0000", Quantity=3000, Description= "Sampath Bannk PLC"},
                new ConstituentDTO{Id = 3, ConstitunetType = ConstituentType.Stock.ToString(), CurrentPrice=3.4m, Name="RAL.N0000", Quantity=500, Description= "Renuka Hotels PLC"},
                new ConstituentDTO{Id = 4, ConstitunetType = ConstituentType.Stock.ToString(), CurrentPrice=15.4m, Name="NDB.N0000", Quantity=1500, Description= "Nations 'Developemnt Bank"}
            };

            Portfolios = new List<PortfolioDTO>
            {
                new PortfolioDTO {Id =1, Name="Portfolio One",Type="Equity", Constituents = constituentsOne},
                new PortfolioDTO {Id =2, Name="Portfolio Two",Type="FixedIncome"},
                new PortfolioDTO {Id =3, Name="Portfolio Three",Type="Currency"},
                new PortfolioDTO {Id =4, Name="Portfolio Four",Type="FixedIncome"},
                new PortfolioDTO {Id =5, Name="Portfolio Five",Type="Equity"},
            };
        }
    }
}
