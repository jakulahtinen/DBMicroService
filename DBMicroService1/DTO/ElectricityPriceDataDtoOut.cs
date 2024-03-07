using System.Collections.Generic;

namespace DBMicroService1.DTO
{
    public class ElectricityPriceDataDtoOut
    {
        public List<PriceInfo> Prices { get; set; }
        public int PageSize { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
