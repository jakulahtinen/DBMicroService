using System.IO;
using System.Runtime.CompilerServices;

namespace DBMicroService1.DTO
{
    public class ElectricityPriceDataDtoIn
    {
        public List<PriceInfo> Prices { get; set; }
    }
}

public class PriceInfo
{
    public decimal Price { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}
