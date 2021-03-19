using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCar : EfEntityRepositoryBase<Car, CarDataContext>, ICarDal
    {
        public CarDetailDto GetCarDetail(int carId)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from p in context.Cars.Where(p => p.Id == carId)
                             join c in context.Colors
                             on p.ColorId equals c.ColorId
                             join d in context.Brands
                             on p.BrandId equals d.BrandId
                             select new CarDetailDto
                             {
                                 BrandName = d.BrandName,
                                 ColorName = c.ColorName,
                                 UnitPrice = p.UnitPrice,
                                 ModelYear = p.ModelYear,
                                 CarName = p.CarName,
                                 CarEngine = p.CarEngine,
                                 CarType = p.CarType,
                                 CarModel = p.CarModel,
                                 Id = p.Id
                             };
                return result.SingleOrDefault();
            }
        }
        public List<CarDetailDto> GetCarDetails(Expression<Func<Car, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var result = from c in filter == null ? context.Cars : context.Cars.Where(filter)
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join clr in context.Colors
                             on c.ColorId equals clr.ColorId
                             select new CarDetailDto { Id = c.Id, 
                                 ModelYear = c.ModelYear, 
                                 UnitPrice = c.UnitPrice,
                                 BrandName = b.BrandName, 
                                 ColorName = clr.ColorName,
                                 CarName = c.CarName,
                                 CarEngine = c.CarEngine,
                                 CarType = c.CarType,
                                 CarModel = c.CarModel,
                                 BrandId = b.BrandId,
                                 ColorId = c.ColorId };
                return result.ToList();
            }
        }
    }
}
