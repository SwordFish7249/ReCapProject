using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public string CarModel { get; set; }
        public string ModelYear { get; set; }
        public string CarEngine { get; set; }
        public string CarType { get; set; }
        public int Id { get; set; }
        public int UnitsInStock { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public decimal UnitPrice { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
    }
}
