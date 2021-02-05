using DataAccess.Abstract;

using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColor : IColorDal
    {
        public void Add(Color entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var addedColor = context.Entry(entity);
                addedColor.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var deletedColor = context.Entry(entity);
                deletedColor.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return context.Set<Color>().SingleOrDefault(filter);
            }
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return filter == null ? context.Set<Color>().ToList() : context.Set<Color>().Where(filter).ToList();
            }
        }

        public Color GetCarsByBrandId(Expression<Func<Color, bool>> filter)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return context.Set<Color>().Find(filter);
            }
        }

        public Color GetCarsByColorId(Expression<Func<Color, bool>> filter)
        {
            using (CarDataContext context = new CarDataContext())
            {
                return context.Set<Color>().Find(filter);
            }
        }

        public void Update(Color entity)
        {
            using (CarDataContext context = new CarDataContext())
            {
                var updatedColor = context.Entry(entity);
                updatedColor.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
