using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrand : IBrandDal
    {
       
        public void Add(Brand entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var addedBrand = context.Entry(entity);
                addedBrand.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        

        public void Delete(Brand entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var deletedBrand = context.Entry(entity);
                deletedBrand.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return context.Set<Brand>().SingleOrDefault(filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return filter == null ? context.Set<Brand>().ToList() : context.Set<Brand>().Where(filter).ToList();
            }
        }

        public Brand GetCarsByBrandId(Expression<Func<Brand, bool>> filter)
        {

            using (CarDataContext context = new CarDataContext())
            {

                return context.Set<Brand>().Find(filter);
            }
        }

        public Brand GetCarsByColorId(Expression<Func<Brand, bool>> filter)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return context.Set<Brand>().Find(filter);
            }
        }

       
        public void Update(Brand entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var updatedBrand = context.Entry(entity);
                updatedBrand.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
