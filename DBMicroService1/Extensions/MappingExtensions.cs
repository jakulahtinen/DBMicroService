using DBMicroService1;
using DBMicroService1.DTO;
using DBMicroService1.Models;

namespace DBMicroService1.Extensions
{
    public static class MappingExtensions
    {
        public static ElectricityPriceInfo ToEntity(this PriceInfo priceInfo)
        {
            return new ElectricityPriceInfo
            {
                StartDate = priceInfo.StartDate,
                EndDate = priceInfo.EndDate,
                Price = priceInfo.Price
            };
        }
    }
}
