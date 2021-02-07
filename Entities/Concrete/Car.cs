using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string ModelYear { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }
        public string CarModel { get; set; }
        public string CarEngine { get; set; }
        public string CarType { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        
    }
}
