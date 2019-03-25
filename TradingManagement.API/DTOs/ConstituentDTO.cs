using TradingManagement.API.Enums;

namespace TradingManagement.API.DTOs
{
    public class ConstituentDTO
    {
        public int Id { get; set; }
        public string ConstitunetType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
