using DBMicroService1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DBMicroService1.Models
{
    public class ElectricityPriceInfo : BaseEntity
    {
        public DateTime EndDate { get; set; }
        public DateTime StartDate { get; set; }
        public decimal Price { get; set; }
    }
}
